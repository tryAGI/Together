
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// Parameters for creating a new video generation job.
    /// </summary>
    public sealed partial class CreateVideoBody
    {
        /// <summary>
        /// The model to be used for the video creation request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Text prompt that describes the video to generate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Video resolution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        public string? Resolution { get; set; }

        /// <summary>
        /// Aspect ratio of the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        public string? Ratio { get; set; }

        /// <summary>
        /// Clip duration in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seconds")]
        public string? Seconds { get; set; }

        /// <summary>
        /// Frames per second. Defaults to 24.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fps")]
        public int? Fps { get; set; }

        /// <summary>
        /// The number of denoising steps the model performs during video generation. More steps typically result in higher quality output but require longer processing time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public int? Steps { get; set; }

        /// <summary>
        /// Seed to use in initializing the video generation.  Using the same seed allows deterministic video generation.  If not provided a random seed is generated for each request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Controls how closely the video generation follows your prompt. Higher values make the model adhere more strictly to your text description, while lower values allow more creative freedom. guidence_scale affects both visual content and temporal consistency.Recommended range is 6.0-10.0 for most video models. Values above 12 may cause over-guidance artifacts or unnatural motion patterns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guidance_scale")]
        public int? GuidanceScale { get; set; }

        /// <summary>
        /// Specifies the format of the output video. Defaults to MP4.
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
        /// Similar to prompt, but specifies what to avoid instead of what to include
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_prompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// Whether to generate audio for the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generate_audio")]
        public bool? GenerateAudio { get; set; }

        /// <summary>
        /// Media inputs for video generation. The accepted fields depend on the model type (e.g. i2v, r2v, t2v, videoedit).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media")]
        public global::Together.VideoMedia? Media { get; set; }

        /// <summary>
        /// Deprecated: use media.frame_images instead. Array of images to guide video generation, similar to keyframes.<br/>
        /// Example: [[{"input_image":"aac49721-1964-481a-ae78-8a4e29b91402","frame":0}, {"input_image":"c00abf5f-6cdb-4642-a01d-1bfff7bc3cf7","frame":48}, {"input_image":"3ad204c3-a9de-4963-8a1a-c3911e3afafe","frame":"last"}]]
        /// </summary>
        /// <example>[[{"input_image":"aac49721-1964-481a-ae78-8a4e29b91402","frame":0}, {"input_image":"c00abf5f-6cdb-4642-a01d-1bfff7bc3cf7","frame":48}, {"input_image":"3ad204c3-a9de-4963-8a1a-c3911e3afafe","frame":"last"}]]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame_images")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::Together.VideoFrameImageInput>? FrameImages { get; set; }

        /// <summary>
        /// Deprecated: use media.reference_images instead. Unlike frame_images which constrain specific timeline positions, reference images guide the general appearance that should appear consistently across the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_images")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? ReferenceImages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoBody" /> class.
        /// </summary>
        /// <param name="model">
        /// The model to be used for the video creation request.
        /// </param>
        /// <param name="prompt">
        /// Text prompt that describes the video to generate.
        /// </param>
        /// <param name="height"></param>
        /// <param name="width"></param>
        /// <param name="resolution">
        /// Video resolution.
        /// </param>
        /// <param name="ratio">
        /// Aspect ratio of the video.
        /// </param>
        /// <param name="seconds">
        /// Clip duration in seconds.
        /// </param>
        /// <param name="fps">
        /// Frames per second. Defaults to 24.
        /// </param>
        /// <param name="steps">
        /// The number of denoising steps the model performs during video generation. More steps typically result in higher quality output but require longer processing time.
        /// </param>
        /// <param name="seed">
        /// Seed to use in initializing the video generation.  Using the same seed allows deterministic video generation.  If not provided a random seed is generated for each request.
        /// </param>
        /// <param name="guidanceScale">
        /// Controls how closely the video generation follows your prompt. Higher values make the model adhere more strictly to your text description, while lower values allow more creative freedom. guidence_scale affects both visual content and temporal consistency.Recommended range is 6.0-10.0 for most video models. Values above 12 may cause over-guidance artifacts or unnatural motion patterns.
        /// </param>
        /// <param name="outputFormat">
        /// Specifies the format of the output video. Defaults to MP4.
        /// </param>
        /// <param name="outputQuality">
        /// Compression quality. Defaults to 20.
        /// </param>
        /// <param name="negativePrompt">
        /// Similar to prompt, but specifies what to avoid instead of what to include
        /// </param>
        /// <param name="generateAudio">
        /// Whether to generate audio for the video.
        /// </param>
        /// <param name="media">
        /// Media inputs for video generation. The accepted fields depend on the model type (e.g. i2v, r2v, t2v, videoedit).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoBody(
            string model,
            string? prompt,
            int? height,
            int? width,
            string? resolution,
            string? ratio,
            string? seconds,
            int? fps,
            int? steps,
            int? seed,
            int? guidanceScale,
            global::Together.VideoOutputFormat? outputFormat,
            int? outputQuality,
            string? negativePrompt,
            bool? generateAudio,
            global::Together.VideoMedia? media)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Prompt = prompt;
            this.Height = height;
            this.Width = width;
            this.Resolution = resolution;
            this.Ratio = ratio;
            this.Seconds = seconds;
            this.Fps = fps;
            this.Steps = steps;
            this.Seed = seed;
            this.GuidanceScale = guidanceScale;
            this.OutputFormat = outputFormat;
            this.OutputQuality = outputQuality;
            this.NegativePrompt = negativePrompt;
            this.GenerateAudio = generateAudio;
            this.Media = media;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoBody" /> class.
        /// </summary>
        public CreateVideoBody()
        {
        }
    }
}