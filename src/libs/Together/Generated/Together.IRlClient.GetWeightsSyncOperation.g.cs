#nullable enable

namespace Together
{
    public partial interface IRlClient
    {
        /// <summary>
        /// Get weights-sync operation<br/>
        /// Retrieves the current status and result of a weights-sync operation.
        /// </summary>
        /// <param name="sessionId">
        /// Training session ID
        /// </param>
        /// <param name="operationId">
        /// Operation ID
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// operation = client.post_training.operations.retrieve_weights_sync(<br/>
        ///     "&lt;OPERATION_ID&gt;",<br/>
        ///     session_id="&lt;SESSION_ID&gt;",<br/>
        /// )<br/>
        /// print(operation.status)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.RlWeightsSyncOperation> GetWeightsSyncOperationAsync(
            string sessionId,
            string operationId,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get weights-sync operation<br/>
        /// Retrieves the current status and result of a weights-sync operation.
        /// </summary>
        /// <param name="sessionId">
        /// Training session ID
        /// </param>
        /// <param name="operationId">
        /// Operation ID
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// operation = client.post_training.operations.retrieve_weights_sync(<br/>
        ///     "&lt;OPERATION_ID&gt;",<br/>
        ///     session_id="&lt;SESSION_ID&gt;",<br/>
        /// )<br/>
        /// print(operation.status)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.RlWeightsSyncOperation>> GetWeightsSyncOperationAsResponseAsync(
            string sessionId,
            string operationId,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}