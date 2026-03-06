#nullable enable

namespace Together
{
    public partial interface ISecretsClient
    {
        /// <summary>
        /// Get the list of project secrets<br/>
        /// Retrieve all secrets in your project
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.ListSecretsResponse> GetDeploymentsSecretsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}