#nullable enable

namespace Together
{
    public partial interface ISecretsClient
    {
        /// <summary>
        /// Delete a secret<br/>
        /// Delete an existing secret
        /// </summary>
        /// <param name="id">
        /// Secret ID or name
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// client.beta.jig.secrets.delete("my-secret")
        /// </remarks>
        global::System.Threading.Tasks.Task<string> DeleteDeploymentsSecretsByIdAsync(
            string id,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}