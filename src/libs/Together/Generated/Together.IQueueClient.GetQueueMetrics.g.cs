#nullable enable

namespace Together
{
    public partial interface IQueueClient
    {
        /// <summary>
        /// Get queue metrics<br/>
        /// Get the current queue statistics for a model, including pending and running job counts.
        /// </summary>
        /// <param name="model">
        /// Model name to get metrics for
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.QueueMetricsResponse> GetQueueMetricsAsync(
            string model,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}