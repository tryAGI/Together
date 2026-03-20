#nullable enable

namespace Together
{
    public partial interface IRlClient
    {
        /// <summary>
        /// Optimizer step<br/>
        /// Submits an optimizer step operation that will asynchronously apply accumulated gradients to update model parameters.
        /// </summary>
        /// <param name="sessionId">
        /// Training session ID
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlOptimStepOperation> OptimStepAsync(
            string sessionId,

            global::Together.RlOptimStepBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Optimizer step<br/>
        /// Submits an optimizer step operation that will asynchronously apply accumulated gradients to update model parameters.
        /// </summary>
        /// <param name="sessionId">
        /// Training session ID
        /// </param>
        /// <param name="learningRate">
        /// Learning rate for this step.<br/>
        /// Default Value: 0.0001<br/>
        /// Example: 0.0001
        /// </param>
        /// <param name="adamwParams">
        /// AdamW optimizer parameters
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlOptimStepOperation> OptimStepAsync(
            string sessionId,
            float? learningRate = default,
            global::Together.RlAdamWOptimizerParams? adamwParams = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}