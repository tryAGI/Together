
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionSystemMessageParam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.ChatCompletionSystemMessageParamRoleJsonConverter))]
        public global::Together.ChatCompletionSystemMessageParamRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionSystemMessageParam" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="name"></param>
        /// <param name="role"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChatCompletionSystemMessageParam(
            string content,
            string? name,
            global::Together.ChatCompletionSystemMessageParamRole role)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Name = name;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionSystemMessageParam" /> class.
        /// </summary>
        public ChatCompletionSystemMessageParam()
        {
        }
    }
}