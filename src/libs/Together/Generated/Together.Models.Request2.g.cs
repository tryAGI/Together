
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Request2
    {
        /// <summary>
        /// Height of the image to generate in number of pixels.<br/>
        /// Default Value: 1024
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// The model to use for image generation.  [See all of Together AI's image models](https://docs.together.ai/docs/serverless-models#image-models)<br/>
        /// Example: stabilityai/stable-diffusion-xl-base-1.0
        /// </summary>
        /// <example>stabilityai/stable-diffusion-xl-base-1.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.AnyOfJsonConverterFactory2))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.AnyOf<global::Together.RequestModel?, string> Model { get; set; }

        /// <summary>
        /// Number of image results to generate.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int? N { get; set; }

        /// <summary>
        /// The prompt or prompts not to guide the image generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_prompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// A description of the desired images. Maximum length varies by model.<br/>
        /// Example: cat floating in space, cinematic
        /// </summary>
        /// <example>cat floating in space, cinematic</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Seed used for generation. Can be used to reproduce image generations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Number of generation steps.<br/>
        /// Default Value: 20
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public int? Steps { get; set; }

        /// <summary>
        /// Width of the image to generate in number of pixels.<br/>
        /// Default Value: 1024
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Request2" /> class.
        /// </summary>
        /// <param name="height">
        /// Height of the image to generate in number of pixels.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="model">
        /// The model to use for image generation.  [See all of Together AI's image models](https://docs.together.ai/docs/serverless-models#image-models)<br/>
        /// Example: stabilityai/stable-diffusion-xl-base-1.0
        /// </param>
        /// <param name="n">
        /// Number of image results to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="negativePrompt">
        /// The prompt or prompts not to guide the image generation.
        /// </param>
        /// <param name="prompt">
        /// A description of the desired images. Maximum length varies by model.<br/>
        /// Example: cat floating in space, cinematic
        /// </param>
        /// <param name="seed">
        /// Seed used for generation. Can be used to reproduce image generations.
        /// </param>
        /// <param name="steps">
        /// Number of generation steps.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="width">
        /// Width of the image to generate in number of pixels.<br/>
        /// Default Value: 1024
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Request2(
            global::Together.AnyOf<global::Together.RequestModel?, string> model,
            string prompt,
            int? height,
            int? n,
            string? negativePrompt,
            int? seed,
            int? steps,
            int? width)
        {
            this.Model = model;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Height = height;
            this.N = n;
            this.NegativePrompt = negativePrompt;
            this.Seed = seed;
            this.Steps = steps;
            this.Width = width;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Request2" /> class.
        /// </summary>
        public Request2()
        {
        }
    }
}