
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoFrameImageInput
    {
        /// <summary>
        /// URL path to hosted image that is used for a frame
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InputImage { get; set; }

        /// <summary>
        /// Optional param to specify where to insert the frame. If this is omitted, the following heuristics are applied:<br/>
        /// - frame_images size is one, frame is first.<br/>
        /// - If size is two, frames are first and last.<br/>
        /// - If size is larger, frames are first, last and evenly spaced between.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.AnyOfJsonConverter<double?, global::Together.VideoFrameImageInputFrame?>))]
        public global::Together.AnyOf<double?, global::Together.VideoFrameImageInputFrame?>? Frame { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoFrameImageInput" /> class.
        /// </summary>
        /// <param name="inputImage">
        /// URL path to hosted image that is used for a frame
        /// </param>
        /// <param name="frame">
        /// Optional param to specify where to insert the frame. If this is omitted, the following heuristics are applied:<br/>
        /// - frame_images size is one, frame is first.<br/>
        /// - If size is two, frames are first and last.<br/>
        /// - If size is larger, frames are first, last and evenly spaced between.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoFrameImageInput(
            string inputImage,
            global::Together.AnyOf<double?, global::Together.VideoFrameImageInputFrame?>? frame)
        {
            this.InputImage = inputImage ?? throw new global::System.ArgumentNullException(nameof(inputImage));
            this.Frame = frame;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoFrameImageInput" /> class.
        /// </summary>
        public VideoFrameImageInput()
        {
        }
    }
}