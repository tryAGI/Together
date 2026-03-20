#nullable enable

namespace Together
{
    public partial interface IEvaluationClient
    {
        /// <summary>
        /// Get evaluation job details
        /// </summary>
        /// <param name="id">
        /// The ID of the evaluation job to retrieve
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.EvaluationJob> GetEvaluationJobDetailsAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}