#nullable enable

namespace Together
{
    public partial interface IBatchesClient
    {
        /// <summary>
        /// Get a batch job<br/>
        /// Get details of a batch job by ID
        /// </summary>
        /// <param name="id">
        /// The ID of the batch job to retrieve<br/>
        /// Example: batch_job_abc123def456
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.BatchJob> GetBatchesByIdAsync(
            string id,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a batch job<br/>
        /// Get details of a batch job by ID
        /// </summary>
        /// <param name="id">
        /// The ID of the batch job to retrieve<br/>
        /// Example: batch_job_abc123def456
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.BatchJob>> GetBatchesByIdAsResponseAsync(
            string id,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}