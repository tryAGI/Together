#nullable enable

namespace Together
{
    public partial interface IDeploymentServiceClient
    {
        /// <summary>
        /// Get a deployment adapter<br/>
        /// Gets an attached adapter and its per-cluster load state.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="endpointId">
        /// Endpoint identifier.
        /// </param>
        /// <param name="deploymentId">
        /// Deployment identifier.
        /// </param>
        /// <param name="id">
        /// Adapter model identifier.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// project_id = client.whoami().project_id<br/>
        /// adapter = client.beta.endpoints.adapters.retrieve(<br/>
        ///     "dad_abc123",<br/>
        ///     project_id=project_id,<br/>
        ///     endpoint_id="ep_abc123",<br/>
        ///     deployment_id="dep_abc123",<br/>
        /// )<br/>
        /// print(adapter)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.DeAdapterEntry> DeploymentServiceGetAdapterAsync(
            string projectId,
            string endpointId,
            string deploymentId,
            string id,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a deployment adapter<br/>
        /// Gets an attached adapter and its per-cluster load state.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="endpointId">
        /// Endpoint identifier.
        /// </param>
        /// <param name="deploymentId">
        /// Deployment identifier.
        /// </param>
        /// <param name="id">
        /// Adapter model identifier.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// project_id = client.whoami().project_id<br/>
        /// adapter = client.beta.endpoints.adapters.retrieve(<br/>
        ///     "dad_abc123",<br/>
        ///     project_id=project_id,<br/>
        ///     endpoint_id="ep_abc123",<br/>
        ///     deployment_id="dep_abc123",<br/>
        /// )<br/>
        /// print(adapter)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeAdapterEntry>> DeploymentServiceGetAdapterAsResponseAsync(
            string projectId,
            string endpointId,
            string deploymentId,
            string id,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}