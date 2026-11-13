
#nullable enable

namespace Together
{
    /// <summary>
    /// Episode shape, model, GPU type, and concurrency for a rollout-only estimate
    /// </summary>
    public sealed partial class RlEstimateRolloutRequest
    {
        /// <summary>
        /// Total number of episodes (N). Must be between 1 and 10000000.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("episodes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Episodes { get; set; }

        /// <summary>
        /// Maximum concurrent episodes across all generator replicas (B). Must be positive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Concurrency { get; set; }

        /// <summary>
        /// Initial prompt tokens per episode (P). Must be positive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PromptTokens { get; set; }

        /// <summary>
        /// Assistant turns per episode (T). Must be between 1 and 1024.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turns")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Turns { get; set; }

        /// <summary>
        /// Tokens added before each later turn (K), including the prior generated tokens followed by environment tokens. Must be at least generated_tokens_per_turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added_tokens_per_turn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AddedTokensPerTurn { get; set; }

        /// <summary>
        /// Tokens generated on each turn (O). Must be positive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_tokens_per_turn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int GeneratedTokensPerTurn { get; set; }

        /// <summary>
        /// Number of distinct initial prompts among the concurrent episodes of one replica (Q). When episodes_per_prompt is given, defaults to ceil(concurrent episodes / G). Otherwise defaults to 1 when shared_prefix_tokens equals prompt_tokens, and to the concurrent episodes per replica when it does not. Must be 1 when shared_prefix_tokens equals prompt_tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_prompts_per_replica")]
        public int? DistinctPromptsPerReplica { get; set; }

        /// <summary>
        /// Maximum sibling episodes per initial prompt (G). When distinct_prompts_per_replica is given, defaults to ceil(concurrent episodes / Q). Otherwise defaults to the concurrent episodes per replica when shared_prefix_tokens equals prompt_tokens, and to 1 when it does not. When shared_prefix_tokens equals prompt_tokens, must be at least the concurrent episodes per replica.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("episodes_per_prompt")]
        public int? EpisodesPerPrompt { get; set; }

        /// <summary>
        /// Leading tokens shared by all distinct initial prompts (H). Defaults to 0; cannot exceed prompt_tokens.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shared_prefix_tokens")]
        public int? SharedPrefixTokens { get; set; }

        /// <summary>
        /// Base model to estimate. The model, GPU type, and training mode must support rollout estimates.<br/>
        /// Example: zai-org/GLM-5.3
        /// </summary>
        /// <example>zai-org/GLM-5.3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseModel { get; set; }

        /// <summary>
        /// Compute layout to estimate, as for a model resource. Omitted fields use the model's default GPU type and one generator replica (D); num_generator_replicas must be positive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compute_config")]
        public global::Together.RlComputeConfigCreateRequest? ComputeConfig { get; set; }

        /// <summary>
        /// Whether to estimate a resource that hosts LoRA sessions (true, default) or a single full-weight session (false), as in a model resource. The model and GPU type must support rollout estimates in this mode.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora_enabled")]
        public bool? LoraEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlEstimateRolloutRequest" /> class.
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
        /// <param name="baseModel">
        /// Base model to estimate. The model, GPU type, and training mode must support rollout estimates.<br/>
        /// Example: zai-org/GLM-5.3
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
        /// <param name="computeConfig">
        /// Compute layout to estimate, as for a model resource. Omitted fields use the model's default GPU type and one generator replica (D); num_generator_replicas must be positive.
        /// </param>
        /// <param name="loraEnabled">
        /// Whether to estimate a resource that hosts LoRA sessions (true, default) or a single full-weight session (false), as in a model resource. The model and GPU type must support rollout estimates in this mode.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlEstimateRolloutRequest(
            int episodes,
            int concurrency,
            int promptTokens,
            int turns,
            int addedTokensPerTurn,
            int generatedTokensPerTurn,
            string baseModel,
            int? distinctPromptsPerReplica,
            int? episodesPerPrompt,
            int? sharedPrefixTokens,
            global::Together.RlComputeConfigCreateRequest? computeConfig,
            bool? loraEnabled)
        {
            this.Episodes = episodes;
            this.Concurrency = concurrency;
            this.PromptTokens = promptTokens;
            this.Turns = turns;
            this.AddedTokensPerTurn = addedTokensPerTurn;
            this.GeneratedTokensPerTurn = generatedTokensPerTurn;
            this.DistinctPromptsPerReplica = distinctPromptsPerReplica;
            this.EpisodesPerPrompt = episodesPerPrompt;
            this.SharedPrefixTokens = sharedPrefixTokens;
            this.BaseModel = baseModel ?? throw new global::System.ArgumentNullException(nameof(baseModel));
            this.ComputeConfig = computeConfig;
            this.LoraEnabled = loraEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlEstimateRolloutRequest" /> class.
        /// </summary>
        public RlEstimateRolloutRequest()
        {
        }

    }
}