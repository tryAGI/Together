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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteDeploymentsSecretsByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}