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
        /// <param name="resumeFromCheckpointId">
        /// Checkpoint ID to resume from<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="loraConfig">
        /// LoRA adapter configuration
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlTrainingSession> StartTrainingSessionAsync(
            string baseModel,
            string? resumeFromCheckpointId = default,
            global::Together.RlLoraConfig? loraConfig = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}