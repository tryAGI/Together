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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.QueueMetricsResponse> GetQueueMetricsAsync(
            string model,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}