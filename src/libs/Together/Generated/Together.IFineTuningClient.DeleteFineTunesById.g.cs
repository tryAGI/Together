#nullable enable

namespace Together
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// Delete a fine-tune job<br/>
        /// Delete a fine-tuning job.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="force"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.FinetuneDeleteResponse> DeleteFineTunesByIdAsync(
            string id,
            bool force,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}