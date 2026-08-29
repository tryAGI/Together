#nullable enable

namespace Together
{
    public partial interface IShadowExperimentServiceClient
    {
        /// <summary>
        /// List shadow experiment targets<br/>
        /// Lists the deployments that receive mirrored requests from a shadow experiment.
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
        /// <param name="limit">
        /// Maximum number of targets to return. Max 500, defaults to 50.
        /// </param>
        /// <param name="after">
        /// Cursor from a previous shadow experiment target list response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeListShadowExperimentTargetsResponse> ShadowExperimentServiceListTargetsAsync(
            string projectId,
            string endpointId,
            string experimentId,
            int? limit = default,
            string? after = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List shadow experiment targets<br/>
        /// Lists the deployments that receive mirrored requests from a shadow experiment.
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
        /// <param name="limit">
        /// Maximum number of targets to return. Max 500, defaults to 50.
        /// </param>
        /// <param name="after">
        /// Cursor from a previous shadow experiment target list response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeListShadowExperimentTargetsResponse>> ShadowExperimentServiceListTargetsAsResponseAsync(
            string projectId,
            string endpointId,
            string experimentId,
            int? limit = default,
            string? after = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}