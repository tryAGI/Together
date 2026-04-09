
#nullable enable

namespace Together
{
    public partial class FineTuningClient
    {


        private static readonly global::Together.EndPointSecurityRequirement s_GetFinetuneDownloadSecurityRequirement0 =
            new global::Together.EndPointSecurityRequirement
            {
                Authorizations = new global::Together.EndPointAuthorizationRequirement[]
                {                    new global::Together.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Together.EndPointSecurityRequirement[] s_GetFinetuneDownloadSecurityRequirements =
            new global::Together.EndPointSecurityRequirement[]
            {                s_GetFinetuneDownloadSecurityRequirement0,
            };
        partial void PrepareGetFinetuneDownloadArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string ftId,
            ref int? checkpointStep,
            ref global::Together.GetFinetuneDownloadCheckpoint? checkpoint);
        partial void PrepareGetFinetuneDownloadRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string ftId,
            int? checkpointStep,
            global::Together.GetFinetuneDownloadCheckpoint? checkpoint);
        partial void ProcessGetFinetuneDownloadResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetFinetuneDownloadResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref byte[] content);

        /// <summary>
        /// Download model<br/>
        /// Receive a compressed fine-tuned model or checkpoint.
        /// </summary>
        /// <param name="ftId">
        /// Fine-tune ID to download. A string that starts with `ft-`.
        /// </param>
        /// <param name="checkpointStep">
        /// Specifies step number for checkpoint to download. Ignores `checkpoint` value if set.
        /// </param>
        /// <param name="checkpoint">
        /// Specifies checkpoint type to download - `merged` vs `adapter`. This field is required if the checkpoint_step is not set.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// # Docs for v1 can be found by changing the above selector ^<br/>
        /// from together import Together<br/>
        /// import os<br/>
        /// client = Together(<br/>
        ///     api_key=os.environ.get("TOGETHER_API_KEY"),<br/>
        /// )<br/>
        /// # Using `with_streaming_response` gives you control to do what you want with the response.<br/>
        /// stream = client.fine_tuning.with_streaming_response.content(ft_id="ft-id")<br/>
        /// with stream as response:<br/>
        ///     for line in response.iter_lines():<br/>
        ///         print(line)
        /// </remarks>
        public async global::System.Threading.Tasks.Task<byte[]> GetFinetuneDownloadAsync(
            string ftId,
            int? checkpointStep = default,
            global::Together.GetFinetuneDownloadCheckpoint? checkpoint = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetFinetuneDownloadArguments(
                httpClient: HttpClient,
                ftId: ref ftId,
                checkpointStep: ref checkpointStep,
                checkpoint: ref checkpoint);


            var __authorizations = global::Together.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetFinetuneDownloadSecurityRequirements,
                operationName: "GetFinetuneDownloadAsync");

            var __pathBuilder = new global::Together.PathBuilder(
                path: "/finetune/download",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddRequiredParameter("ft_id", ftId)
                .AddOptionalParameter("checkpoint_step", checkpointStep?.ToString())
                .AddOptionalParameter("checkpoint", checkpoint?.ToValueString()) 
                ;
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetFinetuneDownloadRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                ftId: ftId,
                checkpointStep: checkpointStep,
                checkpoint: checkpoint);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetFinetuneDownloadResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // 
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::Together.ApiException(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::System.Exception? __exception_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::Together.ApiException(
                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_404,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsByteArrayAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessGetFinetuneDownloadResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return __content;
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
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    var __content = await __response.Content.ReadAsByteArrayAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return __content;
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
    }
}