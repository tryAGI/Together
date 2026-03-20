#nullable enable

namespace Together
{
    public partial interface IRlClient
    {

        /// <summary>
        /// Stop training session<br/>
        /// Stops a training session.
        /// </summary>
        /// <param name="sessionId">
        /// ID of the training session
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlTrainingSession> StopTrainingSessionAsync(
            string sessionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}