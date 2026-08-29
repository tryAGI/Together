#nullable enable

namespace Together
{
    public partial interface IDeploymentServiceClient
    {
        /// <summary>
        /// Remove a deployment adapter<br/>
        /// Detaches an adapter from a deployment using its row-level etag for optimistic concurrency.
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
        /// <param name="etag">
        /// Adapter etag from a previous add, update, get, or list response. The removal is rejected if the adapter changed after that response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
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
        /// Detaches an adapter from a deployment using its row-level etag for optimistic concurrency.
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
        /// <param name="etag">
        /// Adapter etag from a previous add, update, get, or list response. The removal is rejected if the adapter changed after that response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
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