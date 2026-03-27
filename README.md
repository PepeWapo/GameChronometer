# GameChronometer 🎮⏱️

A lightweight transparent overlay chronometer for tracking your gaming sessions. Built with WPF and .NET 9 — stays on top of your game without getting in the way.

## Features

- Transparent overlay window — see through it while gaming
- Always on top — never hidden behind your game
- Play / Pause / Reset controls
- Draggable — move it anywhere on your screen
- Minimal resource usage compared to Electron-based alternatives

## Built With

- C# / .NET 9
- WPF (Windows Presentation Foundation)
- XAML

## Requirements

- Windows 10 or later (64-bit)
- No .NET installation required — self contained executable

## Installation

1. Download the latest release from the [Releases](../../releases) page
2. Run `GameChronometer.exe`
3. That's it — no installation needed!

## Building From Source

Clone the repository:

```bash
git clone https://github.com/YOURUSERNAME/GameChronometer.git
cd GameChronometer
```

Build and run:

```bash
dotnet run
```

Publish as a single executable:

```bash
dotnet publish -c Release -r win-x64 --self-contained true /p:PublishSingleFile=true
```

The executable will be located at:

```
bin/Release/net9.0-windows/win-x64/publish/GameChronometer.exe
```

## Usage

- **Play** — starts the timer
- **Pause** — pauses the timer
- **Reset** — resets the timer back to 00:00:00
- **Drag** — click and drag the overlay anywhere on your screen

## Roadmap

- [ ] Keyboard hotkeys for play/pause without clicking
- [ ] Color change alert when time limit is reached
- [ ] Save session time to a log file
- [ ] Lock/unlock position button
- [ ] Customizable transparency and size

## License

This project is licensed under the MIT License — see the [LICENSE](LICENSE) file for details.

## Author

Built as a personal learning project while studying C# and .NET development.
