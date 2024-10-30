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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.ImageResponse> CreateImagesGenerationsAsync(
            global::Together.Request2 request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create image<br/>
        /// Use an image model to generate an image for a given prompt.
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.ImageResponse> CreateImagesGenerationsAsync(
            global::Together.AnyOf<global::Together.RequestModel?, string> model,
            string prompt,
            int? height = default,
            int? n = default,
            string? negativePrompt = default,
            int? seed = default,
            int? steps = default,
            int? width = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}