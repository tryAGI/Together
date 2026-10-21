#nullable enable

namespace Together
{
    public partial interface IEvaluationClient
    {
        /// <summary>
        /// Create an evaluation job
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.EvaluationResponse> CreateEvaluationJobAsync(

            global::Together.EvaluationTypedRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an evaluation job
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.EvaluationResponse>> CreateEvaluationJobAsResponseAsync(

            global::Together.EvaluationTypedRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an evaluation job
        /// </summary>
        /// <param name="type">
        /// The type of evaluation to perform<br/>
        /// Example: classify
        /// </param>
        /// <param name="parameters">
        /// Type-specific parameters for the evaluation
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.EvaluationResponse> CreateEvaluationJobAsync(
            global::Together.EvaluationTypedRequestType type,
            global::Together.OneOf<global::Together.EvaluationClassifyParameters, global::Together.EvaluationScoreParameters, global::Together.EvaluationCompareParameters> parameters,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}