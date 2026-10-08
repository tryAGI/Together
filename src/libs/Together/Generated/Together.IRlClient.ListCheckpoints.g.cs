#nullable enable

namespace Together
{
    public partial interface IRlClient
    {
        /// <summary>
        /// List checkpoints<br/>
        /// Lists training and inference checkpoints owned by the caller, newest first. Filter by type, session, or base model, for example to recover a checkpoint ID for resume.
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
        /// <param name="type">
        /// Only return checkpoints of this type. CHECKPOINT_TYPE_TRAINING is the full training state (weights and optimizer state), for resuming a training session with its optimizer state; CHECKPOINT_TYPE_INFERENCE is a model ready for serving or download, also added to your models. When set, it must be CHECKPOINT_TYPE_TRAINING or CHECKPOINT_TYPE_INFERENCE; when omitted, checkpoints of both types are returned.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlCheckpointsListResponse> ListCheckpointsAsync(
            string? sessionId = default,
            string? baseModel = default,
            int? limit = default,
            string? after = default,
            global::Together.ListCheckpointsType? type = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List checkpoints<br/>
        /// Lists training and inference checkpoints owned by the caller, newest first. Filter by type, session, or base model, for example to recover a checkpoint ID for resume.
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
        /// <param name="type">
        /// Only return checkpoints of this type. CHECKPOINT_TYPE_TRAINING is the full training state (weights and optimizer state), for resuming a training session with its optimizer state; CHECKPOINT_TYPE_INFERENCE is a model ready for serving or download, also added to your models. When set, it must be CHECKPOINT_TYPE_TRAINING or CHECKPOINT_TYPE_INFERENCE; when omitted, checkpoints of both types are returned.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.RlCheckpointsListResponse>> ListCheckpointsAsResponseAsync(
            string? sessionId = default,
            string? baseModel = default,
            int? limit = default,
            string? after = default,
            global::Together.ListCheckpointsType? type = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}