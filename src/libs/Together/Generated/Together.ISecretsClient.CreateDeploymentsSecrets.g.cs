#nullable enable

namespace Together
{
    public partial interface ISecretsClient
    {

        /// <summary>
        /// Create a new secret<br/>
        /// Create a new secret to store sensitive configuration values
        /// </summary>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>

        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// client.beta.jig.secrets.create(name="my-secret", value="my-value")
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.SecretResponseItem> CreateDeploymentsSecretsAsync(

            global::Together.CreateSecretRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a new secret<br/>
        /// Create a new secret to store sensitive configuration values
        /// </summary>
        /// <param name="description">
        /// Description is an optional human-readable description of the secret's purpose (max 500 characters)
        /// </param>
        /// <param name="name">
        /// Name is the unique identifier for the secret. Can contain alphanumeric characters, underscores, hyphens, forward slashes, and periods (1-100 characters)
        /// </param>
        /// <param name="projectId">
        /// ProjectID is ignored - the project is automatically determined from your authentication
        /// </param>
        /// <param name="value">
        /// Value is the sensitive data to store securely (e.g., API keys, passwords, tokens). This value will be encrypted at rest
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.SecretResponseItem> CreateDeploymentsSecretsAsync(
            string name,
            string value,
            string? description = default,
            string? projectId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}