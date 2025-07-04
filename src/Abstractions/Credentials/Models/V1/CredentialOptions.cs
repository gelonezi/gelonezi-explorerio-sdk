namespace Gelonezi.ExplorerIO.Sdk.Abstractions.Credentials.Models.V1;

public class CredentialOptions
{
    public string CredentialKey { get; set; } = string.Empty;
    public string AccessKey { get; set; } = string.Empty;
    public string SecretKey { get; set; } = string.Empty;
    public string? Endpoint { get; set; }
    public string? Region { get; set; }
}