#nullable enable

namespace Together
{
    public partial interface IRlClient
    {
        /// <summary>
        /// Get inference checkpoint operation<br/>
        /// Retrieves the current status and result of an inference checkpoint operation.
        /// </summary>
        /// <param name="sessionId">
        /// Training session ID
        /// </param>
        /// <param name="operationId">
        /// Operation ID
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlInferenceCheckpointOperation> GetInferenceCheckpointOperationAsync(
            string sessionId,
            string operationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}