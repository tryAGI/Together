#nullable enable

namespace Together
{
    public partial interface IDeploymentServiceClient
    {
        /// <summary>
        /// Remove a deployment adapter<br/>
        /// Detaches an adapter attachment by its `dad_` id using its row-level etag for optimistic concurrency.
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
        /// Adapter attachment `dad_` id from a prior add, update, get, or list response.
        /// </param>
        /// <param name="etag">
        /// Adapter etag from a previous add, update, get, or list response. The removal is rejected if the adapter changed after that response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// project_id = client.whoami().project_id<br/>
        /// # Read the attachment first: removing it requires its current etag.<br/>
        /// adapter = client.beta.endpoints.adapters.retrieve(<br/>
        ///     "dad_abc123",<br/>
        ///     project_id=project_id,<br/>
        ///     endpoint_id="ep_abc123",<br/>
        ///     deployment_id="dep_abc123",<br/>
        /// )<br/>
        /// client.beta.endpoints.adapters.delete(<br/>
        ///     "dad_abc123",<br/>
        ///     project_id=project_id,<br/>
        ///     endpoint_id="ep_abc123",<br/>
        ///     deployment_id="dep_abc123",<br/>
        ///     etag=adapter.etag,<br/>
        /// )
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.DeDeleteResponse> DeploymentServiceRemoveAdapterAsync(
            string projectId,
            string endpointId,
            string deploymentId,
            string id,
            string etag,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove a deployment adapter<br/>
        /// Detaches an adapter attachment by its `dad_` id using its row-level etag for optimistic concurrency.
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
        /// Adapter attachment `dad_` id from a prior add, update, get, or list response.
        /// </param>
        /// <param name="etag">
        /// Adapter etag from a previous add, update, get, or list response. The removal is rejected if the adapter changed after that response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// project_id = client.whoami().project_id<br/>
        /// # Read the attachment first: removing it requires its current etag.<br/>
        /// adapter = client.beta.endpoints.adapters.retrieve(<br/>
        ///     "dad_abc123",<br/>
        ///     project_id=project_id,<br/>
        ///     endpoint_id="ep_abc123",<br/>
        ///     deployment_id="dep_abc123",<br/>
        /// )<br/>
        /// client.beta.endpoints.adapters.delete(<br/>
        ///     "dad_abc123",<br/>
        ///     project_id=project_id,<br/>
        ///     endpoint_id="ep_abc123",<br/>
        ///     deployment_id="dep_abc123",<br/>
        ///     etag=adapter.etag,<br/>
        /// )
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeDeleteResponse>> DeploymentServiceRemoveAdapterAsResponseAsync(
            string projectId,
            string endpointId,
            string deploymentId,
            string id,
            string etag,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}