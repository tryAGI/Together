#nullable enable

namespace Together
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// Download model<br/>
        /// Download a compressed fine-tuned model or checkpoint to local disk.
        /// </summary>
        /// <param name="ftId"></param>
        /// <param name="checkpointStep"></param>
        /// <param name="checkpoint"></param>
        /// <param name="output"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.FinetuneDownloadResult> GetFinetuneDownloadAsync(
            string ftId,
            int? checkpointStep = default,
            global::Together.Checkpoint? checkpoint = default,
            string? output = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}