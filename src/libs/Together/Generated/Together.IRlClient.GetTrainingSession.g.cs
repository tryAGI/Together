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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// session = client.post_training.sessions.retrieve("&lt;SESSION_ID&gt;")<br/>
        /// print(session.status)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.RlTrainingSession> GetTrainingSessionAsync(
            string sessionId,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get training session<br/>
        /// Gets a training session by its ID and returns its details.
        /// </summary>
        /// <param name="sessionId">
        /// ID of the training session
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// session = client.post_training.sessions.retrieve("&lt;SESSION_ID&gt;")<br/>
        /// print(session.status)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.RlTrainingSession>> GetTrainingSessionAsResponseAsync(
            string sessionId,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}