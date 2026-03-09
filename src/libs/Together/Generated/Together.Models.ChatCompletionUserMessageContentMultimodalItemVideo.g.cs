
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
        public global::Together.ChatCompletionUserMessageContentMultimodalItemVideoVideoUrl VideoUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionUserMessageContentMultimodalItemVideo" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="videoUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionUserMessageContentMultimodalItemVideo(
            global::Together.ChatCompletionUserMessageContentMultimodalItemVideoVideoUrl videoUrl,
            global::Together.ChatCompletionUserMessageContentMultimodalItemVideoType type)
        {
            this.VideoUrl = videoUrl ?? throw new global::System.ArgumentNullException(nameof(videoUrl));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionUserMessageContentMultimodalItemVideo" /> class.
        /// </summary>
        public ChatCompletionUserMessageContentMultimodalItemVideo()
        {
        }
    }
}