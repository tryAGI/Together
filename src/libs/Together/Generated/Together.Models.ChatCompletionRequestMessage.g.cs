
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionRequestMessage
    {
        /// <summary>
        /// The content of the message, which can either be a simple string or a structured format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Together.ChatCompletionRequestMessageContentVariant2Item>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.OneOf<string, global::System.Collections.Generic.IList<global::Together.ChatCompletionRequestMessageContentVariant2Item>> Content { get; set; }

        /// <summary>
        /// The role of the messages author. Choice between: system, user, or assistant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.ChatCompletionRequestMessageRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.ChatCompletionRequestMessageRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// The content of the message, which can either be a simple string or a structured format.
        /// </param>
        /// <param name="role">
        /// The role of the messages author. Choice between: system, user, or assistant.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChatCompletionRequestMessage(
            global::Together.OneOf<string, global::System.Collections.Generic.IList<global::Together.ChatCompletionRequestMessageContentVariant2Item>> content,
            global::Together.ChatCompletionRequestMessageRole role)
        {
            this.Content = content;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessage" /> class.
        /// </summary>
        public ChatCompletionRequestMessage()
        {
        }
    }
}