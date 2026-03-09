
#nullable enable

namespace Together
{
    /// <summary>
    /// Parameters for creating a new video generation job.
    /// </summary>
    public sealed partial class CreateVideoBody
    {
        /// <summary>
        /// Frames per second. Defaults to 24.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fps")]
        public int? Fps { get; set; }

        /// <summary>
        /// Array of images to guide video generation, similar to keyframes.<br/>
        /// Example: [[{"frame":0,"input_image":"aac49721-1964-481a-ae78-8a4e29b91402"}, {"frame":48,"input_image":"c00abf5f-6cdb-4642-a01d-1bfff7bc3cf7"}, {"frame":"last","input_image":"3ad204c3-a9de-4963-8a1a-c3911e3afafe"}]]
        /// </summary>
        /// <example>[[{"frame":0,"input_image":"aac49721-1964-481a-ae78-8a4e29b91402"}, {"frame":48,"input_image":"c00abf5f-6cdb-4642-a01d-1bfff7bc3cf7"}, {"frame":"last","input_image":"3ad204c3-a9de-4963-8a1a-c3911e3afafe"}]]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame_images")]
        public global::System.Collections.Generic.IList<global::Together.VideoFrameImageInput>? FrameImages { get; set; }

        /// <summary>
        /// Controls how closely the video generation follows your prompt. Higher values make the model adhere more strictly to your text description, while lower values allow more creative freedom. guidence_scale affects both visual content and temporal consistency.Recommended range is 6.0-10.0 for most video models. Values above 12 may cause over-guidance artifacts or unnatural motion patterns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guidance_scale")]
        public int? GuidanceScale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// The model to be used for the video creation request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Model { get; set; } = default!;

        /// <summary>
        /// Similar to prompt, but specifies what to avoid instead of what to include
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_prompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.VideoOutputFormatJsonConverter))]
        public global::Together.VideoOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Compression quality. Defaults to 20.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_quality")]
        public int? OutputQuality { get; set; }

        /// <summary>
        /// Text prompt that describes the video to generate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Unlike frame_images which constrain specific timeline positions, reference images guide the general appearance that should appear consistently across the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_images")]
        public global::System.Collections.Generic.IList<string>? ReferenceImages { get; set; }

        /// <summary>
        /// Clip duration in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seconds")]
        public string? Seconds { get; set; }

        /// <summary>
        /// Seed to use in initializing the video generation.  Using the same seed allows deterministic video generation.  If not provided a random seed is generated for each request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// The number of denoising steps the model performs during video generation. More steps typically result in higher quality output but require longer processing time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public int? Steps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoBody" /> class.
        /// </summary>
        /// <param name="fps">
        /// Frames per second. Defaults to 24.
        /// </param>
        /// <param name="frameImages">
        /// Array of images to guide video generation, similar to keyframes.<br/>
        /// Example: [[{"frame":0,"input_image":"aac49721-1964-481a-ae78-8a4e29b91402"}, {"frame":48,"input_image":"c00abf5f-6cdb-4642-a01d-1bfff7bc3cf7"}, {"frame":"last","input_image":"3ad204c3-a9de-4963-8a1a-c3911e3afafe"}]]
        /// </param>
        /// <param name="guidanceScale">
        /// Controls how closely the video generation follows your prompt. Higher values make the model adhere more strictly to your text description, while lower values allow more creative freedom. guidence_scale affects both visual content and temporal consistency.Recommended range is 6.0-10.0 for most video models. Values above 12 may cause over-guidance artifacts or unnatural motion patterns.
        /// </param>
        /// <param name="height"></param>
        /// <param name="model">
        /// The model to be used for the video creation request.
        /// </param>
        /// <param name="negativePrompt">
        /// Similar to prompt, but specifies what to avoid instead of what to include
        /// </param>
        /// <param name="outputFormat"></param>
        /// <param name="outputQuality">
        /// Compression quality. Defaults to 20.
        /// </param>
        /// <param name="prompt">
        /// Text prompt that describes the video to generate.
        /// </param>
        /// <param name="referenceImages">
        /// Unlike frame_images which constrain specific timeline positions, reference images guide the general appearance that should appear consistently across the video.
        /// </param>
        /// <param name="seconds">
        /// Clip duration in seconds.
        /// </param>
        /// <param name="seed">
        /// Seed to use in initializing the video generation.  Using the same seed allows deterministic video generation.  If not provided a random seed is generated for each request.
        /// </param>
        /// <param name="steps">
        /// The number of denoising steps the model performs during video generation. More steps typically result in higher quality output but require longer processing time.
        /// </param>
        /// <param name="width"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoBody(
            string model,
            int? fps,
            global::System.Collections.Generic.IList<global::Together.VideoFrameImageInput>? frameImages,
            int? guidanceScale,
            int? height,
            string? negativePrompt,
            global::Together.VideoOutputFormat? outputFormat,
            int? outputQuality,
            string? prompt,
            global::System.Collections.Generic.IList<string>? referenceImages,
            string? seconds,
            int? seed,
            int? steps,
            int? width)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Fps = fps;
            this.FrameImages = frameImages;
            this.GuidanceScale = guidanceScale;
            this.Height = height;
            this.NegativePrompt = negativePrompt;
            this.OutputFormat = outputFormat;
            this.OutputQuality = outputQuality;
            this.Prompt = prompt;
            this.ReferenceImages = referenceImages;
            this.Seconds = seconds;
            this.Seed = seed;
            this.Steps = steps;
            this.Width = width;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoBody" /> class.
        /// </summary>
        public CreateVideoBody()
        {
        }
    }
}