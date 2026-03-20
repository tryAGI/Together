#nullable enable

namespace Together
{
    public partial interface IQueueClient
    {

        /// <summary>
        /// Cancel a queued job<br/>
        /// Cancel a pending job. Only jobs in pending status can be canceled.<br/>
        /// Running jobs cannot be stopped. Returns the job status after the<br/>
        /// attempt. If the job is not pending, returns 409 with the current status<br/>
        /// unchanged.
        /// </summary>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.QueueCancelResponse> CancelQueueJobAsync(

            global::Together.QueueCancelRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Cancel a queued job<br/>
        /// Cancel a pending job. Only jobs in pending status can be canceled.<br/>
        /// Running jobs cannot be stopped. Returns the job status after the<br/>
        /// attempt. If the job is not pending, returns 409 with the current status<br/>
        /// unchanged.
        /// </summary>
        /// <param name="model">
        /// Model identifier the job was submitted to
        /// </param>
        /// <param name="requestId">
        /// The request ID returned from the submit endpoint
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.QueueCancelResponse> CancelQueueJobAsync(
            string model,
            string requestId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}