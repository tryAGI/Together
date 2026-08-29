#nullable enable

namespace Together
{
    public partial interface IRlClient
    {
        /// <summary>
        /// Get checkpoint<br/>
        /// Returns metadata for a checkpoint: type, base model, LoRA rank, step, and owning session.
        /// </summary>
        /// <param name="id">
        /// ID of the checkpoint
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlCheckpoint> GetCheckpointAsync(
            string id,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get checkpoint<br/>
        /// Returns metadata for a checkpoint: type, base model, LoRA rank, step, and owning session.
        /// </summary>
        /// <param name="id">
        /// ID of the checkpoint
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.RlCheckpoint>> GetCheckpointAsResponseAsync(
            string id,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}