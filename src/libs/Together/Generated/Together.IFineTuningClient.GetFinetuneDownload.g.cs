#nullable enable

namespace Together
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// Download model<br/>
        /// Receive a compressed fine-tuned model or checkpoint.
        /// </summary>
        /// <param name="ftId">
        /// Fine-tune ID to download. A string that starts with `ft-`.
        /// </param>
        /// <param name="checkpointStep">
        /// Specifies the checkpoint step to download from the list checkpoints response. A final checkpoint step downloads the final model; 0 or omitted downloads the final model by default. Ignores `checkpoint` value if set.
        /// </param>
        /// <param name="checkpoint">
        /// Specifies checkpoint type to download - `merged` vs `adapter`. This field is required if the checkpoint_step is not set.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> GetFinetuneDownloadAsync(
            string ftId,
            int? checkpointStep = default,
            global::Together.GetFinetuneDownloadCheckpoint? checkpoint = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download model<br/>
        /// Receive a compressed fine-tuned model or checkpoint.
        /// </summary>
        /// <param name="ftId">
        /// Fine-tune ID to download. A string that starts with `ft-`.
        /// </param>
        /// <param name="checkpointStep">
        /// Specifies the checkpoint step to download from the list checkpoints response. A final checkpoint step downloads the final model; 0 or omitted downloads the final model by default. Ignores `checkpoint` value if set.
        /// </param>
        /// <param name="checkpoint">
        /// Specifies checkpoint type to download - `merged` vs `adapter`. This field is required if the checkpoint_step is not set.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> GetFinetuneDownloadAsStreamAsync(
            string ftId,
            int? checkpointStep = default,
            global::Together.GetFinetuneDownloadCheckpoint? checkpoint = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download model<br/>
        /// Receive a compressed fine-tuned model or checkpoint.
        /// </summary>
        /// <param name="ftId">
        /// Fine-tune ID to download. A string that starts with `ft-`.
        /// </param>
        /// <param name="checkpointStep">
        /// Specifies the checkpoint step to download from the list checkpoints response. A final checkpoint step downloads the final model; 0 or omitted downloads the final model by default. Ignores `checkpoint` value if set.
        /// </param>
        /// <param name="checkpoint">
        /// Specifies checkpoint type to download - `merged` vs `adapter`. This field is required if the checkpoint_step is not set.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<byte[]>> GetFinetuneDownloadAsResponseAsync(
            string ftId,
            int? checkpointStep = default,
            global::Together.GetFinetuneDownloadCheckpoint? checkpoint = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}