
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionChoiceDelta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_id")]
        public int? TokenId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.ChatCompletionChoiceDeltaRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.ChatCompletionChoiceDeltaRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

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
        public global::Together.ChatCompletionChoiceDeltaFunctionCall? FunctionCall { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public string? Reasoning { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChoiceDelta" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="tokenId"></param>
        /// <param name="content"></param>
        /// <param name="toolCalls"></param>
        /// <param name="reasoning"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionChoiceDelta(
            global::Together.ChatCompletionChoiceDeltaRole role,
            int? tokenId,
            string? content,
            global::System.Collections.Generic.IList<global::Together.ToolChoice2>? toolCalls,
            string? reasoning)
        {
            this.TokenId = tokenId;
            this.Role = role;
            this.Content = content;
            this.ToolCalls = toolCalls;
            this.Reasoning = reasoning;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChoiceDelta" /> class.
        /// </summary>
        public ChatCompletionChoiceDelta()
        {
        }
    }
}