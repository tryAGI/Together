#nullable enable

namespace Together
{
    public partial interface IEvaluationClient
    {
        /// <summary>
        /// Get all evaluation jobs
        /// </summary>
        /// <param name="status">
        /// Filter evaluation jobs by status
        /// </param>
        /// <param name="limit">
        /// Limit the number of results<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// # Docs for v1 can be found by changing the above selector ^<br/>
        /// from together import Together<br/>
        /// import os<br/>
        /// client = Together(<br/>
        ///     api_key=os.environ.get("TOGETHER_API_KEY"),<br/>
        /// )<br/>
        /// response = client.evals.list()<br/>
        /// for job in response:<br/>
        ///     print(job.workflow_id)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Together.EvaluationJob>> GetAllEvaluationJobsAsync(
            string? status = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}