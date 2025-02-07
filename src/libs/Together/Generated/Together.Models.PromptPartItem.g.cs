
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptPartItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        public global::Together.LogprobsPart? Logprobs { get; set; }

        /// <summary>
        /// Example: &lt;s&gt;[INST] What is the capital of France? [/INST]
        /// </summary>
        /// <example>&lt;s&gt;[INST] What is the capital of France? [/INST]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptPartItem" /> class.
        /// </summary>
        /// <param name="logprobs"></param>
        /// <param name="text">
        /// Example: &lt;s&gt;[INST] What is the capital of France? [/INST]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptPartItem(
            global::Together.LogprobsPart? logprobs,
            string? text)
        {
            this.Logprobs = logprobs;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptPartItem" /> class.
        /// </summary>
        public PromptPartItem()
        {
        }
    }
}