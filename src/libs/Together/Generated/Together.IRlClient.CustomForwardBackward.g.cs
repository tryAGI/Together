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
        /// # One gradient per sample: d(loss)/d(logprob) for each target token.<br/>
        /// operation = client.post_training.operations.custom_forward_backward(<br/>
        ///     "&lt;SESSION_ID&gt;",<br/>
        ///     idempotency_key=str(uuid.uuid4()),<br/>
        ///     gradients=[{"data": [0.0, 0.0, -0.5, -0.5], "dtype": "D_TYPE_FLOAT32"}],<br/>
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
        global::System.Threading.Tasks.Task<global::Together.RlCustomForwardBackwardOperation> CustomForwardBackwardAsync(
            string sessionId,

            global::Together.RlCustomForwardBackwardBody request,
            string? idempotencyKey = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Custom forward-backward pass<br/>
        /// Submits a forward-backward pass driven by externally computed gradients of the loss with respect to per-token log-probabilities.
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
        /// # One gradient per sample: d(loss)/d(logprob) for each target token.<br/>
        /// operation = client.post_training.operations.custom_forward_backward(<br/>
        ///     "&lt;SESSION_ID&gt;",<br/>
        ///     idempotency_key=str(uuid.uuid4()),<br/>
        ///     gradients=[{"data": [0.0, 0.0, -0.5, -0.5], "dtype": "D_TYPE_FLOAT32"}],<br/>
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
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.RlCustomForwardBackwardOperation>> CustomForwardBackwardAsResponseAsync(
            string sessionId,

            global::Together.RlCustomForwardBackwardBody request,
            string? idempotencyKey = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Custom forward-backward pass<br/>
        /// Submits a forward-backward pass driven by externally computed gradients of the loss with respect to per-token log-probabilities.
        /// </summary>
        /// <param name="sessionId">
        /// Training session ID
        /// </param>
        /// <param name="idempotencyKey">
        /// Required key that makes retries return the original operation; use a new key for changed request bodies.
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
            string? idempotencyKey = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}