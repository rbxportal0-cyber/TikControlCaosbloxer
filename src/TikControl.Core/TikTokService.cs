using System.Collections.ObjectModel;
using TikTokLiveSharp.Client;
using TikTokLiveSharp.Events;
using TikTokLiveSharp.Events.Objects;

namespace TikControl.Core;

/// <summary>Estado actual de la conexión de eventos.</summary>
public enum TikTokConnectionState
{
    Demo,
    Connecting,
    Connected,
    Disconnected
}

/// <summary>
/// Fuente de eventos del LIVE de TikTok.
/// Puede emitir eventos de demostración (simulados) o conectarse a un DIRECT
/// real de TikTok mediante TikTokLiveSharp.
/// </summary>
public sealed class TikTokService : IDisposable
{
    private readonly CancellationTokenSource _cts = new();
    private readonly Random _rnd = new();
    private bool _demoRunning;
    private TikTokLiveClient? _client;

    private static readonly string[] _users =
    {
        "JuanCaos", "LaPug", "Zelnick", "MissLivid", "RobloxQueen",
        "CaosGamer", "NovaLive", "TikQueen", "StreamPro", "LunaDx"
    };

    /// <summary>Lista observable en vivo de los últimos eventos (para el panel).</summary>
    public ObservableCollection<TikTokEvent> RecentEvents { get; } = new();

    /// <summary>Se dispara por cada evento entrante (alimenta overlay + panel).</summary>
    public event Action<TikTokEvent>? EventReceived;

    /// <summary>Se dispara cuando cambia el estado de la conexión.</summary>
    public event Action<TikTokConnectionState, string>? StateChanged;

    /// <summary>Cuenta total de diamantes recibidos en esta sesión.</summary>
    public int TotalDiamonds { get; private set; }
    public int TotalFollowers { get; private set; }
    public int TotalComments { get; private set; }

    public TikTokConnectionState State { get; private set; } = TikTokConnectionState.Demo;
    public string? ConnectedUsername { get; private set; }
    public int ViewerCount { get; private set; }
    public bool HasLiveClient => _client is not null;

    /// <summary>Inicia la emisión de eventos de demo (modo base).</summary>
    public void StartDemo()
    {
        if (_demoRunning) return;
        _demoRunning = true;
        SetState(TikTokConnectionState.Demo, "Modo DEMO: eventos simulados");

        _ = Task.Run(async () =>
        {
            while (!_cts.IsCancellationRequested)
            {
                await Task.Delay(_rnd.Next(1200, 3200), _cts.Token).ConfigureAwait(false);
                Publish(RandomEvent());
            }
        }, _cts.Token);
    }

    public bool StopDemo()
    {
        if (!_demoRunning) return false;
        _demoRunning = false;
        return true;
    }

    /// <summary>
    /// Conecta a un directo real de TikTok identificado por el @username del
    /// streamer. Falla (o vuelve a ser posible el demo) si no hay emisión.
    /// </summary>
    public async Task<bool> ConnectAsync(string username)
    {
        username = username.Trim().TrimStart('@');
        if (string.IsNullOrEmpty(username)) return false;

        StopDemo();
        SetState(TikTokConnectionState.Connecting, $"Conectando a @{username}...");

        try
        {
            if (_client is not null) await _client.Stop().ConfigureAwait(false);

            var client = new TikTokLiveClient(uniqueID: username);
            _client = client;
            Subscribe(client);

            ConnectedUsername = username;
            await client.Start(cancellationToken: null, retryConnection: true).ConfigureAwait(false);
            return true;
        }
        catch (Exception ex)
        {
            SetState(TikTokConnectionState.Disconnected, $"No se pudo conectar: {ex.Message}");
            return false;
        }
    }

    public void Stop()
    {
        try { if (_client is not null) _ = _client.Stop(); } catch { /* ignorar */ }
        _client = null;
        ConnectedUsername = null;
        if (State != TikTokConnectionState.Demo)
            SetState(TikTokConnectionState.Demo, "Conexión detenida. Modo DEMO de nuevo.");
    }

    private void Subscribe(TikTokLiveClient client)
    {
        client.OnConnected += (_, e) => SetState(TikTokConnectionState.Connected, $"Conectado a @{ConnectedUsername}");
        client.OnDisconnected += (_, _) => SetState(TikTokConnectionState.Disconnected, "Desconectado de TikTok");

        client.OnChatMessage += (_, msg) =>
            Publish(new TikTokEvent
            {
                Kind = TikTokEventKind.Comment,
                User = UserName(msg.Sender),
                Label = msg.Message,
                Detail = "Comentario en el chat"
            });

        client.OnFollow += (_, ev) =>
            Publish(new TikTokEvent
            {
                Kind = TikTokEventKind.Follow,
                User = UserName(ev.User),
                Label = "Te está siguiendo",
                Detail = "Nuevo seguidor"
            });

        client.OnLike += (_, like) =>
            Publish(new TikTokEvent
            {
                Kind = TikTokEventKind.Comment,
                User = UserName(like.Sender),
                Label = "❤️ me gusta",
                Detail = "Me gusta en el chat"
            });

        client.OnGift += (_, gift) =>
        {
            var name = gift.Gift?.Name ?? $"Regalo ({gift.Gift?.Id ?? -1})";
            var unit = gift.Gift?.DiamondCost ?? 1;
            var total = unit * (int)Math.Max(1, gift.Amount);
            Publish(new TikTokEvent
            {
                Kind = TikTokEventKind.Gift,
                User = UserName(gift.Sender),
                Label = name,
                Detail = $"{gift.Amount} x {unit} 💎 (total {total}💎)",
                Value = total
            });
        };

        client.OnRoomUpdate += (_, room) =>
        {
            ViewerCount = (int)room.NumberOfViewers;
            SetState(State, $"Espectadores: {ViewerCount}");
        };

        client.OnException += (_, ex) =>
            SetState(TikTokConnectionState.Disconnected, $"Error: {ex.Message}");
    }

    private static string UserName(User? u)
        => !string.IsNullOrEmpty(u?.NickName) ? u!.NickName
         : !string.IsNullOrEmpty(u?.UniqueId) ? u!.UniqueId
         : "Anónimo";

    private void SetState(TikTokConnectionState newState, string detail)
    {
        State = newState;
        StateChanged?.Invoke(newState, detail);
    }

    /// <summary>Publica un evento (lo usan demo y conector real).</summary>
    public void Publish(TikTokEvent ev)
    {
        switch (ev.Kind)
        {
            case TikTokEventKind.Gift: TotalDiamonds += ev.Value; break;
            case TikTokEventKind.Follow: TotalFollowers++; break;
            case TikTokEventKind.Comment: TotalComments++; break;
        }

        RecentEvents.Insert(0, ev);
        while (RecentEvents.Count > 60) RecentEvents.RemoveAt(RecentEvents.Count - 1);

        EventReceived?.Invoke(ev);
    }

    private TikTokEvent RandomEvent()
    {
        switch (_rnd.Next(0, 4))
        {
            case 0:
            case 1:
            {
                var user = _users[_rnd.Next(_users.Length)];
                var gift = new[] { "Rosa", "Cohete", "Galaxia", "Fénix", "Corazón", "Corona" }[_rnd.Next(6)];
                var value = new[] { 1, 5, 10, 20, 50, 100, 520 }[_rnd.Next(7)];
                return new TikTokEvent
                {
                    Kind = TikTokEventKind.Gift,
                    User = user,
                    Label = gift,
                    Detail = $"Diamantes de esta joya: {value}",
                    Value = value
                };
            }
            case 2:
            {
                var user = _users[_rnd.Next(_users.Length)];
                return new TikTokEvent { Kind = TikTokEventKind.Follow, User = user, Label = "Te está siguiendo" };
            }
            default:
            {
                var user = _users[_rnd.Next(_users.Length)];
                var messages = new[]
                {
                    "¡Vamos!", "GG", "Primer mensaje", "¡Qué buen directo!",
                    "Hola desde Team Caos", "Sube el volumen", "GG WP"
                };
                return new TikTokEvent
                {
                    Kind = TikTokEventKind.Comment,
                    User = user,
                    Label = messages[_rnd.Next(messages.Length)],
                    Detail = "Comentario en el chat"
                };
            }
        }
    }

    public void Dispose()
    {
        _cts.Cancel();
        try { if (_client is not null) _ = _client.Stop(); } catch { /* ignorar */ }
        _client = null;
    }
}
