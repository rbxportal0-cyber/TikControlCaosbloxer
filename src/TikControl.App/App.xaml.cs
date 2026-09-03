using System.Windows;
using System.Threading.Tasks;
using TikControl.Core;

namespace TikControl.App;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    private UpdaterService? _updater;

    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        // Chequeo silencioso de actualización en segundo plano (no bloquea la UI ni el diseño)
        _ = RunAutoUpdateAsync();
    }

    /// <summary>
    /// Lanza el auto-update una sola vez al abrir la app, de forma invisible.
    /// La URL se puede sobreescribir con la variable de entorno
    /// TIKCONTROL_UPDATE_URL (p. ej. la raw del update.json en tu rama gh-pages).
    /// </summary>
    private async Task RunAutoUpdateAsync()
    {
        // URL por defecto (sobreescribible en tiempo de ejecución con la variable
        // de entorno TIKCONTROL_UPDATE_URL).
        string url = System.Environment.GetEnvironmentVariable("TIKCONTROL_UPDATE_URL")
                     ?? "https://raw.githubusercontent.com/rbxportal0-cyber/TikControlCaosbloxer/gh-pages/update.json";

        _updater = new UpdaterService(url);

        // Chequeo inicial al abrir la app (restart:true -> descarga, reemplaza y reinicia).
        await _updater.CheckAsync(restart: true).ConfigureAwait(false);

        // Chequeos periódicos cada 5 minutos en segundo plano, de forma invisible.
        _updater.StartBackgroundChecks(intervalMinutes: 5);
    }

    protected override void OnExit(ExitEventArgs e)
    {
        _updater?.Dispose();
        base.OnExit(e);
    }
}

