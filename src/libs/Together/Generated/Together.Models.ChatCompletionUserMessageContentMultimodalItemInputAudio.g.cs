
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionUserMessageContentMultimodalItemInputAudio
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudioInputAudio InputAudio { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.ChatCompletionUserMessageContentMultimodalItemInputAudioTypeJsonConverter))]
        public global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudioType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionUserMessageContentMultimodalItemInputAudio" /> class.
        /// </summary>
        /// <param name="inputAudio"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionUserMessageContentMultimodalItemInputAudio(
            global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudioInputAudio inputAudio,
            global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudioType type)
        {
            this.InputAudio = inputAudio ?? throw new global::System.ArgumentNullException(nameof(inputAudio));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionUserMessageContentMultimodalItemInputAudio" /> class.
        /// </summary>
        public ChatCompletionUserMessageContentMultimodalItemInputAudio()
        {
        }
    }
}