#nullable enable

namespace Together
{
    public partial interface IBatchesClient
    {
        /// <summary>
        /// Get a batch job<br/>
        /// Get details of a batch job by ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.BatchJob> GetBatchesByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}