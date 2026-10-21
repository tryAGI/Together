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
        /// operation = client.post_training.operations.optim_step(<br/>
        ///     "&lt;SESSION_ID&gt;",<br/>
        ///     idempotency_key=str(uuid.uuid4()),<br/>
        ///     adam_params={"learning_rate": 1e-5},<br/>
        /// )<br/>
        /// print(operation.id, operation.status)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.RlOptimStepOperation> OptimStepAsync(
            string sessionId,

            global::Together.RlOptimStepBody request,
            string? idempotencyKey = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Optimizer step<br/>
        /// Submits an optimizer step operation that will asynchronously apply accumulated gradients to update model parameters. Does not make the updated parameters available for sampling; call `weights-sync` afterwards when you want subsequent samples to use the updated policy.
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
        /// operation = client.post_training.operations.optim_step(<br/>
        ///     "&lt;SESSION_ID&gt;",<br/>
        ///     idempotency_key=str(uuid.uuid4()),<br/>
        ///     adam_params={"learning_rate": 1e-5},<br/>
        /// )<br/>
        /// print(operation.id, operation.status)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.RlOptimStepOperation>> OptimStepAsResponseAsync(
            string sessionId,

            global::Together.RlOptimStepBody request,
            string? idempotencyKey = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Optimizer step<br/>
        /// Submits an optimizer step operation that will asynchronously apply accumulated gradients to update model parameters. Does not make the updated parameters available for sampling; call `weights-sync` afterwards when you want subsequent samples to use the updated policy.
        /// </summary>
        /// <param name="sessionId">
        /// Training session ID
        /// </param>
        /// <param name="idempotencyKey">
        /// Required key that makes retries return the original operation; use a new key for changed request bodies.
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
            string? idempotencyKey = default,
            global::Together.RlAdamParams? adamParams = default,
            global::Together.RlMuonParams? muonParams = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}