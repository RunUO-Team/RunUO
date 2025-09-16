# RunUO Server

[![License: GPL v2](https://img.shields.io/badge/License-GPL%20v2-blue.svg)](https://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html)
[![Build Status](https://github.com/RunUO-Team/RunUO/workflows/Build/badge.svg)](https://github.com/RunUO-Team/RunUO/actions)

## Overview

RunUO is a free, open-source Ultima Online server emulator written in C#. Originally founded by Ryan McAdams in 2002, RunUO has been the foundation for countless Ultima Online shards and has contributed significantly to the UO emulation community.

This repository contains the official RunUO server codebase, maintained by the original RunUO development team.

## What's New in v3.0

RunUO v3.0 represents a major modernization of the codebase:

- **🎯 .NET 8 Support**: Migrated from .NET Framework to modern .NET 8 for better performance and cross-platform compatibility
- **🌍 True Cross-Platform**: Runs natively on Windows, Linux, and macOS without Mono
- **🧹 Modernized APIs**: Updated all deprecated APIs (MD5, SHA1, TimeZone, WebRequest) to modern equivalents
- **📁 Simplified Data Path**: Automatic UO data file discovery with cross-platform fallbacks
- **🗑️ Removed Bloat**: Eliminated the Reports engine system for a cleaner, more focused codebase
- **✨ Improved Build Quality**: Significantly reduced compiler warnings and modernized codebase
- **🔧 Improved Tooling**: Full compatibility with modern IDEs and development tools

## Features

- **Full UO Protocol Support**: Complete implementation of the Ultima Online network protocol
- **Dynamic Script System**: Hot-swappable C# scripts for game content without server restarts
- **Multi-Era Support**: Compatible with multiple UO client versions
- **Advanced Persistence**: Robust world saving system with multiple save strategies
- **Extensible Architecture**: Modular design allowing easy customization and expansion
- **Cross-Platform**: Runs natively on Windows, Linux, and macOS with .NET 8
- **Modern Platform**: Built on .NET 8 for improved performance and cross-platform support

## Quick Start

### Prerequisites

- .NET 8.0 SDK or later
- Visual Studio 2022+ (recommended) or any IDE that supports .NET 8
- Ultima Online client files (place in UOData folder in server root)

### Building

1. Clone the repository:
   ```bash
   git clone https://github.com/RunUO-Team/RunUO.git
   cd RunUO
   ```

2. Build using Visual Studio:
   - Open `RunUO.sln` in Visual Studio 2022+
   - Build Solution (Ctrl+Shift+B)
   - Output will be in `Distribution/Debug/net8.0/` or `Distribution/Release/net8.0/`

3. Or build from command line:
   ```bash
   dotnet build Server/Server.csproj --configuration Release
   ```

4. Run the server:
   ```bash
   # Navigate to the build output directory
   cd Distribution/Release/net8.0

   # Windows
   RunUO.exe

   # Linux/macOS
   ./RunUO
   ```

### UO Data Setup

Place your Ultima Online client files in a `UOData` folder in the server root directory:

```
RunUO/
├── UOData/                # UO client files go here
│   ├── Map0.mul
│   ├── Statics0.mul
│   ├── TileData.mul
│   └── ... (other UO files)
├── Server/
├── Scripts/
└── Distribution/
```

### Directory Structure

After building, the `Distribution/` folder contains everything needed to run the server:

```
Distribution/
├── Debug/ (or Release/)
│   └── net8.0/            # .NET 8 target output
│       ├── RunUO.exe      # Server executable (Windows)
│       ├── RunUO          # Server executable (Linux/macOS)
│       ├── RunUO.dll      # Server library
│       ├── RunUO.pdb      # Debug symbols
│       ├── Data/          # Configuration files
│       ├── Scripts/       # Game content scripts
│       ├── Saves/         # World save files (created at runtime)
│       ├── Logs/          # Server log files (created at runtime)
│       ├── zlib32.dll     # Compression library (32-bit)
│       └── zlib64.dll     # Compression library (64-bit)
```

### Configuration

1. **UO Data Files**: Place your UO client files in the `UOData/` folder (see UO Data Setup above)
2. **Server Settings**: Modify configuration files in the `Data/` directory as needed
3. **Custom Scripts**: Add custom scripts to the `Scripts/` directory
4. **Automatic Compilation**: The server will automatically compile scripts at startup
5. **Cross-Platform**: The server automatically detects the platform and adjusts accordingly

## Documentation

- [Installation Guide](https://runuo.com/docs/installation)
- [Scripting Documentation](https://runuo.com/docs/scripting)
- [API Reference](https://runuo.com/docs/api)
- [Community Forums](https://runuo.com/community)

## Contributing

We welcome contributions from the community! Please read our [Contributing Guidelines](CONTRIBUTING.md) before submitting pull requests.

### Development Guidelines

- Follow existing code style and conventions
- Add appropriate documentation for new features
- Include tests for new functionality
- Ensure compatibility with existing scripts

## Community & Support

- **Official Website**: [runuo.com](https://runuo.com)
- **Community Forums**: [runuo.com/community](https://runuo.com/community)
- **Discord**: [Join our Discord](https://discord.gg/runuo)
- **Issue Tracker**: [GitHub Issues](https://github.com/RunUO-Team/RunUO/issues)

## License

RunUO is licensed under the GNU General Public License v2.0. See the [LICENSE](LICENSE) file for details.

## History

RunUO was created in 2002 by Ryan McAdams and Zac Torkelson (Krrios) and has been continuously developed by a dedicated team of contributors. It has served as the foundation for thousands of Ultima Online servers worldwide and continues to be actively maintained.

## Acknowledgments

Special thanks to all the contributors who have helped make RunUO what it is today, and to the Ultima Online community for their continued support and feedback.
