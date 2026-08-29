#nullable enable

namespace Together
{
    public partial interface IShadowExperimentServiceClient
    {
        /// <summary>
        /// Delete a shadow experiment target<br/>
        /// Removes a target from a shadow experiment without deleting the underlying deployment.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="endpointId">
        /// Endpoint identifier.
        /// </param>
        /// <param name="experimentId">
        /// Shadow experiment identifier.
        /// </param>
        /// <param name="id">
        /// Shadow experiment target identifier.
        /// </param>
        /// <param name="etag">
        /// Etag for optimistic concurrency.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeDeleteResponse> ShadowExperimentServiceDeleteTargetAsync(
            string projectId,
            string endpointId,
            string experimentId,
            string id,
            string? etag = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a shadow experiment target<br/>
        /// Removes a target from a shadow experiment without deleting the underlying deployment.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="endpointId">
        /// Endpoint identifier.
        /// </param>
        /// <param name="experimentId">
        /// Shadow experiment identifier.
        /// </param>
        /// <param name="id">
        /// Shadow experiment target identifier.
        /// </param>
        /// <param name="etag">
        /// Etag for optimistic concurrency.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeDeleteResponse>> ShadowExperimentServiceDeleteTargetAsResponseAsync(
            string projectId,
            string endpointId,
            string experimentId,
            string id,
            string? etag = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}