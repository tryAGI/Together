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
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.RlForwardBackwardOperation>> ForwardBackwardAsResponseAsync(
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
        /// <param name="returnLossFnOutputs">
        /// Return the loss function's per-sample output tensors alongside the loss and metrics. Defaults to false. Enabling it increases the response size substantially for large batches and reduces step throughput, so leave it unset for ordinary training steps.<br/>
        /// Example: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlForwardBackwardOperation> ForwardBackwardAsync(
            string sessionId,
            global::System.Collections.Generic.IList<global::Together.RlTrainingSample> samples,
            global::Together.RlLossConfig loss,
            bool? returnLossFnOutputs = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}