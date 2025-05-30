
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionUserMessageParam
    {
        /// <summary>
        /// The content of the message, which can either be a simple string or a structured format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Together.OneOf<global::Together.ChatCompletionUserMessageParamContentVariant2ItemVariant1, global::Together.ChatCompletionUserMessageParamContentVariant2ItemVariant2, global::Together.ChatCompletionUserMessageParamContentVariant2ItemVariant3>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.OneOf<string, global::System.Collections.Generic.IList<global::Together.OneOf<global::Together.ChatCompletionUserMessageParamContentVariant2ItemVariant1, global::Together.ChatCompletionUserMessageParamContentVariant2ItemVariant2, global::Together.ChatCompletionUserMessageParamContentVariant2ItemVariant3>>> Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.ChatCompletionUserMessageParamRoleJsonConverter))]
        public global::Together.ChatCompletionUserMessageParamRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionUserMessageParam" /> class.
        /// </summary>
        /// <param name="content">
        /// The content of the message, which can either be a simple string or a structured format.
        /// </param>
        /// <param name="name"></param>
        /// <param name="role"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionUserMessageParam(
            global::Together.OneOf<string, global::System.Collections.Generic.IList<global::Together.OneOf<global::Together.ChatCompletionUserMessageParamContentVariant2ItemVariant1, global::Together.ChatCompletionUserMessageParamContentVariant2ItemVariant2, global::Together.ChatCompletionUserMessageParamContentVariant2ItemVariant3>>> content,
            string? name,
            global::Together.ChatCompletionUserMessageParamRole role)
        {
            this.Content = content;
            this.Name = name;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionUserMessageParam" /> class.
        /// </summary>
        public ChatCompletionUserMessageParam()
        {
        }
    }
}