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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlTrainingCheckpointOperation> CreateTrainingCheckpointAsync(
            string sessionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}