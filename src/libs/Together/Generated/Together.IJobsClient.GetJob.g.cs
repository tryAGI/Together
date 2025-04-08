#nullable enable

namespace Together
{
    public partial interface IJobsClient
    {
        /// <summary>
        /// Get job status<br/>
        /// Get the status of a specific job
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.GetJobResponse> GetJobAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}