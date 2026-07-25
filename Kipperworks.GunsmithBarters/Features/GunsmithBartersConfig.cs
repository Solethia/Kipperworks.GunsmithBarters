using System.Text.Json.Serialization;

namespace Kipperworks.GunsmithBarters;

public record GunsmithBartersConfig
{
    [JsonPropertyName("addAttachmentBarters")]
    public bool AddAttachmentBarters { get; set; }
    [JsonPropertyName("addGunBarters")]
    public bool AddGunBarters { get; set; }
    [JsonPropertyName("debug")]
    public bool Debug { get; set; }

    public IReadOnlyCollection<GunsmithBarterAddType> BarterAddTypes => new List<GunsmithBarterAddType>
    {
        new("GunBarters", AddGunBarters),
        new("AttachmentBarters", AddAttachmentBarters)
    };
}
public record GunsmithBarterAddType(string Name, bool Enabled);
