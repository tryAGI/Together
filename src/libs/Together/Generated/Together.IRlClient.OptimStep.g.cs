#nullable enable

namespace Together
{
    public partial interface IRlClient
    {
        /// <summary>
        /// Optimizer step<br/>
        /// Submits an optimizer step operation that will asynchronously apply accumulated gradients to update model parameters. Does not make the updated parameters available for sampling; call `weights-sync` afterwards when you want subsequent samples to use the updated policy.
        /// </summary>
        /// <param name="sessionId">
        /// Training session ID
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlOptimStepOperation> OptimStepAsync(
            string sessionId,

            global::Together.RlOptimStepBody request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Optimizer step<br/>
        /// Submits an optimizer step operation that will asynchronously apply accumulated gradients to update model parameters. Does not make the updated parameters available for sampling; call `weights-sync` afterwards when you want subsequent samples to use the updated policy.
        /// </summary>
        /// <param name="sessionId">
        /// Training session ID
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.RlOptimStepOperation>> OptimStepAsResponseAsync(
            string sessionId,

            global::Together.RlOptimStepBody request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Optimizer step<br/>
        /// Submits an optimizer step operation that will asynchronously apply accumulated gradients to update model parameters. Does not make the updated parameters available for sampling; call `weights-sync` afterwards when you want subsequent samples to use the updated policy.
        /// </summary>
        /// <param name="sessionId">
        /// Training session ID
        /// </param>
        /// <param name="adamParams">
        /// Adam optimizer overrides for this step.
        /// </param>
        /// <param name="muonParams">
        /// Muon optimizer overrides for this step.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlOptimStepOperation> OptimStepAsync(
            string sessionId,
            global::Together.RlAdamParams? adamParams = default,
            global::Together.RlMuonParams? muonParams = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}