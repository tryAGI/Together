#nullable enable

namespace Together
{
    public partial interface ISecretsClient
    {
        /// <summary>
        /// Get the list of project secrets<br/>
        /// Retrieve all secrets in your project
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// secrets = client.beta.jig.secrets.list()<br/>
        /// print(secrets)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.ListSecretsResponse> GetDeploymentsSecretsAsync(
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}