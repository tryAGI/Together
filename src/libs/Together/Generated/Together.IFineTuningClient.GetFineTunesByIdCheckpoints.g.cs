#nullable enable

namespace Together
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// List checkpoints<br/>
        /// List the checkpoints for a single fine-tuning job.
        /// </summary>
        /// <param name="id">
        /// The ID of the fine-tune job to list checkpoints for
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// # Docs for v1 can be found by changing the above selector ^<br/>
        /// from together import Together<br/>
        /// import os<br/>
        /// client = Together(<br/>
        ///     api_key=os.environ.get("TOGETHER_API_KEY"),<br/>
        /// )<br/>
        /// checkpoints = client.fine_tuning.list_checkpoints(id="ft-id")<br/>
        /// print(checkpoints)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.FinetuneListCheckpoints> GetFineTunesByIdCheckpointsAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}