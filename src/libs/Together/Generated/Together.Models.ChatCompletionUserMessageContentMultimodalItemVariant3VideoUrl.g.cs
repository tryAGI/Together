
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionUserMessageContentMultimodalItemVariant3VideoUrl
    {
        /// <summary>
        /// The URL of the video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionUserMessageContentMultimodalItemVariant3VideoUrl" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL of the video
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionUserMessageContentMultimodalItemVariant3VideoUrl(
            string url)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionUserMessageContentMultimodalItemVariant3VideoUrl" /> class.
        /// </summary>
        public ChatCompletionUserMessageContentMultimodalItemVariant3VideoUrl()
        {
        }
    }
}