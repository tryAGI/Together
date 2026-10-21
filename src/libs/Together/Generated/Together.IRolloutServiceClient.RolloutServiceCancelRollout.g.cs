#nullable enable

namespace Together
{
    public partial interface IRolloutServiceClient
    {
        /// <summary>
        /// Cancel a rollout<br/>
        /// Cancels a running, pausing, paused, system-paused, or stabilizing rollout by freezing the current traffic split into standing weights. Revert is removed and rejected; after canceling, start another canary rollout in either direction or rebalance the traffic split. The response is the accepted rollout snapshot; poll GetRollout until it reaches CANCELED.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="endpointId">
        /// Endpoint identifier.
        /// </param>
        /// <param name="id">
        /// Rollout identifier.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeRollout> RolloutServiceCancelRolloutAsync(
            string projectId,
            string endpointId,
            string id,

            global::Together.DeCancelRolloutRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel a rollout<br/>
        /// Cancels a running, pausing, paused, system-paused, or stabilizing rollout by freezing the current traffic split into standing weights. Revert is removed and rejected; after canceling, start another canary rollout in either direction or rebalance the traffic split. The response is the accepted rollout snapshot; poll GetRollout until it reaches CANCELED.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="endpointId">
        /// Endpoint identifier.
        /// </param>
        /// <param name="id">
        /// Rollout identifier.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeRollout>> RolloutServiceCancelRolloutAsResponseAsync(
            string projectId,
            string endpointId,
            string id,

            global::Together.DeCancelRolloutRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel a rollout<br/>
        /// Cancels a running, pausing, paused, system-paused, or stabilizing rollout by freezing the current traffic split into standing weights. Revert is removed and rejected; after canceling, start another canary rollout in either direction or rebalance the traffic split. The response is the accepted rollout snapshot; poll GetRollout until it reaches CANCELED.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="endpointId">
        /// Endpoint identifier.
        /// </param>
        /// <param name="id">
        /// Rollout identifier.
        /// </param>
        /// <param name="reason">
        /// Required human-readable reason recorded in the rollout audit trail.
        /// </param>
        /// <param name="etag">
        /// Optional etag for optimistic concurrency.
        /// </param>
        /// <param name="disposition">
        /// Optional cancel behavior. Absent defaults to freeze, which preserves the current traffic split. Revert is removed and rejected with FAILED_PRECONDITION; cancel with freeze, then run a reverse rollout back to the source.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeRollout> RolloutServiceCancelRolloutAsync(
            string projectId,
            string endpointId,
            string id,
            string reason,
            string? etag = default,
            global::Together.DeCancelRolloutRequestDisposition? disposition = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}