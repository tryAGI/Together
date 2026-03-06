#nullable enable

namespace Together
{
    public partial interface IBatchesClient
    {
        /// <summary>
        /// Cancel a batch job<br/>
        /// Cancel a batch job by ID
        /// </summary>
        /// <param name="id">
        /// The ID of the batch job to cancel<br/>
        /// Example: batch_job_abc123def456
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.BatchJob> CreateBatchesByIdCancelAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}