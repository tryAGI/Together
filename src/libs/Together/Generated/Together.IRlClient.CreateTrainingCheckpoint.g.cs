#nullable enable

namespace Together
{
    public partial interface IRlClient
    {
        /// <summary>
        /// Save training checkpoint<br/>
        /// Submits an operation that will asynchronously save the full training state (adapter + optimizer + step).
        /// </summary>
        /// <param name="sessionId">
        /// Training session ID
        /// </param>
        /// <param name="idempotencyKey">
        /// Required key that makes retries return the original operation; use a new key for changed request bodies.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// import uuid<br/>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// operation = client.post_training.operations.create_training_checkpoint(<br/>
        ///     "&lt;SESSION_ID&gt;",<br/>
        ///     idempotency_key=str(uuid.uuid4()),<br/>
        /// )<br/>
        /// print(operation.id, operation.status)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.RlTrainingCheckpointOperation> CreateTrainingCheckpointAsync(
            string sessionId,
            string? idempotencyKey = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Save training checkpoint<br/>
        /// Submits an operation that will asynchronously save the full training state (adapter + optimizer + step).
        /// </summary>
        /// <param name="sessionId">
        /// Training session ID
        /// </param>
        /// <param name="idempotencyKey">
        /// Required key that makes retries return the original operation; use a new key for changed request bodies.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// import uuid<br/>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// operation = client.post_training.operations.create_training_checkpoint(<br/>
        ///     "&lt;SESSION_ID&gt;",<br/>
        ///     idempotency_key=str(uuid.uuid4()),<br/>
        /// )<br/>
        /// print(operation.id, operation.status)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.RlTrainingCheckpointOperation>> CreateTrainingCheckpointAsResponseAsync(
            string sessionId,
            string? idempotencyKey = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}