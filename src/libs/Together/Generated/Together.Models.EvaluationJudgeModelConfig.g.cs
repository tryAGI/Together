
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
        /// Example: meta-llama/Llama-3-70B-Instruct-Turbo
        /// </summary>
        /// <example>meta-llama/Llama-3-70B-Instruct-Turbo</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// System prompt template for the judge<br/>
        /// Example: Imagine you are a helpful assistant
        /// </summary>
        /// <example>Imagine you are a helpful assistant</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_template")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SystemTemplate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationJudgeModelConfig" /> class.
        /// </summary>
        /// <param name="modelName">
        /// Name of the judge model<br/>
        /// Example: meta-llama/Llama-3-70B-Instruct-Turbo
        /// </param>
        /// <param name="systemTemplate">
        /// System prompt template for the judge<br/>
        /// Example: Imagine you are a helpful assistant
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationJudgeModelConfig(
            string modelName,
            string systemTemplate)
        {
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.SystemTemplate = systemTemplate ?? throw new global::System.ArgumentNullException(nameof(systemTemplate));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationJudgeModelConfig" /> class.
        /// </summary>
        public EvaluationJudgeModelConfig()
        {
        }
    }
}