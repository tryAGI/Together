
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChatCompletionAssistantMessageParam
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.ChatCompletionAssistantMessageParamRoleJsonConverter))]
        public global::Together.ChatCompletionAssistantMessageParamRole Role { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::Together.ToolChoice2>? ToolCalls { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_call")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::Together.ChatCompletionAssistantMessageParamFunctionCall? FunctionCall { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public string? Reasoning { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_content")]
        public string? ReasoningContent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionAssistantMessageParam" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="role"></param>
        /// <param name="name"></param>
        /// <param name="toolCalls"></param>
        /// <param name="reasoning"></param>
        /// <param name="reasoningContent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionAssistantMessageParam(
            string? content,
            global::Together.ChatCompletionAssistantMessageParamRole role,
            string? name,
            global::System.Collections.Generic.IList<global::Together.ToolChoice2>? toolCalls,
            string? reasoning,
            string? reasoningContent)
        {
            this.Content = content;
            this.Role = role;
            this.Name = name;
            this.ToolCalls = toolCalls;
            this.Reasoning = reasoning;
            this.ReasoningContent = reasoningContent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionAssistantMessageParam" /> class.
        /// </summary>
        public ChatCompletionAssistantMessageParam()
        {
        }

    }
}