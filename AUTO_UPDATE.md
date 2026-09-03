# TikControl Caosbloxer — Auto-Update & CI/CD

Sistema 100% automático para compilar y distribuir el `.exe` del clon de TikControl
sin crear Releases manuales en la web de GitHub.

> **Stack real**: .NET 10 WPF + WebView2 (NO Electron/Tauri). Por eso el
> auto-update vive en C# (host) y no en JavaScript, como se explica abajo.

---

## Cómo funciona

1. **Haces `git push` a `main`** (cualquier cambio en el código o la interfaz).
2. **GitHub Actions** (`.github/workflows/auto-compiler.yml`) se dispara solo.
3. Incrementa la versión (`1.0.1` → `1.0.2`), escribe el número en `VERSION.txt`
   y en `TikControl.App.csproj`, y lo commitea de vuelta a `main` (con `[skip ci]`
   para no re-disparar el workflow).
4. Compila el `.exe` portable (single-file) y genera `update.json` (versión +
   URL de descarga + hash SHA-256).
5. Empuja `TikControlCaosbloxer.exe`, `update.json`, `web/` y `VERSION.txt` a la
   rama **`gh-pages`**.
6. En cada máquina del usuario, la app (al abrir, y cada 5 minutos en segundo
   plano) consulta `update.json`. Si hay versión mayor, descarga el nuevo `.exe`,
   lo reemplaza y se reinicia sola con el nuevo diseño.

---

## Archivos clave

| Archivo | Rol |
|---|---|
| `.github/workflows/auto-compiler.yml` | Workflow completo de CI/CD |
| `VERSION.txt` | Número de versión actual (1.0.0) |
| `update.json` | Metadatos de actualización (referencia; lo genera el CI) |
| `src/TikControl.Core/Update/UpdaterService.cs` | Lógica de auto-update en C# |
| `src/TikControl.App/App.xaml.cs` | Arranca el chequeo (al abrir + cada 5 min) |

---

## ÚNICO paso manual: configurar tu URL

En `src/TikControl.App/App.xaml.cs` cambia esta línea por tu repo real:

```csharp
string url = System.Environment.GetEnvironmentVariable("TIKCONTROL_UPDATE_URL")
             ?? "https://raw.githubusercontent.com/sigato/TikControlCaosbloxer/gh-pages/update.json";
```

Reemplaza `sigato/TikControlCaosbloxer` por `TU_USUARIO/TU_REPO`.

También puedes **sobreescribirla en tiempo de ejecución** sin recompilar, con la
variable de entorno `TIKCONTROL_UPDATE_URL`.

## Publicar la rama `gh-pages` por primera vez

Tras el primer push a `main`, el workflow crea `gh-pages` automáticamente. Para que
GitHub sirva la rama como web estática (descarga directa), activa en el repo:

**Settings → Pages → Source → "Deploy from a branch" → `gh-pages` / root**.

La URL de descarga que usa el auto-update es la **raw**:
```
https://raw.githubusercontent.com/TU_USUARIO/TU_REPO/gh-pages/TikControlCaosbloxer.exe
```
(las raw de GitHub no requieren activar Pages, funcionan siempre).

---

## Notas técnicas

- **Invisible para el usuario**: el chequeo es asíncrono y silencioso; no bloquea
  la interfaz morada/fucsia ni muestra ventanas.
- **Robusto ante fallos**: si no hay red, el `update.json` no existe o algo falla,
  el auto-update se cancela silenciosamente y la app sigue funcionando normal.
- **Reemplazo seguro en Windows**: no se puede sobreescribir un `.exe` en marcha,
  así que se guarda como `.new`, se lanza un pequeño `.bat` que espera, borra el
  viejo, lo mueve y relanza la app con el nuevo diseño.
- **El `web/` no se borra al actualizar**: solo se reemplaza el `.exe`, por lo que
  la interfaz existente de la instalación se conserva (y además se copia nueva a
  `gh-pages` por si alguien descarga el exe por primera vez).
