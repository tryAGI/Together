#nullable enable

namespace Together
{
    public partial interface IRlClient
    {
        /// <summary>
        /// Download checkpoint<br/>
        /// Returns presigned URLs for downloading a checkpoint's model files. Only inference checkpoints support downloading.
        /// </summary>
        /// <param name="id">
        /// ID of the checkpoint
        /// </param>
        /// <param name="variant">
        /// Checkpoint variant to download: merged (full model) or adapter (LoRA weights only)<br/>
        /// Default Value: CHECKPOINT_VARIANT_UNSPECIFIED
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlCheckpointDownloadResponse> DownloadCheckpointAsync(
            string id,
            global::Together.RlCheckpointVariant variant = global::Together.RlCheckpointVariant.CheckpointVariantUnspecified,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}