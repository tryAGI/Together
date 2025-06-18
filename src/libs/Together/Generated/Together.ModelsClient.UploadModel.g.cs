
#nullable enable

namespace Together
{
    public partial class ModelsClient
    {
        partial void PrepareUploadModelArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Together.ModelUploadRequest request);
        partial void PrepareUploadModelRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Together.ModelUploadRequest request);
        partial void ProcessUploadModelResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUploadModelResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Upload a custom model or adapter<br/>
        /// Upload a custom model or adapter from Hugging Face or S3
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Together.ModelUploadSuccessResponse> UploadModelAsync(
            global::Together.ModelUploadRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUploadModelArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::Together.PathBuilder(
                path: "/models",
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareUploadModelRequest(
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
            ProcessUploadModelResponse(
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
                ProcessUploadModelResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Together.ModelUploadSuccessResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Together.ModelUploadSuccessResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Together.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }

        /// <summary>
        /// Upload a custom model or adapter<br/>
        /// Upload a custom model or adapter from Hugging Face or S3
        /// </summary>
        /// <param name="baseModel">
        /// The base model to use for an adapter if setting it to run against a serverless pool.  Only used for model_type `adapter`.<br/>
        /// Example: Qwen/Qwen2.5-72B-Instruct
        /// </param>
        /// <param name="description">
        /// A description of your model<br/>
        /// Example: Finetuned Qwen2.5-72B-Instruct by Unsloth
        /// </param>
        /// <param name="hfToken">
        /// Hugging Face token (if uploading from Hugging Face)<br/>
        /// Example: hf_examplehuggingfacetoken
        /// </param>
        /// <param name="loraModel">
        /// The lora pool to use for an adapter if setting it to run against, say, a dedicated pool.  Only used for model_type `adapter`.<br/>
        /// Example: my_username/Qwen2.5-72B-Instruct-lora
        /// </param>
        /// <param name="modelName">
        /// The name to give to your uploaded model<br/>
        /// Example: Qwen2.5-72B-Instruct
        /// </param>
        /// <param name="modelSource">
        /// The source location of the model (Hugging Face repo or S3 path)<br/>
        /// Example: unsloth/Qwen2.5-72B-Instruct
        /// </param>
        /// <param name="modelType">
        /// Whether the model is a full model or an adapter<br/>
        /// Default Value: model<br/>
        /// Example: model
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Together.ModelUploadSuccessResponse> UploadModelAsync(
            string modelName,
            string modelSource,
            string? baseModel = default,
            string? description = default,
            string? hfToken = default,
            string? loraModel = default,
            global::Together.ModelUploadRequestModelType? modelType = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Together.ModelUploadRequest
            {
                BaseModel = baseModel,
                Description = description,
                HfToken = hfToken,
                LoraModel = loraModel,
                ModelName = modelName,
                ModelSource = modelSource,
                ModelType = modelType,
            };

            return await UploadModelAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}