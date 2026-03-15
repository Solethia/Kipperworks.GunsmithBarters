using SPTarkov.Server.Core.Models.Spt.Mod;

namespace Kipperworks.GunsmithBarters;

public record ModMetadata : AbstractModMetadata
{
    public override string ModGuid { get; init; } = "com.kipperworks.gunsmithbarters";
    public override string Name { get; init; } = "Kipperworks.GunsmithBarters";
    public override string Author { get; init; } = "Solethia";
    public override List<string>? Contributors { get; init; }
    public override SemanticVersioning.Version Version { get; init; } = new("2.0.0");
    public override SemanticVersioning.Range SptVersion { get; init; } = new("~4.0.0");
    public override List<string>? Incompatibilities { get; init; }
    public override Dictionary<string, SemanticVersioning.Range>? ModDependencies { get; init; }
    public override string? Url { get; init; } = "https://github.com/Solethia/Kipperworks.GunsmithBarters";
    public override bool? IsBundleMod { get; init; } = false;
    public override string License { get; init; } = "MIT";
}
