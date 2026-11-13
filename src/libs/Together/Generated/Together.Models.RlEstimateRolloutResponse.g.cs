
#nullable enable

namespace Together
{
    /// <summary>
    /// Estimated rollout elapsed time, tokens, throughput, GPU-hours, and price
    /// </summary>
    public sealed partial class RlEstimateRolloutResponse
    {
        /// <summary>
        /// Estimated time until all rollout episodes finish, in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wall_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double WallSeconds { get; set; }

        /// <summary>
        /// Generator GPUs across all replicas times wall time, in GPU-hours.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allocated_gpu_hours")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AllocatedGpuHours { get; set; }

        /// <summary>
        /// Prompt tokens submitted across all turns. JSON encodes this count as a decimal string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submitted_prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<string, int?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.OneOf<string, int?> SubmittedPromptTokens { get; set; }

        /// <summary>
        /// Generated output tokens across all turns. JSON encodes this count as a decimal string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_tokens")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<string, int?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.OneOf<string, int?> GeneratedTokens { get; set; }

        /// <summary>
        /// generated_tokens divided by wall_seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective_decode_tokens_per_second")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EffectiveDecodeTokensPerSecond { get; set; }

        /// <summary>
        /// Effective distinct_prompts_per_replica (Q) for the largest concurrent batch of one replica.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective_distinct_prompts_per_replica")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EffectiveDistinctPromptsPerReplica { get; set; }

        /// <summary>
        /// Effective episodes_per_prompt (G) for the largest concurrent batch of one replica.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective_episodes_per_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EffectiveEpisodesPerPrompt { get; set; }

        /// <summary>
        /// Effective shared_prefix_tokens (H).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective_shared_prefix_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EffectiveSharedPrefixTokens { get; set; }

        /// <summary>
        /// Whether the estimate is for a LoRA resource (true) or a full-weight resource (false).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool LoraEnabled { get; set; }

        /// <summary>
        /// GPUs of the whole model resource, trainer and generator, times wall time, in GPU-hours. A model resource is billed for all of its GPUs while the rollouts run. An approximation measured on single-wave rollouts (concurrency equal to episodes) of up to four turns on one generator replica: actual usage can be up to about 45% higher when episodes share a prompt, and about 20% higher or lower otherwise. Longer multi-turn rollouts with distinct prompts can take longer than estimated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billed_gpu_hours")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double BilledGpuHours { get; set; }

        /// <summary>
        /// Estimated on-demand price of the rollouts: billed_gpu_hours times the GPU type's list price per GPU-hour, the rate the model resource cost estimate uses. An approximation that inherits the uncertainty of billed_gpu_hours; it is not a quote.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_price")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EstimatedPrice { get; set; }

        /// <summary>
        /// Currency of estimated_price.<br/>
        /// Example: USD
        /// </summary>
        /// <example>USD</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Currency { get; set; }

        /// <summary>
        /// submitted_prompt_tokens divided by wall_seconds, counting prompt tokens served from the prompt cache.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective_prefill_tokens_per_second")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EffectivePrefillTokensPerSecond { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlEstimateRolloutResponse" /> class.
        /// </summary>
        /// <param name="wallSeconds">
        /// Estimated time until all rollout episodes finish, in seconds.
        /// </param>
        /// <param name="allocatedGpuHours">
        /// Generator GPUs across all replicas times wall time, in GPU-hours.
        /// </param>
        /// <param name="submittedPromptTokens">
        /// Prompt tokens submitted across all turns. JSON encodes this count as a decimal string.
        /// </param>
        /// <param name="generatedTokens">
        /// Generated output tokens across all turns. JSON encodes this count as a decimal string.
        /// </param>
        /// <param name="effectiveDecodeTokensPerSecond">
        /// generated_tokens divided by wall_seconds.
        /// </param>
        /// <param name="effectiveDistinctPromptsPerReplica">
        /// Effective distinct_prompts_per_replica (Q) for the largest concurrent batch of one replica.
        /// </param>
        /// <param name="effectiveEpisodesPerPrompt">
        /// Effective episodes_per_prompt (G) for the largest concurrent batch of one replica.
        /// </param>
        /// <param name="effectiveSharedPrefixTokens">
        /// Effective shared_prefix_tokens (H).
        /// </param>
        /// <param name="loraEnabled">
        /// Whether the estimate is for a LoRA resource (true) or a full-weight resource (false).
        /// </param>
        /// <param name="billedGpuHours">
        /// GPUs of the whole model resource, trainer and generator, times wall time, in GPU-hours. A model resource is billed for all of its GPUs while the rollouts run. An approximation measured on single-wave rollouts (concurrency equal to episodes) of up to four turns on one generator replica: actual usage can be up to about 45% higher when episodes share a prompt, and about 20% higher or lower otherwise. Longer multi-turn rollouts with distinct prompts can take longer than estimated.
        /// </param>
        /// <param name="estimatedPrice">
        /// Estimated on-demand price of the rollouts: billed_gpu_hours times the GPU type's list price per GPU-hour, the rate the model resource cost estimate uses. An approximation that inherits the uncertainty of billed_gpu_hours; it is not a quote.
        /// </param>
        /// <param name="currency">
        /// Currency of estimated_price.<br/>
        /// Example: USD
        /// </param>
        /// <param name="effectivePrefillTokensPerSecond">
        /// submitted_prompt_tokens divided by wall_seconds, counting prompt tokens served from the prompt cache.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlEstimateRolloutResponse(
            double wallSeconds,
            double allocatedGpuHours,
            global::Together.OneOf<string, int?> submittedPromptTokens,
            global::Together.OneOf<string, int?> generatedTokens,
            double effectiveDecodeTokensPerSecond,
            int effectiveDistinctPromptsPerReplica,
            int effectiveEpisodesPerPrompt,
            int effectiveSharedPrefixTokens,
            bool loraEnabled,
            double billedGpuHours,
            double estimatedPrice,
            string currency,
            double effectivePrefillTokensPerSecond)
        {
            this.WallSeconds = wallSeconds;
            this.AllocatedGpuHours = allocatedGpuHours;
            this.SubmittedPromptTokens = submittedPromptTokens;
            this.GeneratedTokens = generatedTokens;
            this.EffectiveDecodeTokensPerSecond = effectiveDecodeTokensPerSecond;
            this.EffectiveDistinctPromptsPerReplica = effectiveDistinctPromptsPerReplica;
            this.EffectiveEpisodesPerPrompt = effectiveEpisodesPerPrompt;
            this.EffectiveSharedPrefixTokens = effectiveSharedPrefixTokens;
            this.LoraEnabled = loraEnabled;
            this.BilledGpuHours = billedGpuHours;
            this.EstimatedPrice = estimatedPrice;
            this.Currency = currency ?? throw new global::System.ArgumentNullException(nameof(currency));
            this.EffectivePrefillTokensPerSecond = effectivePrefillTokensPerSecond;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlEstimateRolloutResponse" /> class.
        /// </summary>
        public RlEstimateRolloutResponse()
        {
        }

    }
}