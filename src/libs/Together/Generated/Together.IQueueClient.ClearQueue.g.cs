#nullable enable

namespace Together
{
    public partial interface IQueueClient
    {
        /// <summary>
        /// Clear a model's pending jobs<br/>
        /// Cancel all pending jobs for the given model. Running jobs are left untouched. Returns the number of jobs that were canceled.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.QueueClearResponse> ClearQueueAsync(

            global::Together.QueueClearRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clear a model's pending jobs<br/>
        /// Cancel all pending jobs for the given model. Running jobs are left untouched. Returns the number of jobs that were canceled.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.QueueClearResponse>> ClearQueueAsResponseAsync(

            global::Together.QueueClearRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clear a model's pending jobs<br/>
        /// Cancel all pending jobs for the given model. Running jobs are left untouched. Returns the number of jobs that were canceled.
        /// </summary>
        /// <param name="model">
        /// Model identifier whose pending jobs should be canceled
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.QueueClearResponse> ClearQueueAsync(
            string model,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}