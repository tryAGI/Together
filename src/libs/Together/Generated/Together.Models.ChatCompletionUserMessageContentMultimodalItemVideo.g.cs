
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionUserMessageContentMultimodalItemVideo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.ChatCompletionUserMessageContentMultimodalItemVideoTypeJsonConverter))]
        public global::Together.ChatCompletionUserMessageContentMultimodalItemVideoType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.ChatCompletionUserMessageContentMultimodalItemVideoVideoUrl VideoUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionUserMessageContentMultimodalItemVideo" /> class.
        /// </summary>
        /// <param name="videoUrl"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionUserMessageContentMultimodalItemVideo(
            global::Together.ChatCompletionUserMessageContentMultimodalItemVideoVideoUrl videoUrl,
            global::Together.ChatCompletionUserMessageContentMultimodalItemVideoType type)
        {
            this.Type = type;
            this.VideoUrl = videoUrl ?? throw new global::System.ArgumentNullException(nameof(videoUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionUserMessageContentMultimodalItemVideo" /> class.
        /// </summary>
        public ChatCompletionUserMessageContentMultimodalItemVideo()
        {
        }
    }
}