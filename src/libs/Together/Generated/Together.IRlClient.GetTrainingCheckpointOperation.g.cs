#nullable enable

namespace Together
{
    public partial interface IRlClient
    {
        /// <summary>
        /// Get save training checkpoint operation<br/>
        /// Retrieves the current status and result of a save training checkpoint operation.
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
        global::System.Threading.Tasks.Task<global::Together.RlTrainingCheckpointOperation> GetTrainingCheckpointOperationAsync(
            string sessionId,
            string operationId,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}