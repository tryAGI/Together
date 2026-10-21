#nullable enable

namespace Together
{
    public partial interface IShadowExperimentServiceClient
    {
        /// <summary>
        /// List shadow experiments<br/>
        /// Lists experiments that mirror sampled endpoint traffic to target deployments without affecting client responses. Set `includeTargets=true` to include target details inline.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="endpointId">
        /// Endpoint identifier.
        /// </param>
        /// <param name="limit">
        /// Maximum number of shadow experiments to return. Max 500, defaults to 50.
        /// </param>
        /// <param name="after">
        /// Cursor from a previous shadow experiment list response.
        /// </param>
        /// <param name="includeTargets">
        /// Whether to include target deployments in each returned shadow experiment.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeListShadowExperimentsResponse> ShadowExperimentServiceListShadowExperimentsAsync(
            string projectId,
            string endpointId,
            int? limit = default,
            string? after = default,
            bool? includeTargets = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List shadow experiments<br/>
        /// Lists experiments that mirror sampled endpoint traffic to target deployments without affecting client responses. Set `includeTargets=true` to include target details inline.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="endpointId">
        /// Endpoint identifier.
        /// </param>
        /// <param name="limit">
        /// Maximum number of shadow experiments to return. Max 500, defaults to 50.
        /// </param>
        /// <param name="after">
        /// Cursor from a previous shadow experiment list response.
        /// </param>
        /// <param name="includeTargets">
        /// Whether to include target deployments in each returned shadow experiment.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeListShadowExperimentsResponse>> ShadowExperimentServiceListShadowExperimentsAsResponseAsync(
            string projectId,
            string endpointId,
            int? limit = default,
            string? after = default,
            bool? includeTargets = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}