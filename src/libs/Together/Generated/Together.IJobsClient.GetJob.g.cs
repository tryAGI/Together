#nullable enable

namespace Together
{
    public partial interface IJobsClient
    {

        /// <summary>
        /// Get job status<br/>
        /// Get the status of a specific job
        /// </summary>
        /// <param name="jobId">
        /// The ID of the job to retrieve<br/>
        /// Example: job-a15dad11-8d8e-4007-97c5-a211304de284
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.JobInfoSuccessResponse> GetJobAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}