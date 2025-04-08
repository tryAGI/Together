#nullable enable

namespace Together
{
    public partial interface IJobsClient
    {
        /// <summary>
        /// List all jobs<br/>
        /// List all jobs and their statuses
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.ListJobsResponse> ListJobsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}