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
        global::System.Threading.Tasks.Task<global::Together.GetEvaluationJobStatusAndResultsResponse> GetEvaluationJobStatusAndResultsAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}