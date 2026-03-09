
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluationJudgeModelConfig
    {
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
        /// Name of the judge model<br/>
        /// Example: meta-llama/Llama-3-70B-Instruct-Turbo
        /// </summary>
        /// <example>meta-llama/Llama-3-70B-Instruct-Turbo</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Model { get; set; } = default!;

        /// <summary>
        /// Source of the judge model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.EvaluationJudgeModelConfigModelSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Together.EvaluationJudgeModelConfigModelSource ModelSource { get; set; } = default!;

        /// <summary>
        /// System prompt template for the judge<br/>
        /// Example: Imagine you are a helpful assistant
        /// </summary>
        /// <example>Imagine you are a helpful assistant</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_template")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string SystemTemplate { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationJudgeModelConfig" /> class.
        /// </summary>
        /// <param name="externalApiToken">
        /// Bearer/API token for external judge models.
        /// </param>
        /// <param name="externalBaseUrl">
        /// Base URL for external judge models. Must be OpenAI-compatible base URL.
        /// </param>
        /// <param name="model">
        /// Name of the judge model<br/>
        /// Example: meta-llama/Llama-3-70B-Instruct-Turbo
        /// </param>
        /// <param name="modelSource">
        /// Source of the judge model.
        /// </param>
        /// <param name="systemTemplate">
        /// System prompt template for the judge<br/>
        /// Example: Imagine you are a helpful assistant
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationJudgeModelConfig(
            string model,
            global::Together.EvaluationJudgeModelConfigModelSource modelSource,
            string systemTemplate,
            string? externalApiToken,
            string? externalBaseUrl)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.ModelSource = modelSource;
            this.SystemTemplate = systemTemplate ?? throw new global::System.ArgumentNullException(nameof(systemTemplate));
            this.ExternalApiToken = externalApiToken;
            this.ExternalBaseUrl = externalBaseUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationJudgeModelConfig" /> class.
        /// </summary>
        public EvaluationJudgeModelConfig()
        {
        }
    }
}