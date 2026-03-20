#nullable enable

namespace Together
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// Get model limits<br/>
        /// Get model limits for a specific fine-tuning model.
        /// </summary>
        /// <param name="modelName">
        /// The model name to get limits for.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.FineTuneModelLimits> GetFineTunesModelsLimitsAsync(
            string modelName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}