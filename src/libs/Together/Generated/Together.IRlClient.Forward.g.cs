#nullable enable

namespace Together
{
    public partial interface IRlClient
    {
        /// <summary>
        /// Forward pass<br/>
        /// Submits a forward operation that will asynchronously run a no-grad forward pass and return per-token log-probabilities for each sample.
        /// </summary>
        /// <param name="sessionId">
        /// Training session ID
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlForwardOperation> ForwardAsync(
            string sessionId,

            global::Together.RlForwardBody request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Forward pass<br/>
        /// Submits a forward operation that will asynchronously run a no-grad forward pass and return per-token log-probabilities for each sample.
        /// </summary>
        /// <param name="sessionId">
        /// Training session ID
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.RlForwardOperation>> ForwardAsResponseAsync(
            string sessionId,

            global::Together.RlForwardBody request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Forward pass<br/>
        /// Submits a forward operation that will asynchronously run a no-grad forward pass and return per-token log-probabilities for each sample.
        /// </summary>
        /// <param name="sessionId">
        /// Training session ID
        /// </param>
        /// <param name="samples">
        /// Batch of training samples for which to compute per-token log-probabilities
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlForwardOperation> ForwardAsync(
            string sessionId,
            global::System.Collections.Generic.IList<global::Together.RlTrainingSample> samples,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}