#nullable enable

namespace Together
{
    public partial interface IRlClient
    {
        /// <summary>
        /// Create training session<br/>
        /// Creates a training session and returns its details.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlTrainingSession> StartTrainingSessionAsync(

            global::Together.RlStartTrainingSessionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create training session<br/>
        /// Creates a training session and returns its details.
        /// </summary>
        /// <param name="baseModel">
        /// Base model to use for the training session<br/>
        /// Example: meta-llama/Meta-Llama-3-8B-Instruct
        /// </param>
        /// <param name="checkpointId">
        /// Checkpoint ID to use for the training session<br/>
        /// Example: checkpoint-123
        /// </param>
        /// <param name="loraConfig">
        /// LoRA adapter configuration
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlTrainingSession> StartTrainingSessionAsync(
            string baseModel,
            string? checkpointId = default,
            global::Together.RlLoraConfig? loraConfig = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}