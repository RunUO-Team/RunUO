# RunUO Server

[![License: GPL v2](https://img.shields.io/badge/License-GPL%20v2-blue.svg)](https://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html)
[![Build Status](https://github.com/RunUO-Team/RunUO/workflows/Build/badge.svg)](https://github.com/RunUO-Team/RunUO/actions)

## Overview

RunUO is a free, open-source Ultima Online server emulator written in C#. Originally founded by Ryan McAdams in 2002, RunUO has been the foundation for countless Ultima Online shards and has contributed significantly to the UO emulation community.

This repository contains the official RunUO server codebase, maintained by the original RunUO development team.

## Features

- **Full UO Protocol Support**: Complete implementation of the Ultima Online network protocol
- **Dynamic Script System**: Hot-swappable C# scripts for game content without server restarts
- **Multi-Era Support**: Compatible with multiple UO client versions
- **Advanced Persistence**: Robust world saving system with multiple save strategies
- **Extensible Architecture**: Modular design allowing easy customization and expansion
- **Cross-Platform**: Runs on Windows, Linux, and macOS with Mono/.NET

## Quick Start

### Prerequisites

- .NET Framework 4.8 or .NET 5.0+
- Visual Studio 2019+ (recommended) or any C# IDE
- Ultima Online client files

### Building

1. Clone the repository:
   ```bash
   git clone https://github.com/RunUO-Team/RunUO.git
   cd RunUO
   ```

2. Open `RunUO.sln` in Visual Studio or build from command line:
   ```bash
   dotnet build
   ```

3. Run the server:
   ```bash
   dotnet run --project Server
   ```

### Configuration

1. Configure your UO client path in the server settings
2. Modify configuration files in the `Data/` directory as needed
3. Add custom scripts to the `Scripts/` directory

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
