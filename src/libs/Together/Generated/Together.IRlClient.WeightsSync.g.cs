#nullable enable

namespace Together
{
    public partial interface IRlClient
    {
        /// <summary>
        /// Weights sync<br/>
        /// Submits a weights-sync operation that makes the session's current trained parameters available for sampling. Call this after `optim-step` when you want subsequent samples to use the updated policy.
        /// </summary>
        /// <param name="sessionId">
        /// Training session ID
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlWeightsSyncOperation> WeightsSyncAsync(
            string sessionId,

            global::Together.RlWeightsSyncBody request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Weights sync<br/>
        /// Submits a weights-sync operation that makes the session's current trained parameters available for sampling. Call this after `optim-step` when you want subsequent samples to use the updated policy.
        /// </summary>
        /// <param name="sessionId">
        /// Training session ID
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.RlWeightsSyncOperation>> WeightsSyncAsResponseAsync(
            string sessionId,

            global::Together.RlWeightsSyncBody request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Weights sync<br/>
        /// Submits a weights-sync operation that makes the session's current trained parameters available for sampling. Call this after `optim-step` when you want subsequent samples to use the updated policy.
        /// </summary>
        /// <param name="sessionId">
        /// Training session ID
        /// </param>
        /// <param name="weightSyncType">
        /// How updated parameters are made available for sampling. See `WeightSyncType` for accepted values.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlWeightsSyncOperation> WeightsSyncAsync(
            string sessionId,
            global::Together.RlWeightSyncType weightSyncType,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}