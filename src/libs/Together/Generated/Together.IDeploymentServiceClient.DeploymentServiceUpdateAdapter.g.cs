#nullable enable

namespace Together
{
    public partial interface IDeploymentServiceClient
    {
        /// <summary>
        /// Update a deployment adapter<br/>
        /// Updates the pinned revision of an attached adapter using its row-level etag for optimistic concurrency.
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
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeAdapterEntry> DeploymentServiceUpdateAdapterAsync(
            string projectId,
            string endpointId,
            string deploymentId,
            string id,

            global::Together.DeUpdateAdapterRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a deployment adapter<br/>
        /// Updates the pinned revision of an attached adapter using its row-level etag for optimistic concurrency.
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
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeAdapterEntry>> DeploymentServiceUpdateAdapterAsResponseAsync(
            string projectId,
            string endpointId,
            string deploymentId,
            string id,

            global::Together.DeUpdateAdapterRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a deployment adapter<br/>
        /// Updates the pinned revision of an attached adapter using its row-level etag for optimistic concurrency.
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
        /// <param name="adapterRevisionId">
        /// New adapter revision to pin.
        /// </param>
        /// <param name="etag">
        /// Row-level etag from a prior AddAdapter, UpdateAdapter, GetAdapter, or ListAdapters response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeAdapterEntry> DeploymentServiceUpdateAdapterAsync(
            string projectId,
            string endpointId,
            string deploymentId,
            string id,
            string adapterRevisionId,
            string etag,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}