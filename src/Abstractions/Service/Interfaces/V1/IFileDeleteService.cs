using Gelonezi.ExplorerIO.Sdk.Abstractions.Service.Models.V1;

namespace Gelonezi.ExplorerIO.Sdk.Abstractions.Service.Interfaces.V1;

public interface IFileDeleteService
{
    Task<ServiceResult<bool>> DeleteFileAsync(
        string credentialKey,
        string itemKey,
        CancellationToken cancellationToken = default);
}