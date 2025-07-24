
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluationModelRequest
    {
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
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

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
        /// Example: 0.7F
        /// </summary>
        /// <example>0.7F</example>
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
        /// <param name="inputTemplate">
        /// Input prompt template<br/>
        /// Example: Please classify {{prompt}} based on the labels below
        /// </param>
        /// <param name="maxTokens">
        /// Maximum number of tokens to generate<br/>
        /// Example: 512
        /// </param>
        /// <param name="modelName">
        /// Name of the model to evaluate<br/>
        /// Example: meta-llama/Llama-3-70B-Instruct-Turbo
        /// </param>
        /// <param name="systemTemplate">
        /// System prompt template<br/>
        /// Example: Imagine you are helpful assistant
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature<br/>
        /// Example: 0.7F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationModelRequest(
            string inputTemplate,
            int maxTokens,
            string modelName,
            string systemTemplate,
            float temperature)
        {
            this.InputTemplate = inputTemplate ?? throw new global::System.ArgumentNullException(nameof(inputTemplate));
            this.MaxTokens = maxTokens;
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.SystemTemplate = systemTemplate ?? throw new global::System.ArgumentNullException(nameof(systemTemplate));
            this.Temperature = temperature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationModelRequest" /> class.
        /// </summary>
        public EvaluationModelRequest()
        {
        }
    }
}