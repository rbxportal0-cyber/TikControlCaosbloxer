using System.IO;
using System.Text.Json;
using System.Windows;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.Wpf;
using TikControl.Core;

namespace TikControl.App;

public partial class MainWindow : Window
{
    private readonly TikTokService _service = new();

    public MainWindow()
    {
        InitializeComponent();
        Loaded += OnLoaded;
        Closed += (_, _) => _service.Dispose();
    }

    private async void OnLoaded(object sender, RoutedEventArgs e)
    {
        var webRoot = WebRootPath();
        Directory.CreateDirectory(webRoot);

        var env = await CoreWebView2Environment.CreateAsync(null, null, null);
        await Web.EnsureCoreWebView2Async(env);

        // VirtualHost: app.tikcontrol -> carpeta web
        Web.CoreWebView2.SetVirtualHostNameToFolderMapping(
            "app.tikcontrol",
            webRoot,
            CoreWebView2HostResourceAccessKind.Allow);

        Web.CoreWebView2.WebMessageReceived += OnWebMessage;

        // Conectar eventos del Core -> interfaz
        _service.EventReceived += PushEvent;
        _service.StateChanged += (state, detail) => PushState();

        // Cargar el dashboard del panel
        Web.CoreWebView2.Navigate("https://app.tikcontrol/panel/dashboard.html");

        // Empezar en modo demo (la UI puede conectar a un directo real)
        _service.StartDemo();
    }

    private string WebRootPath()
        => Path.Combine(AppContext.BaseDirectory, "web");

    // JS -> C#: comandos desde el panel
    private void OnWebMessage(object sender, CoreWebView2WebMessageReceivedEventArgs e)
    {
        string json;
        try { json = e.TryGetWebMessageAsString() ?? ""; }
        catch { return; }

        if (string.IsNullOrWhiteSpace(json)) return;

        try
        {
            using var doc = JsonDocument.Parse(json);
            var type = doc.RootElement.GetProperty("type").GetString();

            switch (type)
            {
                case "connect":
                {
                    var user = doc.RootElement.GetProperty("username").GetString();
                    _ = _service.ConnectAsync(user ?? "");
                    break;
                }
                case "disconnect":
                    _service.Stop();
                    break;
            }
        }
        catch
        {
            // JSON inválido o comando desconocido: ignorar.
        }
    }

    // C# -> JS: un evento entrante
    private void PushEvent(TikTokEvent ev)
    {
        Dispatcher.BeginInvoke(() =>
        {
            if (Web.CoreWebView2 is null) return;
            var json = JsonSerializer.Serialize(new
            {
                ev.Kind, ev.User, ev.Label, ev.Detail, ev.Value, ev.Emoji
            });
            var js = $"window.tikControl && window.tikControl.onEvent({json})";
            try { Web.CoreWebView2.ExecuteScriptAsync(js); }
            catch { /* ventana cerrada */ }
        });
    }

    // C# -> JS: estado de la conexión (modo demo/conectado/errores)
    private void PushState()
    {
        Dispatcher.BeginInvoke(() =>
        {
            if (Web.CoreWebView2 is null) return;
            var json = JsonSerializer.Serialize(new
            {
                state = _service.State.ToString().ToLowerInvariant(),
                username = _service.ConnectedUsername,
                viewers = _service.ViewerCount,
                diamonds = _service.TotalDiamonds,
                followers = _service.TotalFollowers,
                comments = _service.TotalComments
            });
            var js = $"window.tikControl && window.tikControl.onState({json})";
            try { Web.CoreWebView2.ExecuteScriptAsync(js); }
            catch { /* ventana cerrada */ }
        });
    }
}
