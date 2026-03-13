
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Request
    {
        /// <summary>
        /// A description of the desired images. Maximum length varies by model.<br/>
        /// Example: cat floating in space, cinematic
        /// </summary>
        /// <example>cat floating in space, cinematic</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The model to use for image generation.  [See all of Together AI's image models](https://docs.together.ai/docs/serverless-models#image-models)<br/>
        /// Example: black-forest-labs/FLUX.1-schnell
        /// </summary>
        /// <example>black-forest-labs/FLUX.1-schnell</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.AnyOfJsonConverter<global::Together.RequestModel?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.AnyOf<global::Together.RequestModel?, string> Model { get; set; }

        /// <summary>
        /// Number of generation steps.<br/>
        /// Default Value: 20
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public int? Steps { get; set; }

        /// <summary>
        /// URL of an image to use for image models that support it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Seed used for generation. Can be used to reproduce image generations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Number of image results to generate.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int? N { get; set; }

        /// <summary>
        /// Height of the image to generate in number of pixels.<br/>
        /// Default Value: 1024
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Width of the image to generate in number of pixels.<br/>
        /// Default Value: 1024
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// The prompt or prompts not to guide the image generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_prompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// Format of the image response. Can be either a base64 string or a URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.RequestResponseFormatJsonConverter))]
        public global::Together.RequestResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// Adjusts the alignment of the generated image with the input prompt. Higher values (e.g., 8-10) make the output more faithful to the prompt, while lower values (e.g., 1-5) encourage more creative freedom.<br/>
        /// Default Value: 3.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guidance_scale")]
        public double? GuidanceScale { get; set; }

        /// <summary>
        /// The format of the image response. Can be either be `jpeg` or `png`. Defaults to `jpeg`.<br/>
        /// Default Value: jpeg
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.RequestOutputFormatJsonConverter))]
        public global::Together.RequestOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// An array of objects that define LoRAs (Low-Rank Adaptations) to influence the generated image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_loras")]
        public global::System.Collections.Generic.IList<global::Together.RequestImageLora>? ImageLoras { get; set; }

        /// <summary>
        /// An array of image URLs that guide the overall appearance and style of the generated image. These reference images influence the visual characteristics consistently across the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_images")]
        public global::System.Collections.Generic.IList<string>? ReferenceImages { get; set; }

        /// <summary>
        /// If true, disables the safety checker for image generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_safety_checker")]
        public bool? DisableSafetyChecker { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Request" /> class.
        /// </summary>
        /// <param name="prompt">
        /// A description of the desired images. Maximum length varies by model.<br/>
        /// Example: cat floating in space, cinematic
        /// </param>
        /// <param name="model">
        /// The model to use for image generation.  [See all of Together AI's image models](https://docs.together.ai/docs/serverless-models#image-models)<br/>
        /// Example: black-forest-labs/FLUX.1-schnell
        /// </param>
        /// <param name="steps">
        /// Number of generation steps.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="imageUrl">
        /// URL of an image to use for image models that support it.
        /// </param>
        /// <param name="seed">
        /// Seed used for generation. Can be used to reproduce image generations.
        /// </param>
        /// <param name="n">
        /// Number of image results to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="height">
        /// Height of the image to generate in number of pixels.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="width">
        /// Width of the image to generate in number of pixels.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="negativePrompt">
        /// The prompt or prompts not to guide the image generation.
        /// </param>
        /// <param name="responseFormat">
        /// Format of the image response. Can be either a base64 string or a URL.
        /// </param>
        /// <param name="guidanceScale">
        /// Adjusts the alignment of the generated image with the input prompt. Higher values (e.g., 8-10) make the output more faithful to the prompt, while lower values (e.g., 1-5) encourage more creative freedom.<br/>
        /// Default Value: 3.5
        /// </param>
        /// <param name="outputFormat">
        /// The format of the image response. Can be either be `jpeg` or `png`. Defaults to `jpeg`.<br/>
        /// Default Value: jpeg
        /// </param>
        /// <param name="imageLoras">
        /// An array of objects that define LoRAs (Low-Rank Adaptations) to influence the generated image.
        /// </param>
        /// <param name="referenceImages">
        /// An array of image URLs that guide the overall appearance and style of the generated image. These reference images influence the visual characteristics consistently across the generation.
        /// </param>
        /// <param name="disableSafetyChecker">
        /// If true, disables the safety checker for image generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Request(
            string prompt,
            global::Together.AnyOf<global::Together.RequestModel?, string> model,
            int? steps,
            string? imageUrl,
            int? seed,
            int? n,
            int? height,
            int? width,
            string? negativePrompt,
            global::Together.RequestResponseFormat? responseFormat,
            double? guidanceScale,
            global::Together.RequestOutputFormat? outputFormat,
            global::System.Collections.Generic.IList<global::Together.RequestImageLora>? imageLoras,
            global::System.Collections.Generic.IList<string>? referenceImages,
            bool? disableSafetyChecker)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Model = model;
            this.Steps = steps;
            this.ImageUrl = imageUrl;
            this.Seed = seed;
            this.N = n;
            this.Height = height;
            this.Width = width;
            this.NegativePrompt = negativePrompt;
            this.ResponseFormat = responseFormat;
            this.GuidanceScale = guidanceScale;
            this.OutputFormat = outputFormat;
            this.ImageLoras = imageLoras;
            this.ReferenceImages = referenceImages;
            this.DisableSafetyChecker = disableSafetyChecker;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Request" /> class.
        /// </summary>
        public Request()
        {
        }
    }
}