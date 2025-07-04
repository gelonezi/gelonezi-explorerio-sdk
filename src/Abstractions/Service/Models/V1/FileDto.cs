namespace Gelonezi.ExplorerIO.Sdk.Abstractions.Service.Models.V1;

public class FileDto
{
    public string FileKey { get; set; } = string.Empty;
    public string FileName { get; set; } = string.Empty;
    public required FileStream StreamContent { get; set; }
    public IDictionary<string, string> Properties { get; set; } = new Dictionary<string, string>();
}