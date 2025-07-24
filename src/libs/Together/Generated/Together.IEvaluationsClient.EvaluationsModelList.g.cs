#nullable enable

namespace Together
{
    public partial interface IEvaluationsClient
    {
        /// <summary>
        /// Get allowed models list<br/>
        /// Get the list of models that are allowed for evaluation
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.EvaluationsModelListResponse> EvaluationsModelListAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}