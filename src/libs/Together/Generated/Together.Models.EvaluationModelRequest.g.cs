
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluationModelRequest
    {
        /// <summary>
        /// Bearer/API token for external models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_api_token")]
        public string? ExternalApiToken { get; set; }

        /// <summary>
        /// Base URL for external models. Must be OpenAI-compatible base URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_base_url")]
        public string? ExternalBaseUrl { get; set; }

        /// <summary>
        /// Input prompt template<br/>
        /// Example: Please classify {{prompt}} based on the labels below
        /// </summary>
        /// <example>Please classify {{prompt}} based on the labels below</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_template")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InputTemplate { get; set; }

        /// <summary>
        /// Maximum number of tokens to generate<br/>
        /// Example: 512
        /// </summary>
        /// <example>512</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxTokens { get; set; }

        /// <summary>
        /// Name of the model to evaluate<br/>
        /// Example: meta-llama/Llama-3-70B-Instruct-Turbo
        /// </summary>
        /// <example>meta-llama/Llama-3-70B-Instruct-Turbo</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Source of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.EvaluationModelRequestModelSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.EvaluationModelRequestModelSource ModelSource { get; set; }

        /// <summary>
        /// System prompt template<br/>
        /// Example: Imagine you are helpful assistant
        /// </summary>
        /// <example>Imagine you are helpful assistant</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_template")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SystemTemplate { get; set; }

        /// <summary>
        /// Sampling temperature<br/>
        /// Example: 0.7
        /// </summary>
        /// <example>0.7</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float Temperature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationModelRequest" /> class.
        /// </summary>
        /// <param name="externalApiToken">
        /// Bearer/API token for external models.
        /// </param>
        /// <param name="externalBaseUrl">
        /// Base URL for external models. Must be OpenAI-compatible base URL
        /// </param>
        /// <param name="inputTemplate">
        /// Input prompt template<br/>
        /// Example: Please classify {{prompt}} based on the labels below
        /// </param>
        /// <param name="maxTokens">
        /// Maximum number of tokens to generate<br/>
        /// Example: 512
        /// </param>
        /// <param name="model">
        /// Name of the model to evaluate<br/>
        /// Example: meta-llama/Llama-3-70B-Instruct-Turbo
        /// </param>
        /// <param name="modelSource">
        /// Source of the model.
        /// </param>
        /// <param name="systemTemplate">
        /// System prompt template<br/>
        /// Example: Imagine you are helpful assistant
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature<br/>
        /// Example: 0.7
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationModelRequest(
            string inputTemplate,
            int maxTokens,
            string model,
            global::Together.EvaluationModelRequestModelSource modelSource,
            string systemTemplate,
            float temperature,
            string? externalApiToken,
            string? externalBaseUrl)
        {
            this.InputTemplate = inputTemplate ?? throw new global::System.ArgumentNullException(nameof(inputTemplate));
            this.MaxTokens = maxTokens;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.ModelSource = modelSource;
            this.SystemTemplate = systemTemplate ?? throw new global::System.ArgumentNullException(nameof(systemTemplate));
            this.Temperature = temperature;
            this.ExternalApiToken = externalApiToken;
            this.ExternalBaseUrl = externalBaseUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationModelRequest" /> class.
        /// </summary>
        public EvaluationModelRequest()
        {
        }
    }
}