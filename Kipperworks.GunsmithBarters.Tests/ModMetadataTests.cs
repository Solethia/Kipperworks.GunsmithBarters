using FluentAssertions;
using SPTarkov.Server.Core.Models.Spt.Mod;

namespace Kipperworks.GunsmithBarters.Tests;

public class ModMetadataTests
{
    [Fact]
    public void ModMetadata_CanBeInstantiated_WithoutThrowingExceptions()
    {
        // Act
        Action act = () => _ = new ModMetadata();

        // Assert
        act.Should().NotThrow("metadata property initializers and assembly version extraction should be valid");
    }

    [Fact]
    public void ModMetadata_HasValidSemVerProperties()
    {
        // Arrange
        var metadata = new ModMetadata();

        // Assert
        metadata.ModGuid.Should().NotBeNullOrWhiteSpace();
        metadata.Name.Should().NotBeNullOrWhiteSpace();

        metadata.Version.Should().NotBeNull();
        metadata.Version.Major.Should().BeGreaterThanOrEqualTo(0);

        metadata.SptVersion.Should().NotBeNull();
    }

    [Fact]
    public void ModAssembly_ContainsDiscoverableMetadataType_ForSptLoader()
    {
        // Arrange: Get the assembly where ModMetadata lives
        var modAssembly = typeof(ModMetadata).Assembly;

        // Act: Mirror exact SPT Reflection Discovery
        var metadataType = modAssembly.GetTypes()
            .FirstOrDefault(t => typeof(AbstractModMetadata).IsAssignableFrom(t) && !t.IsAbstract);

        // Assert
        metadataType.Should().NotBeNull("SPT requires a non-abstract class inheriting from AbstractModMetadata");

        // Act: Mirror exact SPT Instantiation via Activator
        var instance = Activator.CreateInstance(metadataType!) as AbstractModMetadata;

        // Assert
        instance.Should().NotBeNull();
        instance!.Version.Should().NotBeNull();
    }
}
