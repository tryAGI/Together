#nullable enable

namespace Together
{
    public partial interface IEvaluationClient
    {

        /// <summary>
        /// Get evaluation job status and results
        /// </summary>
        /// <param name="id">
        /// The ID of the evaluation job to get the status of
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
        /// response = client.evals.status('eval_id')<br/>
        /// print(response.status)<br/>
        /// print(response.results)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.GetEvaluationJobStatusAndResultsResponse> GetEvaluationJobStatusAndResultsAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}