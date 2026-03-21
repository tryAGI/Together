#nullable enable

namespace Together
{
    public partial interface IQueueClient
    {
        /// <summary>
        /// Submit a queued job<br/>
        /// Submit a new job to the queue for asynchronous processing. Jobs are<br/>
        /// processed in strict priority order (higher priority first, FIFO within<br/>
        /// the same priority). Returns a request ID that can be used to poll status<br/>
        /// or cancel the job.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.QueueJobResponse> SubmitQueueJobAsync(

            global::Together.QueueJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit a queued job<br/>
        /// Submit a new job to the queue for asynchronous processing. Jobs are<br/>
        /// processed in strict priority order (higher priority first, FIFO within<br/>
        /// the same priority). Returns a request ID that can be used to poll status<br/>
        /// or cancel the job.
        /// </summary>
        /// <param name="info">
        /// Arbitrary JSON metadata stored with the job and returned in status<br/>
        /// responses. The model and system may add or update keys during<br/>
        /// processing.
        /// </param>
        /// <param name="model">
        /// Required model identifier
        /// </param>
        /// <param name="payload">
        /// Freeform model input. Passed unchanged to the model. Contents are model-specific.
        /// </param>
        /// <param name="priority">
        /// Job priority. Higher values are processed first (strict priority<br/>
        /// ordering). Jobs with equal priority are processed in submission<br/>
        /// order (FIFO).<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.QueueJobResponse> SubmitQueueJobAsync(
            string model,
            object payload,
            object? info = default,
            int? priority = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}