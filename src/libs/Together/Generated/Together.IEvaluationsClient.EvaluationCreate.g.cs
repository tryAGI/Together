#nullable enable

namespace Together
{
    public partial interface IEvaluationsClient
    {
        /// <summary>
        /// Create a new evaluation job<br/>
        /// Creates a new evaluation job for classify, score, or compare tasks
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.EvaluationResponse> EvaluationCreateAsync(
            global::Together.EvaluationTypedRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a new evaluation job<br/>
        /// Creates a new evaluation job for classify, score, or compare tasks
        /// </summary>
        /// <param name="parameters">
        /// Type-specific parameters for the evaluation
        /// </param>
        /// <param name="type">
        /// The type of evaluation to perform<br/>
        /// Example: classify
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.EvaluationResponse> EvaluationCreateAsync(
            global::Together.OneOf<global::Together.EvaluationClassifyParameters, global::Together.EvaluationScoreParameters, global::Together.EvaluationCompareParameters> parameters,
            global::Together.EvaluationTypedRequestType type,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}