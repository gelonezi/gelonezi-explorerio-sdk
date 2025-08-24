using System.Diagnostics.CodeAnalysis;
using Gelonezi.ExplorerIO.Sdk.Abstractions.Service.Models.V1.Enums;

namespace Gelonezi.ExplorerIO.Sdk.Abstractions.Service.Models.V1;

[ExcludeFromCodeCoverage]
public class RootFolderDto
{
    public ServiceType ServiceType { get; set; }
    public string FolderName { get; set; } = string.Empty;
}