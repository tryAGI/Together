
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CompletionTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PromptTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageData" /> class.
        /// </summary>
        /// <param name="completionTokens"></param>
        /// <param name="promptTokens"></param>
        /// <param name="totalTokens"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UsageData(
            int completionTokens,
            int promptTokens,
            int totalTokens)
        {
            this.CompletionTokens = completionTokens;
            this.PromptTokens = promptTokens;
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageData" /> class.
        /// </summary>
        public UsageData()
        {
        }
    }
}