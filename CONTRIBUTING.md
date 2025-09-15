# Contributing to RunUO

Thank you for your interest in contributing to RunUO! We welcome contributions from the community to help make RunUO better.

## Getting Started

1. Fork the repository on GitHub
2. Clone your fork locally
3. Create a feature branch from `master`
4. Make your changes
5. Test your changes thoroughly
6. Submit a pull request

## Development Setup

### Prerequisites
- Visual Studio 2019 or later (recommended) or any C# IDE
- .NET Framework 4.8 or .NET 6.0+
- Git

### Building
1. Open `RunUO.sln` in Visual Studio
2. Build the solution (Ctrl+Shift+B)
3. The output will be in `Distribution/Debug/` or `Distribution/Release/`

## Code Style Guidelines

- Follow existing code formatting and naming conventions
- Use meaningful variable and method names
- Add XML documentation comments for public APIs
- Keep methods focused and reasonably sized
- Use proper error handling and logging

### Naming Conventions
- Use PascalCase for classes, methods, properties, and public fields
- Use camelCase for local variables and private fields
- Use meaningful names that describe the purpose
- Prefix private fields with `m_` (existing convention)

### Code Organization
- Place new items in `Scripts/Items/[Category]/`
- Place new mobiles in `Scripts/Mobiles/[Type]/`
- Place new systems in `Scripts/Engines/[SystemName]/`
- Place new commands in `Scripts/Commands/`

## Script Development

### Creating New Items
```csharp
namespace Server.Items
{
    public class MyItem : Item
    {
        [Constructable]
        public MyItem() : base(0x1234) // Item ID
        {
            Name = "My Item";
            Weight = 1.0;
        }

        public MyItem(Serial serial) : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}
```

### Creating New Mobiles
```csharp
namespace Server.Mobiles
{
    [CorpseName("a creature corpse")]
    public class MyCreature : BaseCreature
    {
        [Constructable]
        public MyCreature() : base(AIType.AI_Animal, FightMode.Aggressor, 10, 1, 0.2, 0.4)
        {
            Name = "My Creature";
            Body = 0x1234; // Body ID
            Hue = 0x0;
        }

        public MyCreature(Serial serial) : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}
```

## Pull Request Guidelines

1. **Create focused PRs**: Each PR should address a single feature or bug fix
2. **Test thoroughly**: Ensure your changes work as expected and don't break existing functionality
3. **Update documentation**: If your changes affect public APIs or user-facing features
4. **Follow the template**: Use the provided pull request template
5. **Be responsive**: Address feedback and requested changes promptly

## Reporting Issues

When reporting issues:
1. Use the appropriate issue template
2. Provide detailed reproduction steps
3. Include server logs when applicable
4. Specify your environment details

## Community Guidelines

- Be respectful and constructive in discussions
- Help other contributors when possible
- Follow the code of conduct
- Keep discussions focused and on-topic

## License

By contributing to RunUO, you agree that your contributions will be licensed under the GNU General Public License v2.0.

## Questions?

If you have questions about contributing, feel free to:
- Open an issue for discussion
- Join our Discord community
- Visit the RunUO forums

Thank you for contributing to RunUO!