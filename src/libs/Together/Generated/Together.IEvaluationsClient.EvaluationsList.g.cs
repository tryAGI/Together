#nullable enable

namespace Together
{
    public partial interface IEvaluationsClient
    {
        /// <summary>
        /// List evaluation jobs<br/>
        /// Get a list of evaluation jobs with optional filtering
        /// </summary>
        /// <param name="status"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Together.EvaluationJob>> EvaluationsListAsync(
            global::Together.EvaluationsListStatus? status = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}