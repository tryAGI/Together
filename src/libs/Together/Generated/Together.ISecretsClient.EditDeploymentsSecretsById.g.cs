#nullable enable

namespace Together
{
    public partial interface ISecretsClient
    {
        /// <summary>
        /// Update a secret<br/>
        /// Update an existing secret's value or metadata
        /// </summary>
        /// <param name="id">
        /// Secret ID or name
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.SecretResponseItem> EditDeploymentsSecretsByIdAsync(
            string id,

            global::Together.UpdateSecretRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a secret<br/>
        /// Update an existing secret's value or metadata
        /// </summary>
        /// <param name="id">
        /// Secret ID or name
        /// </param>
        /// <param name="description">
        /// Description is an optional human-readable description of the secret's purpose (max 500 characters)
        /// </param>
        /// <param name="name">
        /// Name is the new unique identifier for the secret. Can contain alphanumeric characters, underscores, hyphens, forward slashes, and periods (1-100 characters)
        /// </param>
        /// <param name="projectId">
        /// ProjectID is ignored - the project is automatically determined from your authentication
        /// </param>
        /// <param name="value">
        /// Value is the new sensitive data to store securely. Updating this will replace the existing secret value
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.SecretResponseItem> EditDeploymentsSecretsByIdAsync(
            string id,
            string? description = default,
            string? name = default,
            string? projectId = default,
            string? value = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}