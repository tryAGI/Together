#nullable enable

namespace Together
{
    public partial interface ISecretsClient
    {

        /// <summary>
        /// Get a secret by ID or name<br/>
        /// Retrieve details of a specific secret by its ID or name
        /// </summary>
        /// <param name="id">
        /// Secret ID or name
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>

        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// secret = client.beta.jig.secrets.retrieve("my-secret")<br/>
        /// print(secret)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.SecretResponseItem> GetDeploymentsSecretsByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}