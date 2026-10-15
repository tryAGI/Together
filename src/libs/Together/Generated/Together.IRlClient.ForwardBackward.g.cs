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
        /// <param name="idempotencyKey">
        /// Required key that makes retries return the original operation; use a new key for changed request bodies.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// import uuid<br/>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// # Token IDs come from the base model's tokenizer.<br/>
        /// operation = client.post_training.operations.forward_backward(<br/>
        ///     "&lt;SESSION_ID&gt;",<br/>
        ///     idempotency_key=str(uuid.uuid4()),<br/>
        ///     loss={"type": "LOSS_TYPE_CROSS_ENTROPY"},<br/>
        ///     samples=[<br/>
        ///         {<br/>
        ///             "model_input": {<br/>
        ///                 "chunks": [<br/>
        ///                     {"encoded_text": {"tokens": [791, 6864, 315, 9822]}}<br/>
        ///                 ]<br/>
        ///             },<br/>
        ///             "loss_fn_inputs": {<br/>
        ///                 "target_tokens": {<br/>
        ///                     "data": [6864, 315, 9822, 374],<br/>
        ///                     "dtype": "int64",<br/>
        ///                 },<br/>
        ///                 "weights": {"data": [0.0, 0.0, 1.0, 1.0], "dtype": "float32"},<br/>
        ///             },<br/>
        ///         }<br/>
        ///     ],<br/>
        /// )<br/>
        /// print(operation.id, operation.status)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.RlForwardBackwardOperation> ForwardBackwardAsync(
            string sessionId,

            global::Together.RlForwardBackwardBody request,
            string? idempotencyKey = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Forward-backward pass<br/>
        /// Submits a forward-backward pass operation that will asynchronously compute gradients via backpropagation.
        /// </summary>
        /// <param name="sessionId">
        /// Training session ID
        /// </param>
        /// <param name="idempotencyKey">
        /// Required key that makes retries return the original operation; use a new key for changed request bodies.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// import uuid<br/>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// # Token IDs come from the base model's tokenizer.<br/>
        /// operation = client.post_training.operations.forward_backward(<br/>
        ///     "&lt;SESSION_ID&gt;",<br/>
        ///     idempotency_key=str(uuid.uuid4()),<br/>
        ///     loss={"type": "LOSS_TYPE_CROSS_ENTROPY"},<br/>
        ///     samples=[<br/>
        ///         {<br/>
        ///             "model_input": {<br/>
        ///                 "chunks": [<br/>
        ///                     {"encoded_text": {"tokens": [791, 6864, 315, 9822]}}<br/>
        ///                 ]<br/>
        ///             },<br/>
        ///             "loss_fn_inputs": {<br/>
        ///                 "target_tokens": {<br/>
        ///                     "data": [6864, 315, 9822, 374],<br/>
        ///                     "dtype": "int64",<br/>
        ///                 },<br/>
        ///                 "weights": {"data": [0.0, 0.0, 1.0, 1.0], "dtype": "float32"},<br/>
        ///             },<br/>
        ///         }<br/>
        ///     ],<br/>
        /// )<br/>
        /// print(operation.id, operation.status)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.RlForwardBackwardOperation>> ForwardBackwardAsResponseAsync(
            string sessionId,

            global::Together.RlForwardBackwardBody request,
            string? idempotencyKey = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Forward-backward pass<br/>
        /// Submits a forward-backward pass operation that will asynchronously compute gradients via backpropagation.
        /// </summary>
        /// <param name="sessionId">
        /// Training session ID
        /// </param>
        /// <param name="idempotencyKey">
        /// Required key that makes retries return the original operation; use a new key for changed request bodies.
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
        /// <param name="forwardOnly">
        /// Run the forward pass only: report the loss and metrics, and the per-sample outputs when requested, without accumulating gradients. Defaults to false. Pair it with `return_loss_fn_outputs` to score a batch and read back its per-token log-probabilities.<br/>
        /// Example: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlForwardBackwardOperation> ForwardBackwardAsync(
            string sessionId,
            global::System.Collections.Generic.IList<global::Together.RlTrainingSample> samples,
            global::Together.RlLossConfig loss,
            string? idempotencyKey = default,
            bool? returnLossFnOutputs = default,
            bool? forwardOnly = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}