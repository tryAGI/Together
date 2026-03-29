
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionUserMessageContentMultimodalItemAudio
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.ChatCompletionUserMessageContentMultimodalItemAudioTypeJsonConverter))]
        public global::Together.ChatCompletionUserMessageContentMultimodalItemAudioType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.ChatCompletionUserMessageContentMultimodalItemAudioAudioUrl AudioUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionUserMessageContentMultimodalItemAudio" /> class.
        /// </summary>
        /// <param name="audioUrl"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionUserMessageContentMultimodalItemAudio(
            global::Together.ChatCompletionUserMessageContentMultimodalItemAudioAudioUrl audioUrl,
            global::Together.ChatCompletionUserMessageContentMultimodalItemAudioType type)
        {
            this.Type = type;
            this.AudioUrl = audioUrl ?? throw new global::System.ArgumentNullException(nameof(audioUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionUserMessageContentMultimodalItemAudio" /> class.
        /// </summary>
        public ChatCompletionUserMessageContentMultimodalItemAudio()
        {
        }
    }
}