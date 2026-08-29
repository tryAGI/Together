
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EvaluationModelRequest
    {
        /// <summary>
        /// Name of the model to evaluate<br/>
        /// Example: Qwen/Qwen3.5-9B
        /// </summary>
        /// <example>Qwen/Qwen3.5-9B</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Maximum number of tokens to generate.<br/>
        /// Example: 512
        /// </summary>
        /// <example>512</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxTokens { get; set; }

        /// <summary>
        /// Sampling temperature for generation.<br/>
        /// Example: 0.7
        /// </summary>
        /// <example>0.7</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Temperature { get; set; }

        /// <summary>
        /// System prompt template. Supports Jinja2 variables referencing dataset columns.<br/>
        /// Example: You are a helpful assistant.
        /// </summary>
        /// <example>You are a helpful assistant.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_template")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SystemTemplate { get; set; }

        /// <summary>
        /// User message template. Supports Jinja2 variables referencing dataset columns.<br/>
        /// Example: Please answer the following question: {{ question }}
        /// </summary>
        /// <example>Please answer the following question: {{ question }}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_template")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InputTemplate { get; set; }

        /// <summary>
        /// Source of the model inference: - `serverless`: Together's shared serverless inference API. Default concurrency: 25 workers. - `dedicated`: A Together dedicated deployment endpoint. Default concurrency: 5 workers<br/>
        ///   (minimum enforced even if num_workers is set lower). Authentication uses the requesting<br/>
        ///   user's Together API token automatically.<br/>
        /// - `external`: An external inference API (e.g. OpenAI, Anthropic, Google, OpenRouter).<br/>
        ///   Requires `external_api_token` and `external_base_url`. Default concurrency: 2 workers<br/>
        ///   for first-party APIs (OpenAI, Anthropic, Google), 20 for proxy/aggregator endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.EvaluationModelRequestModelSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.EvaluationModelRequestModelSource ModelSource { get; set; }

        /// <summary>
        /// Bearer/API token for the external model provider. Required when model_source is 'external'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_api_token")]
        public string? ExternalApiToken { get; set; }

        /// <summary>
        /// Base URL of the external inference API. Must be OpenAI-compatible. Required when model_source is 'external'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_base_url")]
        public string? ExternalBaseUrl { get; set; }

        /// <summary>
        /// Number of concurrent inference workers. Overrides the source-specific default (serverless: 25, dedicated: 5, external: 2–20). For dedicated endpoints the value is clamped to a minimum of 5 regardless of what is set here.<br/>
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
        /// Initializes a new instance of the <see cref="EvaluationModelRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// Name of the model to evaluate<br/>
        /// Example: Qwen/Qwen3.5-9B
        /// </param>
        /// <param name="maxTokens">
        /// Maximum number of tokens to generate.<br/>
        /// Example: 512
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature for generation.<br/>
        /// Example: 0.7
        /// </param>
        /// <param name="systemTemplate">
        /// System prompt template. Supports Jinja2 variables referencing dataset columns.<br/>
        /// Example: You are a helpful assistant.
        /// </param>
        /// <param name="inputTemplate">
        /// User message template. Supports Jinja2 variables referencing dataset columns.<br/>
        /// Example: Please answer the following question: {{ question }}
        /// </param>
        /// <param name="modelSource">
        /// Source of the model inference: - `serverless`: Together's shared serverless inference API. Default concurrency: 25 workers. - `dedicated`: A Together dedicated deployment endpoint. Default concurrency: 5 workers<br/>
        ///   (minimum enforced even if num_workers is set lower). Authentication uses the requesting<br/>
        ///   user's Together API token automatically.<br/>
        /// - `external`: An external inference API (e.g. OpenAI, Anthropic, Google, OpenRouter).<br/>
        ///   Requires `external_api_token` and `external_base_url`. Default concurrency: 2 workers<br/>
        ///   for first-party APIs (OpenAI, Anthropic, Google), 20 for proxy/aggregator endpoints.
        /// </param>
        /// <param name="externalApiToken">
        /// Bearer/API token for the external model provider. Required when model_source is 'external'.
        /// </param>
        /// <param name="externalBaseUrl">
        /// Base URL of the external inference API. Must be OpenAI-compatible. Required when model_source is 'external'.
        /// </param>
        /// <param name="numWorkers">
        /// Number of concurrent inference workers. Overrides the source-specific default (serverless: 25, dedicated: 5, external: 2–20). For dedicated endpoints the value is clamped to a minimum of 5 regardless of what is set here.<br/>
        /// Example: 5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationModelRequest(
            string model,
            int maxTokens,
            double temperature,
            string systemTemplate,
            string inputTemplate,
            global::Together.EvaluationModelRequestModelSource modelSource,
            string? externalApiToken,
            string? externalBaseUrl,
            int? numWorkers)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.MaxTokens = maxTokens;
            this.Temperature = temperature;
            this.SystemTemplate = systemTemplate ?? throw new global::System.ArgumentNullException(nameof(systemTemplate));
            this.InputTemplate = inputTemplate ?? throw new global::System.ArgumentNullException(nameof(inputTemplate));
            this.ModelSource = modelSource;
            this.ExternalApiToken = externalApiToken;
            this.ExternalBaseUrl = externalBaseUrl;
            this.NumWorkers = numWorkers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationModelRequest" /> class.
        /// </summary>
        public EvaluationModelRequest()
        {
        }

    }
}