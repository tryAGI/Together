
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
        /// Source of the judge model inference: - `serverless`: Together's shared serverless inference API. Default concurrency: 25 workers. - `dedicated`: A Together dedicated deployment endpoint. Default concurrency: 5 workers<br/>
        ///   (minimum enforced even if num_workers is set lower).<br/>
        /// - `external`: An external inference API (e.g. OpenAI, Anthropic, Google, OpenRouter).<br/>
        ///   Requires `external_api_token` and `external_base_url`. Default concurrency: 2 workers<br/>
        ///   for first-party APIs, 20 for proxy/aggregator endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.EvaluationJudgeModelConfigModelSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.EvaluationJudgeModelConfigModelSource ModelSource { get; set; }

        /// <summary>
        /// Bearer/API token for the external judge model provider. Required when model_source is 'external'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_api_token")]
        public string? ExternalApiToken { get; set; }

        /// <summary>
        /// Base URL of the external inference API for the judge. Must be OpenAI-compatible. Required when model_source is 'external'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_base_url")]
        public string? ExternalBaseUrl { get; set; }

        /// <summary>
        /// Number of concurrent inference workers for the judge. Overrides the source-specific default (serverless: 25, dedicated: 5, external: 2–20). For dedicated endpoints the value is clamped to a minimum of 5 regardless of what is set here.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_workers")]
        public int? NumWorkers { get; set; }

        /// <summary>
        /// Maximum number of tokens the judge model may generate. Defaults to 32768 if omitted. Set higher for reasoning judges (e.g. o-series, Gemini) that spend tokens on internal chain-of-thought before emitting the verdict JSON.<br/>
        /// Example: 8192
        /// </summary>
        /// <example>8192</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Sampling temperature for the judge model. Defaults to 0.05 if omitted.<br/>
        /// Example: 0.0
        /// </summary>
        /// <example>0.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

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
        /// Source of the judge model inference: - `serverless`: Together's shared serverless inference API. Default concurrency: 25 workers. - `dedicated`: A Together dedicated deployment endpoint. Default concurrency: 5 workers<br/>
        ///   (minimum enforced even if num_workers is set lower).<br/>
        /// - `external`: An external inference API (e.g. OpenAI, Anthropic, Google, OpenRouter).<br/>
        ///   Requires `external_api_token` and `external_base_url`. Default concurrency: 2 workers<br/>
        ///   for first-party APIs, 20 for proxy/aggregator endpoints.
        /// </param>
        /// <param name="externalApiToken">
        /// Bearer/API token for the external judge model provider. Required when model_source is 'external'.
        /// </param>
        /// <param name="externalBaseUrl">
        /// Base URL of the external inference API for the judge. Must be OpenAI-compatible. Required when model_source is 'external'.
        /// </param>
        /// <param name="numWorkers">
        /// Number of concurrent inference workers for the judge. Overrides the source-specific default (serverless: 25, dedicated: 5, external: 2–20). For dedicated endpoints the value is clamped to a minimum of 5 regardless of what is set here.<br/>
        /// Example: 5
        /// </param>
        /// <param name="maxTokens">
        /// Maximum number of tokens the judge model may generate. Defaults to 32768 if omitted. Set higher for reasoning judges (e.g. o-series, Gemini) that spend tokens on internal chain-of-thought before emitting the verdict JSON.<br/>
        /// Example: 8192
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature for the judge model. Defaults to 0.05 if omitted.<br/>
        /// Example: 0.0
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
            int? numWorkers,
            int? maxTokens,
            double? temperature)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.SystemTemplate = systemTemplate ?? throw new global::System.ArgumentNullException(nameof(systemTemplate));
            this.ModelSource = modelSource;
            this.ExternalApiToken = externalApiToken;
            this.ExternalBaseUrl = externalBaseUrl;
            this.NumWorkers = numWorkers;
            this.MaxTokens = maxTokens;
            this.Temperature = temperature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationJudgeModelConfig" /> class.
        /// </summary>
        public EvaluationJudgeModelConfig()
        {
        }

    }
}