#nullable enable

namespace Together
{
    public partial interface IQueueClient
    {
        /// <summary>
        /// Get job status<br/>
        /// Poll the current status of a previously submitted job. Provide the request_id and model as query parameters.
        /// </summary>
        /// <param name="requestId">
        /// Request ID returned from the submit endpoint
        /// </param>
        /// <param name="model">
        /// Model name the job was submitted to
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.QueueJobStatusResponse> GetQueueJobStatusAsync(
            string requestId,
            string model,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}