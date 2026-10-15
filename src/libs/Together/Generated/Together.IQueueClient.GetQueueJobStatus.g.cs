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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// job = client.beta.jig.queue.retrieve(<br/>
        ///     model="my-deployment",<br/>
        ///     request_id="req_abc123",<br/>
        /// )<br/>
        /// print(job.status)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.QueueJobStatusResponse> GetQueueJobStatusAsync(
            string requestId,
            string model,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// job = client.beta.jig.queue.retrieve(<br/>
        ///     model="my-deployment",<br/>
        ///     request_id="req_abc123",<br/>
        /// )<br/>
        /// print(job.status)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.QueueJobStatusResponse>> GetQueueJobStatusAsResponseAsync(
            string requestId,
            string model,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}