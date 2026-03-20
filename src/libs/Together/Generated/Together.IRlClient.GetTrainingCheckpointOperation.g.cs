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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlTrainingCheckpointOperation> GetTrainingCheckpointOperationAsync(
            string sessionId,
            string operationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}