
#nullable enable

namespace Together
{
    /// <summary>
    /// Contains all media inputs for video generation. Accepted fields depend on the model type.
    /// </summary>
    public sealed partial class VideoMedia
    {
        /// <summary>
        /// Array of images to guide video generation at specific timeline positions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame_images")]
        public global::System.Collections.Generic.IList<global::Together.VideoFrameImageInput>? FrameImages { get; set; }

        /// <summary>
        /// Array of video clips to use as starting clips.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame_videos")]
        public global::System.Collections.Generic.IList<global::Together.VideoRef>? FrameVideos { get; set; }

        /// <summary>
        /// Array of image URLs that guide the general appearance across the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_images")]
        public global::System.Collections.Generic.IList<string>? ReferenceImages { get; set; }

        /// <summary>
        /// Array of reference videos.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_videos")]
        public global::System.Collections.Generic.IList<global::Together.VideoRef>? ReferenceVideos { get; set; }

        /// <summary>
        /// Source video to edit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_video")]
        public global::Together.VideoRef? SourceVideo { get; set; }

        /// <summary>
        /// Array of audio inputs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_inputs")]
        public global::System.Collections.Generic.IList<global::Together.AudioRef>? AudioInputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoMedia" /> class.
        /// </summary>
        /// <param name="frameImages">
        /// Array of images to guide video generation at specific timeline positions.
        /// </param>
        /// <param name="frameVideos">
        /// Array of video clips to use as starting clips.
        /// </param>
        /// <param name="referenceImages">
        /// Array of image URLs that guide the general appearance across the video.
        /// </param>
        /// <param name="referenceVideos">
        /// Array of reference videos.
        /// </param>
        /// <param name="sourceVideo">
        /// Source video to edit.
        /// </param>
        /// <param name="audioInputs">
        /// Array of audio inputs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoMedia(
            global::System.Collections.Generic.IList<global::Together.VideoFrameImageInput>? frameImages,
            global::System.Collections.Generic.IList<global::Together.VideoRef>? frameVideos,
            global::System.Collections.Generic.IList<string>? referenceImages,
            global::System.Collections.Generic.IList<global::Together.VideoRef>? referenceVideos,
            global::Together.VideoRef? sourceVideo,
            global::System.Collections.Generic.IList<global::Together.AudioRef>? audioInputs)
        {
            this.FrameImages = frameImages;
            this.FrameVideos = frameVideos;
            this.ReferenceImages = referenceImages;
            this.ReferenceVideos = referenceVideos;
            this.SourceVideo = sourceVideo;
            this.AudioInputs = audioInputs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoMedia" /> class.
        /// </summary>
        public VideoMedia()
        {
        }
    }
}