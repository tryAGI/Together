
#nullable enable

namespace Together
{
    public partial class FineTuningClient
    {
        partial void PrepareGetFinetuneDownloadArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string ftId,
            ref int checkpointStep,
            ref string? output);
        partial void PrepareGetFinetuneDownloadRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string ftId,
            int checkpointStep,
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
        /// <param name="output"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Together.FinetuneDownloadResult> GetFinetuneDownloadAsync(
            string ftId,
            int checkpointStep,
            string? output,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetFinetuneDownloadArguments(
                httpClient: _httpClient,
                ftId: ref ftId,
                checkpointStep: ref checkpointStep,
                output: ref output);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/finetune/download?ft_id={ftId}&checkpoint_step={checkpointStep}&output={output}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetFinetuneDownloadRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                ftId: ftId,
                checkpointStep: checkpointStep,
                output: output);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetFinetuneDownloadResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetFinetuneDownloadResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::Together.SourceGenerationContext.Default.FinetuneDownloadResult) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}