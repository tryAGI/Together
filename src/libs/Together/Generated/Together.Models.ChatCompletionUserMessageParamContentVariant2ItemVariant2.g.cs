
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionUserMessageParamContentVariant2ItemVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public global::Together.ChatCompletionUserMessageParamContentVariant2ItemVariant2ImageUrl? ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.ChatCompletionUserMessageParamContentVariant2ItemVariant2TypeJsonConverter))]
        public global::Together.ChatCompletionUserMessageParamContentVariant2ItemVariant2Type? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionUserMessageParamContentVariant2ItemVariant2" /> class.
        /// </summary>
        /// <param name="imageUrl"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionUserMessageParamContentVariant2ItemVariant2(
            global::Together.ChatCompletionUserMessageParamContentVariant2ItemVariant2ImageUrl? imageUrl,
            global::Together.ChatCompletionUserMessageParamContentVariant2ItemVariant2Type? type)
        {
            this.ImageUrl = imageUrl;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionUserMessageParamContentVariant2ItemVariant2" /> class.
        /// </summary>
        public ChatCompletionUserMessageParamContentVariant2ItemVariant2()
        {
        }
    }
}