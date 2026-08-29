#nullable enable

namespace Together
{
    public partial interface IABExperimentServiceClient
    {
        /// <summary>
        /// List A/B experiments<br/>
        /// Lists the managed live-traffic experiments configured for an endpoint.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="endpointId">
        /// Endpoint identifier.
        /// </param>
        /// <param name="limit">
        /// Maximum number of A/B experiments to return. Max 500, defaults to 50.
        /// </param>
        /// <param name="after">
        /// Cursor from a previous A/B experiment list response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeListABExperimentsResponse> ABExperimentServiceListABExperimentsAsync(
            string projectId,
            string endpointId,
            int? limit = default,
            string? after = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List A/B experiments<br/>
        /// Lists the managed live-traffic experiments configured for an endpoint.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="endpointId">
        /// Endpoint identifier.
        /// </param>
        /// <param name="limit">
        /// Maximum number of A/B experiments to return. Max 500, defaults to 50.
        /// </param>
        /// <param name="after">
        /// Cursor from a previous A/B experiment list response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeListABExperimentsResponse>> ABExperimentServiceListABExperimentsAsResponseAsync(
            string projectId,
            string endpointId,
            int? limit = default,
            string? after = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}