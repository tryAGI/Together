#nullable enable

namespace Together
{
    public partial interface IRolloutServiceClient
    {
        /// <summary>
        /// List endpoint rollouts<br/>
        /// Lists rollout histories for an endpoint. Use `filter=ROLLOUT_FILTER_ACTIVE` to return only the active rollout, if one exists.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="endpointId">
        /// Endpoint identifier.
        /// </param>
        /// <param name="limit">
        /// Maximum number of rollouts to return. Max 500, defaults to 50.
        /// </param>
        /// <param name="after">
        /// Cursor from a previous rollout list response.
        /// </param>
        /// <param name="filter">
        /// Narrow results to active or terminal rollouts. Omit to list all rollouts.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeListRolloutsResponse> RolloutServiceListRolloutsAsync(
            string projectId,
            string endpointId,
            int? limit = default,
            string? after = default,
            global::Together.RolloutServiceListRolloutsFilter? filter = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List endpoint rollouts<br/>
        /// Lists rollout histories for an endpoint. Use `filter=ROLLOUT_FILTER_ACTIVE` to return only the active rollout, if one exists.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="endpointId">
        /// Endpoint identifier.
        /// </param>
        /// <param name="limit">
        /// Maximum number of rollouts to return. Max 500, defaults to 50.
        /// </param>
        /// <param name="after">
        /// Cursor from a previous rollout list response.
        /// </param>
        /// <param name="filter">
        /// Narrow results to active or terminal rollouts. Omit to list all rollouts.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeListRolloutsResponse>> RolloutServiceListRolloutsAsResponseAsync(
            string projectId,
            string endpointId,
            int? limit = default,
            string? after = default,
            global::Together.RolloutServiceListRolloutsFilter? filter = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}