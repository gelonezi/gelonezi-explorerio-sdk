using System.Diagnostics.CodeAnalysis;

namespace Gelonezi.ExplorerIO.Sdk.Abstractions.Service.Models.V1;

[ExcludeFromCodeCoverage]
public class FileDto
{
    public string FileKey { get; set; } = string.Empty;
    public string FileName { get; set; } = string.Empty;
    public required FileStream StreamContent { get; set; }
    public IDictionary<string, string> Metadata { get; set; } = new Dictionary<string, string>();
}