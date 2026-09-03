# TikControl Caosbloxer

Clon de **TikControl**: app de escritorio Windows para creadores de TikTok Live.
Muestra notificaciones de regalos, seguidores y comentarios en vivo, con overlay
en pantalla, sonido de alertas y controles rápidos.

## Estado actual

Base funcional que:
- Abre una ventana (WPF + WebView2).
- Carga la interfaz (`src\TikControl.Web\panel`).
- Escucha eventos del LIVE vía `TikControl.Core`.
- **Modo DEMO**: emite eventos simulados para probar la interfaz y el overlay
  sin conectarse a TikTok.
- **Conexión LIVE real**: conector integrado con TikTokLiveSharp (v1.2.2,
  compilado desde el repo fuente en `libs\TikTokLiveSharp`). Traduce comentarios,
  regalos, seguidores, likes y espectadores a eventos normalizados.
- Muestra estadísticas (diamantes / seguidores / comentarios), feed de últimos
  eventos, toggle de overlay y de sonido.

> **Nota**: todas las librerías de conexión TikTok son no oficiales y dependen
> de un servicio de firma externo (signing server). La conexión real puede no ser
> 100% confiable y, en algunos casos, requerir configurar un signing server propio
> en `ClientSettings.CustomSigningServerUrl`.

## Requisitos

- Windows 10 / 11 (64 bits)
- [.NET 10 SDK](https://dotnet.microsoft.com/download) para compilar
  (o solo runtime para ejecutar)
- WebView2 Runtime (viene en Windows 11)

## Compilar y ejecutar

```
build.cmd
```

Luego ejecuta:

```
src\TikControl.App\bin\Release\net10.0-windows\TikControlCaosbloxer.exe
```

O directamente con dotnet:

```
dotnet run --project src\TikControl.App
```

## Estructura

```
TikControlCaosbloxer\
├── TikControlCaosbloxer.slnx
├── build.cmd
├── libs\TikTokLiveSharp\        # Fuente de TikTokLiveSharp v1.2.2 (referencia de proyecto)
├── src\
│   ├── TikControl.Core\        # Lógica: modelos + servicio de eventos TikTok
│   ├── TikControl.App\         # App WPF + WebView2 (ventana principal)
│   └── TikControl.Web\         # Interfaz web (HTML/CSS/JS) que se muestra
└── README.md
```

## Siguientes pasos

- [x] Conectar TikTok Live real: conector integrado con TikTokLiveSharp v1.2.2.
- [ ] Probar la conexión real contra un directo activo y, si hace falta, configurar
      `CustomSigningServerUrl` / `SigningKey` en `ClientSettings`.
- [ ] Configuración del canal y credenciales.
- [ ] Más tipos de overlay configurables (estilos, posiciones).
- [ ] Sonidos/alertas personalizados por tipo de evento.
- [ ] Atajos de teclado.
- [ ] Empaquetado single-file + instalador.
