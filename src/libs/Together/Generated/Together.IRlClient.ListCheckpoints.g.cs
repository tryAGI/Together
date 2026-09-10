#nullable enable

namespace Together
{
    public partial interface IRlClient
    {
        /// <summary>
        /// List training checkpoints<br/>
        /// Lists training checkpoints owned by the caller. Filter by session or base model to recover a checkpoint ID for resume. Inference checkpoints are not included; they remain on the training session and in the model catalog.
        /// </summary>
        /// <param name="sessionId">
        /// Only return checkpoints produced by this training session
        /// </param>
        /// <param name="baseModel">
        /// Only return checkpoints trained from this base model. Match is exact.
        /// </param>
        /// <param name="limit">
        /// Maximum number of checkpoints to return (1-100)<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="after">
        /// Cursor for pagination (ID of the last checkpoint from the previous page)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlCheckpointsListResponse> ListCheckpointsAsync(
            string? sessionId = default,
            string? baseModel = default,
            int? limit = default,
            string? after = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List training checkpoints<br/>
        /// Lists training checkpoints owned by the caller. Filter by session or base model to recover a checkpoint ID for resume. Inference checkpoints are not included; they remain on the training session and in the model catalog.
        /// </summary>
        /// <param name="sessionId">
        /// Only return checkpoints produced by this training session
        /// </param>
        /// <param name="baseModel">
        /// Only return checkpoints trained from this base model. Match is exact.
        /// </param>
        /// <param name="limit">
        /// Maximum number of checkpoints to return (1-100)<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="after">
        /// Cursor for pagination (ID of the last checkpoint from the previous page)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.RlCheckpointsListResponse>> ListCheckpointsAsResponseAsync(
            string? sessionId = default,
            string? baseModel = default,
            int? limit = default,
            string? after = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}