using Gelonezi.ExplorerIO.Sdk.Abstractions.Service.Models.V1;

namespace Gelonezi.ExplorerIO.Sdk.Abstractions.Service.Interfaces.V1;

public interface IFileUrlService
{
    Task<ServiceResult<string>> GetFileUrlAsync(
        string credentialKey,
        string itemKey,
        CancellationToken cancellationToken = default);
}