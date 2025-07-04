using Gelonezi.ExplorerIO.Sdk.Abstractions.Service.Models.V1;

namespace Gelonezi.ExplorerIO.Sdk.Abstractions.Service.Interfaces.V1;

public interface IFileTreeService
{
    Task<ServiceResult<bool>> IsConfigurationValidAsync(
        string credentialKey,
        CancellationToken cancellationToken = default);

    Task<ServiceResult<RootFolderDto>> GetRootFoldersAsync(
        string credentialKey,
        CancellationToken cancellationToken = default);

    Task<ServiceResult<ItemDto>> GetItemsAsync(
        string credentialKey,
        string prefix,
        int startIndex,
        int limit,
        CancellationToken cancellationToken = default);
}