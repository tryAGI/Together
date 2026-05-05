#nullable enable

namespace Together
{
    public partial interface IRlClient
    {
        /// <summary>
        /// Forward-backward pass<br/>
        /// Submits a forward-backward pass operation that will asynchronously compute gradients via backpropagation.
        /// </summary>
        /// <param name="sessionId">
        /// Training session ID
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlForwardBackwardOperation> ForwardBackwardAsync(
            string sessionId,

            global::Together.RlForwardBackwardBody request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Forward-backward pass<br/>
        /// Submits a forward-backward pass operation that will asynchronously compute gradients via backpropagation.
        /// </summary>
        /// <param name="sessionId">
        /// Training session ID
        /// </param>
        /// <param name="samples">
        /// Batch of training samples to process
        /// </param>
        /// <param name="loss">
        /// Loss function configuration
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlForwardBackwardOperation> ForwardBackwardAsync(
            string sessionId,
            global::System.Collections.Generic.IList<global::Together.RlTrainingSample> samples,
            global::Together.RlLossConfig loss,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}