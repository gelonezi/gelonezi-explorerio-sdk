using Gelonezi.ExplorerIO.Sdk.Abstractions.Credentials.Models.V1;

namespace Gelonezi.ExplorerIO.Sdk.Abstractions.Credentials.Interfaces.V1;

public interface ICredentialsStore
{
    CredentialOptions GetCredential(
        string credentialKey,
        CancellationToken cancellationToken = default);

    void PutCredential(
        CredentialOptions options,
        CancellationToken cancellationToken = default);
}