# Dotnet45 Desktop App

A deliberately small **.NET Framework 4.5** WinForms desktop application, meant
to simulate a real desktop app that gets built (and smoke-tested) inside a
CI/CD pipeline.

## What it does

- Opens a single window showing a greeting with the app name, version and build date.
- A **Say Hello** button pops up the same greeting in a message box.
- Supports a headless `--selftest` mode so it can be exercised in a pipeline
  with no interactive desktop.

## Project layout

```
Dotnet45DesktopApp.sln          Visual Studio solution
Dotnet45DesktopApp/
  Dotnet45DesktopApp.csproj     Project (TargetFrameworkVersion v4.5, WinExe)
  App.config                    Targets the .NET 4.5 runtime
  Program.cs                    Entry point (UI mode + --selftest mode)
  AppInfo.cs                    UI-independent shared logic
  MainForm.cs                   The window
  MainForm.Designer.cs          Designer-generated layout
  MainForm.resx                 Form resources
  Properties/AssemblyInfo.cs    Assembly metadata
.github/workflows/build.yml     CI: build on windows-latest + run self-test
```

## Build locally (Windows)

Requires Visual Studio with the .NET Framework 4.5 targeting pack, or the
Build Tools for Visual Studio.

```powershell
nuget restore Dotnet45DesktopApp.sln
msbuild Dotnet45DesktopApp.sln /p:Configuration=Release
```

The executable is produced at `Dotnet45DesktopApp\bin\Release\Dotnet45DesktopApp.exe`.

## Run

```powershell
# Normal UI
Dotnet45DesktopApp.exe

# Headless smoke test used by the pipeline (exits 0 on success)
Dotnet45DesktopApp.exe --selftest
```

## CI pipeline

`.github/workflows/build.yml` runs on a `windows-latest` runner: it restores
NuGet packages, builds the solution in Release, runs the headless self-test,
and uploads the build output as an artifact.
