#nullable enable

namespace Together
{
    public partial interface IEvaluationClient
    {
        /// <summary>
        /// Get model list
        /// </summary>
        /// <param name="modelSource">
        /// Filter models by source<br/>
        /// Default Value: all
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.GetModelListResponse> GetModelListAsync(
            string? modelSource = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}