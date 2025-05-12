#nullable enable

namespace Together
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// List checkpoints<br/>
        /// List the checkpoints for a single fine-tuning job.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.FinetuneListCheckpoints> GetFineTunesByIdCheckpointsAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}