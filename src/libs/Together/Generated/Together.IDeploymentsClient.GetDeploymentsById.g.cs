#nullable enable

namespace Together
{
    public partial interface IDeploymentsClient
    {

        /// <summary>
        /// Get a deployment by ID or name<br/>
        /// Retrieve details of a specific deployment by its ID or name
        /// </summary>
        /// <param name="id">
        /// Deployment ID or name
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>

        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// deployment = client.beta.jig.retrieve("my-deployment")<br/>
        /// print(deployment)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.DeploymentResponseItem> GetDeploymentsByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}