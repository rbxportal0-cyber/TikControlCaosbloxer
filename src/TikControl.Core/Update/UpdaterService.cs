using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace TikControl.Core;

/// <summary>Resultado del chequeo de actualización.</summary>
public enum UpdateCheckResult
{
    NoUpdate,
    UpdateDownloaded,
    Error
}

/// <summary>
/// Gestor de actualizaciones automáticas para el ejecutable.
///
/// Flujo:
///  1. Consulta silenciosa (HttpClient) a "update.json" publicado en la rama de distribución.
///  2. Compara la versión remota con la local.
///  3. Si hay una versión mayor, descarga el nuevo .exe en segundo plano,
///     reemplaza el actual y reinicia la aplicación con el nuevo diseño aplicado.
///
/// Esto reemplaza el "main process + fetch" de un stack Electron/Tauri: en una app
/// WPF/.NET el auto-update se hace en código del host (C#), no en el JS del WebView2.
/// </summary>
public sealed class UpdaterService : IDisposable
{
    private readonly HttpClient _http;
    private readonly string _updateUrl;
    private readonly string _exePath;
    private readonly string _newExePath;
    private readonly string _version;

    /// <summary>Se dispara cuando el auto-update informa de algo (para mostrarlo silenciosamente o por consola).</summary>
    public event Action<string>? Log;
    /// <summary>Se dispara al descargar una actualización (bytes totales, bytes descargados).</summary>
    public event Action<long, long>? DownloadProgress;

    /// <summary>
    /// Crea el servicio.
    /// </summary>
    /// <param name="updateUrl">URL completa del update.json (p. ej. GitHub raw de la rama de distribución).</param>
    /// <param name="version">Versión local de la app. Si es null se lee de la versión del ensamblado.</param>
    public UpdaterService(string updateUrl, string? version = null)
    {
        _updateUrl = updateUrl;
        _http = new HttpClient { Timeout = TimeSpan.FromSeconds(30) };
        _http.DefaultRequestHeaders.UserAgent.ParseAdd("TikControlCaosbloxer-AutoUpdater/1.0");

        _exePath = Environment.ProcessPath
                   ?? Process.GetCurrentProcess().MainModule?.FileName
                   ?? Path.Combine(AppContext.BaseDirectory, "TikControlCaosbloxer.exe");
        _newExePath = _exePath + ".new";
        _version = version ?? Assembly.GetEntryAssembly()?.GetName().Version?.ToString(3) ?? "1.0.0";
    }

    /// <summary>Versión local de la app.</summary>
    public string CurrentVersion => _version;

    /// <summary>
    /// Comprueba y, si procede, descarga la actualización y reinicia la app.
    /// </summary>
    /// <param name="restart">
    /// true: descarga, reemplaza y reinicia automáticamente.
    /// false: solo comprueba si hay actualización disponible (sin descargar).
    /// </param>
    public async Task<UpdateCheckResult> CheckAsync(bool restart = true, CancellationToken ct = default)
    {
        try
        {
            Log?.Invoke($"Comprobando actualizaciones en {_updateUrl}");

            string json = await _http.GetStringAsync(_updateUrl, ct).ConfigureAwait(false);
            using var doc = JsonDocument.Parse(json);
            var root = doc.RootElement;

            string remoteVersion = root.GetProperty("version").GetString() ?? "";
            string downloadUrl = root.GetProperty("url").GetString() ?? "";

            Log?.Invoke($"Versión local: {_version} | Remota: {remoteVersion}");

            if (!IsNewer(remoteVersion, _version))
            {
                Log?.Invoke("No hay actualizaciones disponibles.");
                return UpdateCheckResult.NoUpdate;
            }

            Log?.Invoke($"Actualización a {remoteVersion} disponible. Descargando...");

            // Descargar en segundo plano con reporte de progreso
            byte[] data = await DownloadAsync(downloadUrl, ct).ConfigureAwait(false);

            if (!restart)
            {
                Log?.Invoke("Actualización descargada (modo solo-chequeo).");
                return UpdateCheckResult.UpdateDownloaded;
            }

            // Reemplazar el exe y reiniciar
            ApplyAndRestart(data);
            return UpdateCheckResult.UpdateDownloaded;
        }
        catch (OperationCanceledException)
        {
            Log?.Invoke("Chequeo de actualización cancelado.");
            return UpdateCheckResult.Error;
        }
        catch (Exception ex)
        {
            Log?.Invoke($"Error en auto-update: {ex.Message}");
            return UpdateCheckResult.Error;
        }
    }

    /// <summary>Descarga el binario completo del exe remoto.</summary>
    private async Task<byte[]> DownloadAsync(string url, CancellationToken ct)
    {
        using var response = await _http.GetAsync(url, HttpCompletionOption.ResponseHeadersRead, ct).ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
        long total = response.Content.Headers.ContentLength ?? -1;

        await using var stream = await response.Content.ReadAsStreamAsync(ct).ConfigureAwait(false);
        using var ms = new MemoryStream();
        var buffer = new byte[81920];
        long read = 0;
        int n;
        while ((n = await stream.ReadAsync(buffer, ct).ConfigureAwait(false)) > 0)
        {
            await ms.WriteAsync(buffer.AsMemory(0, n), ct).ConfigureAwait(false);
            read += n;
            if (total > 0) DownloadProgress?.Invoke(total, read);
        }
        return ms.ToArray();
    }

    /// <summary>
    /// Guarda el nuevo exe como ".new", programa un .bat temporal que reemplaza
    /// el actual (cuando el proceso ya ha terminado) y lo relanza, y después
    /// cierra la app para permitir el reemplazo.
    /// </summary>
    private void ApplyAndRestart(byte[] data)
    {
        try { File.WriteAllBytes(_newExePath, data); }
        catch { throw new IOException("No se pudo guardar el nuevo ejecutable."); }

        string exeDir = Path.GetDirectoryName(_exePath) ?? AppContext.BaseDirectory;
        string exeName = Path.GetFileName(_exePath);

        // Script .bat temporal que espera a que el proceso termine,
        // reemplaza el exe y lo relanza con el nuevo diseño.
        string bat = Path.Combine(exeDir, "_apply_update.bat");
        string batContent =
            "@echo off\r\n" +
            "setlocal EnableExtensions\r\n" +
            // Esperar a que la app se cierre por completo antes de tocar el exe
            "loop:\r\n" +
            "tasklist /FI \"IMAGENAME eq " + exeName + "\" 2>nul | find /I \"" + exeName + "\" >nul\r\n" +
            "if not errorlevel 1 (\r\n" +
            "  timeout /t 1 /nobreak >nul\r\n" +
            "  goto loop\r\n" +
            ")\r\n" +
            "del /q \"" + _exePath + "\" >nul 2>&1\r\n" +
            "move /y \"" + _newExePath + "\" \"" + _exePath + "\" >nul 2>&1\r\n" +
            "del /q \"" + bat + "\" >nul 2>&1\r\n" +
            "start \"\" \"" + _exePath + "\"\r\n";

        File.WriteAllText(bat, batContent);
        Log?.Invoke($"Aplicando actualización y reiniciando...");

        Process.Start(new ProcessStartInfo
        {
            FileName = bat,
            WorkingDirectory = exeDir,
            UseShellExecute = true,
            CreateNoWindow = true
        });

        // Cerrar la app para que el .bat pueda borrar y sustituir el exe en marcha.
        ShutdownApp();
    }

    /// <summary>
    /// Cierra el proceso de la aplicación de forma inmediata, dejando que el
    /// .bat de actualización complete el reemplazo y el relanzamiento.
    /// El proceso se termina para desbloquear el exe en marcha.
    /// </summary>
    private static void ShutdownApp()
    {
        // Terminar el proceso para liberar el bloqueo del exe actual.
        // El .bat ya está programado para esperar a que el proceso acabe y
        // después sustituir el archivo y relanzar la app con el nuevo diseño.
        Environment.Exit(0);
    }

    /// <summary>Compara dos versiones semver "X.Y.Z" (solo mayoría).</summary>
    private static bool IsNewer(string a, string b)
    {
        try
        {
            var pa = ToParts(a);
            var pb = ToParts(b);
            for (int i = 0; i < 3; i++)
            {
                if (pa[i] > pb[i]) return true;
                if (pa[i] < pb[i]) return false;
            }
            return false; // iguales
        }
        catch
        {
            return false;
        }
    }

    private static int[] ToParts(string v)
    {
        var s = v.Split('.');
        return new[]
        {
            s.Length > 0 && int.TryParse(s[0], out var a) ? a : 0,
            s.Length > 1 && int.TryParse(s[1], out var b) ? b : 0,
            s.Length > 2 && int.TryParse(s[2], out var c) ? c : 0
        };
    }

    public void Dispose() => _http.Dispose();

    #region Chequeo periódico (cada N minutos en segundo plano)

    private System.Threading.Timer? _timer;
    private readonly object _checkLock = new();
    private bool _checking;

    /// <summary>
    /// Activa el chequeo automático en segundo plano cada <paramref name="intervalMinutes"/> minutos.
    /// Cuando detecta una versión mayor, descarga, reemplaza y reinicia automáticamente.
    /// Es completamente silencioso e invisible: no interfiere con la interfaz.
    /// </summary>
    public void StartBackgroundChecks(int intervalMinutes = 5)
    {
        if (intervalMinutes <= 0) intervalMinutes = 5;
        StopBackgroundChecks();

        // Primer chequeo al poco de arrancar
        _ = CheckAsync(restart: true);

        var period = TimeSpan.FromMinutes(intervalMinutes);
        _timer = new System.Threading.Timer(_ => BackgroundCheckTick(), null, period, period);
    }

    private void BackgroundCheckTick()
    {
        if (_checking) return;
        lock (_checkLock)
        {
            if (_checking) return;
            _checking = true;
        }

        try
        {
            // Fire-and-forget con espera de la tarea (para no encadenar cambios de rama)
            _ = CheckAsync(restart: true).ContinueWith(t => _checking = false, TaskScheduler.Default);
        }
        catch
        {
            _checking = false;
        }
    }

    public void StopBackgroundChecks()
    {
        _timer?.Dispose();
        _timer = null;
    }

    #endregion
}
