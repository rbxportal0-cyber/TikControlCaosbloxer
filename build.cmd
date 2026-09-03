@echo off
REM =====================================================================
REM  TikControl Caosbloxer - build base
REM  Compila y deja el ejecutable en:
REM    src\TikControl.App\bin\Release\net10.0-windows\TikControlCaosbloxer.exe
REM =====================================================================
setlocal
set ROOT=%~dp0
if "%ROOT:~-1%"=="\" set ROOT=%ROOT:~0,-1%

echo.
echo [1/1] Compilando TikControl Caosbloxer (Release)...
dotnet build "%ROOT%\TikControlCaosbloxer.slnx" -c Release
if errorlevel 1 (
  echo.
  echo *** BUILD FALLO ***
  exit /b 1
)

echo.
echo =====================================================================
echo   BUILD COMPLETADO
echo =====================================================================
echo   Ejecutable: %ROOT%\src\TikControl.App\bin\Release\net10.0-windows\TikControlCaosbloxer.exe
echo =====================================================================
exit /b 0
