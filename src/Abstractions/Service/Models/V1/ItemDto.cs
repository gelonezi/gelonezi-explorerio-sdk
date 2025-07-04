using Gelonezi.ExplorerIO.Sdk.Abstractions.Service.Models.V1.Enums;

namespace Gelonezi.ExplorerIO.Sdk.Abstractions.Service.Models.V1;

public class ItemDto
{
    public string ItemKey { get; set; } = string.Empty;
    public string ItemName { get; set; } = string.Empty;
    public ItemType ItemType { get; set; }
    public IDictionary<string, string> Properties { get; set; } = new Dictionary<string, string>();
}