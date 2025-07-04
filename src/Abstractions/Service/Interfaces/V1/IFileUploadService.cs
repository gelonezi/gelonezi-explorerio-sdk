using Gelonezi.ExplorerIO.Sdk.Abstractions.Service.Models.V1;

namespace Gelonezi.ExplorerIO.Sdk.Abstractions.Service.Interfaces.V1;

public interface IFileUploadService
{
    Task<ServiceResult<ItemDto>> UploadFileAsync(
        string credentialKey,
        FileDto file,
        CancellationToken cancellationToken = default);
}