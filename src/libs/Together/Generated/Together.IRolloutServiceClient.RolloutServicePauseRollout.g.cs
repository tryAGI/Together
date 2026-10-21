#nullable enable

namespace Together
{
    public partial interface IRolloutServiceClient
    {
        /// <summary>
        /// Pause a rollout<br/>
        /// Requests a running or stabilizing rollout to pause and records an optional reason. The response returns the PAUSING snapshot; poll GetRollout until state is PAUSED to confirm the executor has parked.
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
        global::System.Threading.Tasks.Task<global::Together.DeRollout> RolloutServicePauseRolloutAsync(
            string projectId,
            string endpointId,
            string id,

            global::Together.DePauseRolloutRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Pause a rollout<br/>
        /// Requests a running or stabilizing rollout to pause and records an optional reason. The response returns the PAUSING snapshot; poll GetRollout until state is PAUSED to confirm the executor has parked.
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
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeRollout>> RolloutServicePauseRolloutAsResponseAsync(
            string projectId,
            string endpointId,
            string id,

            global::Together.DePauseRolloutRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Pause a rollout<br/>
        /// Requests a running or stabilizing rollout to pause and records an optional reason. The response returns the PAUSING snapshot; poll GetRollout until state is PAUSED to confirm the executor has parked.
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
        /// <param name="etag">
        /// Optional etag for optimistic concurrency.
        /// </param>
        /// <param name="reason">
        /// Optional human-readable reason recorded on the rollout pause metadata.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeRollout> RolloutServicePauseRolloutAsync(
            string projectId,
            string endpointId,
            string id,
            string? etag = default,
            string? reason = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}