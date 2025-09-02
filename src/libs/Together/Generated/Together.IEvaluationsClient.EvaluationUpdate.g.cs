#nullable enable

namespace Together
{
    public partial interface IEvaluationsClient
    {
        /// <summary>
        /// Update evaluation job status<br/>
        /// Internal callback endpoint for workflows to update job status and results
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.EvaluationUpdateResponse> EvaluationUpdateAsync(
            string id,
            global::Together.EvaluationUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update evaluation job status<br/>
        /// Internal callback endpoint for workflows to update job status and results
        /// </summary>
        /// <param name="id"></param>
        /// <param name="error">
        /// Error message
        /// </param>
        /// <param name="results"></param>
        /// <param name="status">
        /// The new status for the job
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.EvaluationUpdateResponse> EvaluationUpdateAsync(
            string id,
            global::Together.EvaluationUpdateRequestStatus status,
            string? error = default,
            global::Together.OneOf<global::Together.EvaluationClassifyResults, global::Together.EvaluationScoreResults, global::Together.EvaluationCompareResults>? results = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}