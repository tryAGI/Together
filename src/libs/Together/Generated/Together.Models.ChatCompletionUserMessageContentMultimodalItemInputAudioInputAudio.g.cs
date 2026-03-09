
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionUserMessageContentMultimodalItemInputAudioInputAudio
    {
        /// <summary>
        /// The base64 encoded audio data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// The format of the audio data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.ChatCompletionUserMessageContentMultimodalItemInputAudioInputAudioFormatJsonConverter))]
        public global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudioInputAudioFormat Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionUserMessageContentMultimodalItemInputAudioInputAudio" /> class.
        /// </summary>
        /// <param name="data">
        /// The base64 encoded audio data
        /// </param>
        /// <param name="format">
        /// The format of the audio data
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionUserMessageContentMultimodalItemInputAudioInputAudio(
            string data,
            global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudioInputAudioFormat format)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionUserMessageContentMultimodalItemInputAudioInputAudio" /> class.
        /// </summary>
        public ChatCompletionUserMessageContentMultimodalItemInputAudioInputAudio()
        {
        }
    }
}