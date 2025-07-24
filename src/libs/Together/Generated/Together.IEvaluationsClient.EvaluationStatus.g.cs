#nullable enable

namespace Together
{
    public partial interface IEvaluationsClient
    {
        /// <summary>
        /// Get evaluation job status and results<br/>
        /// Get the status and results of a specific evaluation job
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.EvaluationStatusResponse> EvaluationStatusAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}