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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlTrainingSession> StartTrainingSessionAsync(

            global::Together.RlStartTrainingSessionRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create training session<br/>
        /// Creates a training session and returns its details.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.RlTrainingSession>> StartTrainingSessionAsResponseAsync(

            global::Together.RlStartTrainingSessionRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create training session<br/>
        /// Creates a training session and returns its details.
        /// </summary>
        /// <param name="resumeFromCheckpointId">
        /// Checkpoint ID to resume from<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="resumeFromHfCheckpoint">
        /// HuggingFace repo (or hf://) to resume model weights from. Accepts either a full model or a PEFT adapter directory. Mutually exclusive with resume_from_checkpoint_id.<br/>
        /// Example: your-org/llama-3-8b-finetuned
        /// </param>
        /// <param name="loraConfig">
        /// LoRA adapter configuration for the session
        /// </param>
        /// <param name="modelResourcesId">
        /// Model resource to attach the session to. The session runs on that resource's GPU pods.<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="displayName">
        /// Optional display name used to identify the training session<br/>
        /// Example: gsm8k-experiment-2
        /// </param>
        /// <param name="metadata">
        /// Optional auxiliary metadata to associate with the training session
        /// </param>
        /// <param name="loadOptimizer">
        /// Whether to restore optimizer state and step from a training checkpoint. Omitted or true restores them; false loads weights only with a fresh optimizer and step 0. Not valid for inference or HuggingFace checkpoints, which have no optimizer state.<br/>
        /// Example: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlTrainingSession> StartTrainingSessionAsync(
            string modelResourcesId,
            string? resumeFromCheckpointId = default,
            string? resumeFromHfCheckpoint = default,
            global::Together.RlLoraConfig? loraConfig = default,
            string? displayName = default,
            global::Together.RlTrainingSessionMetadata? metadata = default,
            bool? loadOptimizer = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}