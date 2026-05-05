#nullable enable

namespace Together
{
    public partial interface IJobsClient
    {
        /// <summary>
        /// List all jobs<br/>
        /// List all jobs and their statuses
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.JobsInfoSuccessResponse> ListJobsAsync(
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}