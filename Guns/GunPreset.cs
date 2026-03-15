using SPTarkov.Server.Core.Models.Eft.Common.Tables;
using System.Text.Json.Serialization;

namespace Kipperworks.GunsmithBarters;

public record GunPreset
{
    [JsonPropertyName("items")]
    public List<Item> Items { get; set; } = [];
}
