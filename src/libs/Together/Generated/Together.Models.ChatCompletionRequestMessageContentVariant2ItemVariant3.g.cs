
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionRequestMessageContentVariant2ItemVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.ChatCompletionRequestMessageContentVariant2ItemVariant3TypeJsonConverter))]
        public global::Together.ChatCompletionRequestMessageContentVariant2ItemVariant3Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.ChatCompletionRequestMessageContentVariant2ItemVariant3VideoUrl VideoUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentVariant2ItemVariant3" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="videoUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionRequestMessageContentVariant2ItemVariant3(
            global::Together.ChatCompletionRequestMessageContentVariant2ItemVariant3VideoUrl videoUrl,
            global::Together.ChatCompletionRequestMessageContentVariant2ItemVariant3Type type)
        {
            this.VideoUrl = videoUrl ?? throw new global::System.ArgumentNullException(nameof(videoUrl));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentVariant2ItemVariant3" /> class.
        /// </summary>
        public ChatCompletionRequestMessageContentVariant2ItemVariant3()
        {
        }
    }
}