#nullable enable

namespace Together
{
    public partial interface IRlClient
    {
        /// <summary>
        /// Get training session<br/>
        /// Gets a training session by its ID and returns its details.
        /// </summary>
        /// <param name="sessionId">
        /// ID of the training session
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlTrainingSession> GetTrainingSessionAsync(
            string sessionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}