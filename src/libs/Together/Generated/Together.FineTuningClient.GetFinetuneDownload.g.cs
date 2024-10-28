
#nullable enable

namespace Together
{
    public partial class FineTuningClient
    {
        partial void PrepareGetFinetuneDownloadArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string ftId,
            ref int? checkpointStep,
            ref global::Together.Checkpoint? checkpoint,
            ref string? output);
        partial void PrepareGetFinetuneDownloadRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string ftId,
            int? checkpointStep,
            global::Together.Checkpoint? checkpoint,
            string? output);
        partial void ProcessGetFinetuneDownloadResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetFinetuneDownloadResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Download model<br/>
        /// Download a compressed fine-tuned model or checkpoint to local disk.
        /// </summary>
        /// <param name="ftId"></param>
        /// <param name="checkpointStep"></param>
        /// <param name="checkpoint"></param>
        /// <param name="output"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Together.FinetuneDownloadResult> GetFinetuneDownloadAsync(
            string ftId,
            int? checkpointStep = default,
            global::Together.Checkpoint? checkpoint = default,
            string? output = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetFinetuneDownloadArguments(
                httpClient: HttpClient,
                ftId: ref ftId,
                checkpointStep: ref checkpointStep,
                checkpoint: ref checkpoint,
                output: ref output);

            var __pathBuilder = new PathBuilder(
                path: "/finetune/download",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("ft_id", ftId) 
                .AddOptionalParameter("checkpoint_step", checkpointStep?.ToString()) 
                .AddOptionalParameter("checkpoint", checkpoint?.ToValueString()) 
                .AddOptionalParameter("output", output) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetFinetuneDownloadRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                ftId: ftId,
                checkpointStep: checkpointStep,
                checkpoint: checkpoint,
                output: output);

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

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessGetFinetuneDownloadResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::Together.FinetuneDownloadResult.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}