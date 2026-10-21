#nullable enable

namespace Together
{
    public partial interface IShadowExperimentServiceClient
    {
        /// <summary>
        /// Update a shadow experiment<br/>
        /// Updates a shadow experiment's description or source sampling strategy. `updateMask` is required; source changes also require the current `etag` in the request body.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="endpointId">
        /// Endpoint identifier.
        /// </param>
        /// <param name="id">
        /// Shadow experiment identifier.
        /// </param>
        /// <param name="updateMask">
        /// Required fields to update, such as description or source.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeShadowExperiment> ShadowExperimentServiceUpdateShadowExperimentAsync(
            string projectId,
            string endpointId,
            string id,
            string updateMask,

            global::Together.DeUpdateShadowExperimentRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a shadow experiment<br/>
        /// Updates a shadow experiment's description or source sampling strategy. `updateMask` is required; source changes also require the current `etag` in the request body.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="endpointId">
        /// Endpoint identifier.
        /// </param>
        /// <param name="id">
        /// Shadow experiment identifier.
        /// </param>
        /// <param name="updateMask">
        /// Required fields to update, such as description or source.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeShadowExperiment>> ShadowExperimentServiceUpdateShadowExperimentAsResponseAsync(
            string projectId,
            string endpointId,
            string id,
            string updateMask,

            global::Together.DeUpdateShadowExperimentRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a shadow experiment<br/>
        /// Updates a shadow experiment's description or source sampling strategy. `updateMask` is required; source changes also require the current `etag` in the request body.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="endpointId">
        /// Endpoint identifier.
        /// </param>
        /// <param name="id">
        /// Shadow experiment identifier.
        /// </param>
        /// <param name="updateMask">
        /// Required fields to update, such as description or source.
        /// </param>
        /// <param name="description">
        /// Updated free-form description.
        /// </param>
        /// <param name="source">
        /// Updated endpoint sampling configuration. Source updates require etag in the request body.
        /// </param>
        /// <param name="etag">
        /// Opaque version tag from a prior read for optimistic concurrency.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeShadowExperiment> ShadowExperimentServiceUpdateShadowExperimentAsync(
            string projectId,
            string endpointId,
            string id,
            string updateMask,
            string? description = default,
            global::Together.DeShadowExperimentSource? source = default,
            string? etag = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}