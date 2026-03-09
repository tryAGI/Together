
#nullable enable

namespace Together
{
    /// <summary>
    /// Available upon completion, the outputs provides the cost charged and the hosted url to access the video
    /// </summary>
    public sealed partial class VideoJobOutputs
    {
        /// <summary>
        /// The cost of generated video charged to the owners account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int Cost { get; set; } = default!;

        /// <summary>
        /// URL hosting the generated video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string VideoUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoJobOutputs" /> class.
        /// </summary>
        /// <param name="cost">
        /// The cost of generated video charged to the owners account.
        /// </param>
        /// <param name="videoUrl">
        /// URL hosting the generated video
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoJobOutputs(
            int cost,
            string videoUrl)
        {
            this.Cost = cost;
            this.VideoUrl = videoUrl ?? throw new global::System.ArgumentNullException(nameof(videoUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoJobOutputs" /> class.
        /// </summary>
        public VideoJobOutputs()
        {
        }
    }
}