#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Together
{
    public partial interface IVideoClient
    {
        /// <summary>
        /// Create video<br/>
        /// Create a video
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// # Docs for v1 can be found by changing the above selector ^<br/>
        /// from together import Together<br/>
        /// import os<br/>
        /// client = Together(<br/>
        ///     api_key=os.environ.get("TOGETHER_API_KEY"),<br/>
        /// )<br/>
        /// response = client.videos.create(<br/>
        ///     model="together/video-model",<br/>
        ///     prompt="A cartoon of an astronaut riding a horse on the moon"<br/>
        /// )<br/>
        /// print(response.id)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.VideoJob> CreateVideoAsync(

            global::Together.CreateVideoBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create video<br/>
        /// Create a video
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.VideoJob> CreateVideoAsync(
            string model,
            string? prompt = default,
            int? height = default,
            int? width = default,
            string? resolution = default,
            string? ratio = default,
            string? seconds = default,
            int? fps = default,
            int? steps = default,
            int? seed = default,
            int? guidanceScale = default,
            global::Together.VideoOutputFormat? outputFormat = default,
            int? outputQuality = default,
            string? negativePrompt = default,
            bool? generateAudio = default,
            global::Together.VideoMedia? media = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}