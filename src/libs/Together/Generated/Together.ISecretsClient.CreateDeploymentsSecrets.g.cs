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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// client.beta.jig.secrets.create(name="my-secret", value="my-value")
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.SecretResponseItem> CreateDeploymentsSecretsAsync(

            global::Together.CreateSecretRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new secret<br/>
        /// Create a new secret to store sensitive configuration values
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// client.beta.jig.secrets.create(name="my-secret", value="my-value")
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.SecretResponseItem>> CreateDeploymentsSecretsAsResponseAsync(

            global::Together.CreateSecretRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
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
        /// <param name="ttlSeconds">
        /// TTLSeconds is how long the secret lives before it is deleted, between 86400 (1 day) and 1209600 (14 days)
        /// </param>
        /// <param name="value">
        /// Value is the sensitive data to store securely (e.g., API keys, passwords, tokens). Encrypted at rest.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.SecretResponseItem> CreateDeploymentsSecretsAsync(
            string name,
            string value,
            string? description = default,
            string? projectId = default,
            int? ttlSeconds = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}