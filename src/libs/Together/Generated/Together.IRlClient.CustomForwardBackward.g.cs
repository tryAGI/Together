#nullable enable

namespace Together
{
    public partial interface IRlClient
    {
        /// <summary>
        /// Custom forward-backward pass<br/>
        /// Submits a forward-backward pass driven by externally computed gradients of the loss with respect to per-token log-probabilities.
        /// </summary>
        /// <param name="sessionId">
        /// Training session ID
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlCustomForwardBackwardOperation> CustomForwardBackwardAsync(
            string sessionId,

            global::Together.RlCustomForwardBackwardBody request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Custom forward-backward pass<br/>
        /// Submits a forward-backward pass driven by externally computed gradients of the loss with respect to per-token log-probabilities.
        /// </summary>
        /// <param name="sessionId">
        /// Training session ID
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.RlCustomForwardBackwardOperation>> CustomForwardBackwardAsResponseAsync(
            string sessionId,

            global::Together.RlCustomForwardBackwardBody request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Custom forward-backward pass<br/>
        /// Submits a forward-backward pass driven by externally computed gradients of the loss with respect to per-token log-probabilities.
        /// </summary>
        /// <param name="sessionId">
        /// Training session ID
        /// </param>
        /// <param name="samples">
        /// Batch of training samples
        /// </param>
        /// <param name="gradients">
        /// Per-sample per-token gradients of the loss with respect to log-probabilities
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlCustomForwardBackwardOperation> CustomForwardBackwardAsync(
            string sessionId,
            global::System.Collections.Generic.IList<global::Together.RlTrainingSample> samples,
            global::System.Collections.Generic.IList<global::Together.RlTargetLogprobGradients> gradients,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}