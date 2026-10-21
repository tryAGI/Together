#nullable enable

namespace Together
{
    public partial interface IRlClient
    {
        /// <summary>
        /// Update a training session<br/>
        /// Updates the display name or metadata associated with a training session. Omitted fields remain unchanged, and empty strings clear existing values.
        /// </summary>
        /// <param name="sessionId">
        /// ID of the training session
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlTrainingSession> UpdateTrainingSessionAsync(
            string sessionId,

            global::Together.RlUpdateTrainingSessionRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a training session<br/>
        /// Updates the display name or metadata associated with a training session. Omitted fields remain unchanged, and empty strings clear existing values.
        /// </summary>
        /// <param name="sessionId">
        /// ID of the training session
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.RlTrainingSession>> UpdateTrainingSessionAsResponseAsync(
            string sessionId,

            global::Together.RlUpdateTrainingSessionRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a training session<br/>
        /// Updates the display name or metadata associated with a training session. Omitted fields remain unchanged, and empty strings clear existing values.
        /// </summary>
        /// <param name="sessionId">
        /// ID of the training session
        /// </param>
        /// <param name="displayName">
        /// Display name to update. An empty string clears the existing display name.
        /// </param>
        /// <param name="metadata">
        /// Metadata fields to update. Omitted fields remain unchanged, and empty strings clear existing values.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlTrainingSession> UpdateTrainingSessionAsync(
            string sessionId,
            string? displayName = default,
            global::Together.RlTrainingSessionMetadata? metadata = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}