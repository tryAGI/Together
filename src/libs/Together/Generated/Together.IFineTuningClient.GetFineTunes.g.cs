#nullable enable

namespace Together
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// List all jobs<br/>
        /// List the metadata for all fine-tuning jobs. Returns a list of FinetuneResponseTruncated objects.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.FinetuneTruncatedList> GetFineTunesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}