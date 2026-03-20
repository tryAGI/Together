#nullable enable

namespace Together
{
    public partial interface IDeploymentsClient
    {

        /// <summary>
        /// Delete a deployment<br/>
        /// Delete an existing deployment
        /// </summary>
        /// <param name="id">
        /// Deployment ID or name
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>

        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// deployment = client.beta.jig.destroy("my-deployment")<br/>
        /// print(deployment)
        /// </remarks>
        global::System.Threading.Tasks.Task<string> DeleteDeploymentsByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}