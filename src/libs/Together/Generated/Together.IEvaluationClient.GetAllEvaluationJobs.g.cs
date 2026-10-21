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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Together.EvaluationJob>> GetAllEvaluationJobsAsync(
            string? status = default,
            int? limit = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Together.EvaluationJob>>> GetAllEvaluationJobsAsResponseAsync(
            string? status = default,
            int? limit = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}