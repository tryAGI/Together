
#nullable enable

namespace Together
{
    public partial class VideoClient
    {
        partial void PrepareCreateVideoArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Together.CreateVideoBody request);
        partial void PrepareCreateVideoRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Together.CreateVideoBody request);
        partial void ProcessCreateVideoResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateVideoResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<global::Together.VideoJob> CreateVideoAsync(

            global::Together.CreateVideoBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateVideoArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::Together.PathBuilder(
                path: "/videos",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateVideoRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateVideoResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessCreateVideoResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Together.VideoJob.FromJson(__content, JsonSerializerOptions) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Together.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Together.VideoJob.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Together.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
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
        /// <param name="frameImages">
        /// Array of images to guide video generation, similar to keyframes.<br/>
        /// Example: [[{"input_image":"aac49721-1964-481a-ae78-8a4e29b91402","frame":0}, {"input_image":"c00abf5f-6cdb-4642-a01d-1bfff7bc3cf7","frame":48}, {"input_image":"3ad204c3-a9de-4963-8a1a-c3911e3afafe","frame":"last"}]]
        /// </param>
        /// <param name="referenceImages">
        /// Unlike frame_images which constrain specific timeline positions, reference images guide the general appearance that should appear consistently across the video.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Together.VideoJob> CreateVideoAsync(
            string model,
            string? prompt = default,
            int? height = default,
            int? width = default,
            string? seconds = default,
            int? fps = default,
            int? steps = default,
            int? seed = default,
            int? guidanceScale = default,
            global::Together.VideoOutputFormat? outputFormat = default,
            int? outputQuality = default,
            string? negativePrompt = default,
            global::System.Collections.Generic.IList<global::Together.VideoFrameImageInput>? frameImages = default,
            global::System.Collections.Generic.IList<string>? referenceImages = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Together.CreateVideoBody
            {
                Model = model,
                Prompt = prompt,
                Height = height,
                Width = width,
                Seconds = seconds,
                Fps = fps,
                Steps = steps,
                Seed = seed,
                GuidanceScale = guidanceScale,
                OutputFormat = outputFormat,
                OutputQuality = outputQuality,
                NegativePrompt = negativePrompt,
                FrameImages = frameImages,
                ReferenceImages = referenceImages,
            };

            return await CreateVideoAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}