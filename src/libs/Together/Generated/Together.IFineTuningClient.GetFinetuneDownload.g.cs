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
        /// Specifies step number for checkpoint to download. Ignores `checkpoint` value if set.
        /// </param>
        /// <param name="checkpoint">
        /// Specifies checkpoint type to download - `merged` vs `adapter`. This field is required if the checkpoint_step is not set.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> GetFinetuneDownloadAsync(
            string ftId,
            int? checkpointStep = default,
            global::Together.Checkpoint? checkpoint = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}