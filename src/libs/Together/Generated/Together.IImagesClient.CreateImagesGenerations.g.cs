#nullable enable

namespace Together
{
    public partial interface IImagesClient
    {
        /// <summary>
        /// Create image<br/>
        /// Use an image model to generate an image for a given prompt.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// # Docs for v1 can be found by changing the above selector ^<br/>
        /// from together import Together<br/>
        /// import os<br/>
        /// client = Together(<br/>
        ///     api_key=os.environ.get("TOGETHER_API_KEY"),<br/>
        /// )<br/>
        /// response = client.images.generate(<br/>
        ///     model="black-forest-labs/FLUX.1-schnell",<br/>
        ///     steps=4,<br/>
        ///     prompt="A cartoon of an astronaut riding a horse on the moon",<br/>
        /// )<br/>
        /// print(response.data[0].url)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.ImageResponse> CreateImagesGenerationsAsync(

            global::Together.CreateImagesGenerationsRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create image<br/>
        /// Use an image model to generate an image for a given prompt.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.ImageResponse> CreateImagesGenerationsAsync(
            string prompt,
            global::Together.AnyOf<global::Together.CreateImagesGenerationsRequestModel?, string> model,
            int? steps = default,
            string? imageUrl = default,
            int? seed = default,
            int? n = default,
            int? height = default,
            int? width = default,
            string? negativePrompt = default,
            global::Together.CreateImagesGenerationsRequestResponseFormat? responseFormat = default,
            double? guidanceScale = default,
            global::Together.CreateImagesGenerationsRequestOutputFormat? outputFormat = default,
            global::System.Collections.Generic.IList<global::Together.CreateImagesGenerationsRequestImageLora>? imageLoras = default,
            global::System.Collections.Generic.IList<string>? referenceImages = default,
            bool? disableSafetyChecker = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}