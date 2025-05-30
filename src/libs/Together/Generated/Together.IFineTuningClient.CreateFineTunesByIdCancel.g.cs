#nullable enable

namespace Together
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// Cancel job<br/>
        /// Cancel a currently running fine-tuning job. Returns a FinetuneResponseTruncated object.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.FinetuneResponseTruncated> CreateFineTunesByIdCancelAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}