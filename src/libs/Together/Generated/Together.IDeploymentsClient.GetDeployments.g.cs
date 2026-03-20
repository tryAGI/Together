#nullable enable

namespace Together
{
    public partial interface IDeploymentsClient
    {
        /// <summary>
        /// Get the list of deployments<br/>
        /// Get a list of all deployments in your project
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeploymentListResponse> GetDeploymentsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}