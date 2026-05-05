
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluationJudgeModelConfig
    {
        /// <summary>
        /// Name of the judge model<br/>
        /// Example: Qwen/Qwen3.5-9B
        /// </summary>
        /// <example>Qwen/Qwen3.5-9B</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// System prompt template for the judge<br/>
        /// Example: Imagine you are a helpful assistant
        /// </summary>
        /// <example>Imagine you are a helpful assistant</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_template")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SystemTemplate { get; set; }

        /// <summary>
        /// Source of the judge model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.EvaluationJudgeModelConfigModelSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.EvaluationJudgeModelConfigModelSource ModelSource { get; set; }

        /// <summary>
        /// Bearer/API token for external judge models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_api_token")]
        public string? ExternalApiToken { get; set; }

        /// <summary>
        /// Base URL for external judge models. Must be OpenAI-compatible base URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_base_url")]
        public string? ExternalBaseUrl { get; set; }

        /// <summary>
        /// Number of concurrent workers for inference requests. Overrides the default concurrency for this model. Useful for tuning throughput when using proxy endpoints (e.g. OpenRouter) or rate-limited external APIs.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_workers")]
        public int? NumWorkers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationJudgeModelConfig" /> class.
        /// </summary>
        /// <param name="model">
        /// Name of the judge model<br/>
        /// Example: Qwen/Qwen3.5-9B
        /// </param>
        /// <param name="systemTemplate">
        /// System prompt template for the judge<br/>
        /// Example: Imagine you are a helpful assistant
        /// </param>
        /// <param name="modelSource">
        /// Source of the judge model.
        /// </param>
        /// <param name="externalApiToken">
        /// Bearer/API token for external judge models.
        /// </param>
        /// <param name="externalBaseUrl">
        /// Base URL for external judge models. Must be OpenAI-compatible base URL.
        /// </param>
        /// <param name="numWorkers">
        /// Number of concurrent workers for inference requests. Overrides the default concurrency for this model. Useful for tuning throughput when using proxy endpoints (e.g. OpenRouter) or rate-limited external APIs.<br/>
        /// Example: 5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationJudgeModelConfig(
            string model,
            string systemTemplate,
            global::Together.EvaluationJudgeModelConfigModelSource modelSource,
            string? externalApiToken,
            string? externalBaseUrl,
            int? numWorkers)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.SystemTemplate = systemTemplate ?? throw new global::System.ArgumentNullException(nameof(systemTemplate));
            this.ModelSource = modelSource;
            this.ExternalApiToken = externalApiToken;
            this.ExternalBaseUrl = externalBaseUrl;
            this.NumWorkers = numWorkers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationJudgeModelConfig" /> class.
        /// </summary>
        public EvaluationJudgeModelConfig()
        {
        }
    }
}