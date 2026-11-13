#nullable enable

namespace Together
{
    public partial interface IRlClient
    {
        /// <summary>
        /// Estimate rollout time and price<br/>
        /// Estimates rollout-only time, generator GPU-hours, billed GPU-hours of the whole model resource, and price for a supported model and GPU type. Each generator replica may contain several inference servers or span multiple nodes. Assumes identical episodes, exact reuse of generated tokens between turns, turns that start together within a replica, no environment delay, and no concurrent computation of the same initial prompt. Prompt-cache reuse and capacity misses are approximate, especially for multi-turn episodes. Rates are measured in the training mode reported by lora_enabled. Cache-transfer and request-preemption delays are not included, so long multi-turn rollouts with distinct prompts can take longer than estimated.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlEstimateRolloutResponse> EstimateRolloutAsync(

            global::Together.RlEstimateRolloutRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Estimate rollout time and price<br/>
        /// Estimates rollout-only time, generator GPU-hours, billed GPU-hours of the whole model resource, and price for a supported model and GPU type. Each generator replica may contain several inference servers or span multiple nodes. Assumes identical episodes, exact reuse of generated tokens between turns, turns that start together within a replica, no environment delay, and no concurrent computation of the same initial prompt. Prompt-cache reuse and capacity misses are approximate, especially for multi-turn episodes. Rates are measured in the training mode reported by lora_enabled. Cache-transfer and request-preemption delays are not included, so long multi-turn rollouts with distinct prompts can take longer than estimated.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.RlEstimateRolloutResponse>> EstimateRolloutAsResponseAsync(

            global::Together.RlEstimateRolloutRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Estimate rollout time and price<br/>
        /// Estimates rollout-only time, generator GPU-hours, billed GPU-hours of the whole model resource, and price for a supported model and GPU type. Each generator replica may contain several inference servers or span multiple nodes. Assumes identical episodes, exact reuse of generated tokens between turns, turns that start together within a replica, no environment delay, and no concurrent computation of the same initial prompt. Prompt-cache reuse and capacity misses are approximate, especially for multi-turn episodes. Rates are measured in the training mode reported by lora_enabled. Cache-transfer and request-preemption delays are not included, so long multi-turn rollouts with distinct prompts can take longer than estimated.
        /// </summary>
        /// <param name="episodes">
        /// Total number of episodes (N). Must be between 1 and 10000000.
        /// </param>
        /// <param name="concurrency">
        /// Maximum concurrent episodes across all generator replicas (B). Must be positive.
        /// </param>
        /// <param name="promptTokens">
        /// Initial prompt tokens per episode (P). Must be positive.
        /// </param>
        /// <param name="turns">
        /// Assistant turns per episode (T). Must be between 1 and 1024.
        /// </param>
        /// <param name="addedTokensPerTurn">
        /// Tokens added before each later turn (K), including the prior generated tokens followed by environment tokens. Must be at least generated_tokens_per_turn.
        /// </param>
        /// <param name="generatedTokensPerTurn">
        /// Tokens generated on each turn (O). Must be positive.
        /// </param>
        /// <param name="distinctPromptsPerReplica">
        /// Number of distinct initial prompts among the concurrent episodes of one replica (Q). When episodes_per_prompt is given, defaults to ceil(concurrent episodes / G). Otherwise defaults to 1 when shared_prefix_tokens equals prompt_tokens, and to the concurrent episodes per replica when it does not. Must be 1 when shared_prefix_tokens equals prompt_tokens.
        /// </param>
        /// <param name="episodesPerPrompt">
        /// Maximum sibling episodes per initial prompt (G). When distinct_prompts_per_replica is given, defaults to ceil(concurrent episodes / Q). Otherwise defaults to the concurrent episodes per replica when shared_prefix_tokens equals prompt_tokens, and to 1 when it does not. When shared_prefix_tokens equals prompt_tokens, must be at least the concurrent episodes per replica.
        /// </param>
        /// <param name="sharedPrefixTokens">
        /// Leading tokens shared by all distinct initial prompts (H). Defaults to 0; cannot exceed prompt_tokens.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="baseModel">
        /// Base model to estimate. The model, GPU type, and training mode must support rollout estimates.<br/>
        /// Example: zai-org/GLM-5.3
        /// </param>
        /// <param name="computeConfig">
        /// Compute layout to estimate, as for a model resource. Omitted fields use the model's default GPU type and one generator replica (D); num_generator_replicas must be positive.
        /// </param>
        /// <param name="loraEnabled">
        /// Whether to estimate a resource that hosts LoRA sessions (true, default) or a single full-weight session (false), as in a model resource. The model and GPU type must support rollout estimates in this mode.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlEstimateRolloutResponse> EstimateRolloutAsync(
            int episodes,
            int concurrency,
            int promptTokens,
            int turns,
            int addedTokensPerTurn,
            int generatedTokensPerTurn,
            string baseModel,
            int? distinctPromptsPerReplica = default,
            int? episodesPerPrompt = default,
            int? sharedPrefixTokens = default,
            global::Together.RlComputeConfigCreateRequest? computeConfig = default,
            bool? loraEnabled = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}