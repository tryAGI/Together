
#nullable enable

namespace Together
{
    public partial class GPUClusterServiceClient
    {
        partial void PrepareGPUClusterServiceUpdateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string clusterId,
            global::Together.GPUClusterUpdateRequest request);
        partial void PrepareGPUClusterServiceUpdateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string clusterId,
            global::Together.GPUClusterUpdateRequest request);
        partial void ProcessGPUClusterServiceUpdateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGPUClusterServiceUpdateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update a GPU Cluster.<br/>
        /// Update the configuration of an existing GPU cluster.
        /// </summary>
        /// <param name="clusterId">
        /// The ID of the cluster to update
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// cluster = client.beta.clusters.update("cluster_id", cluster_type="KUBERNETES", num_gpus=24)<br/>
        /// print(cluster)
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Together.GPUClusterInfo> GPUClusterServiceUpdateAsync(
            string clusterId,

            global::Together.GPUClusterUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareGPUClusterServiceUpdateArguments(
                httpClient: HttpClient,
                clusterId: ref clusterId,
                request: request);

            var __pathBuilder = new global::Together.PathBuilder(
                path: $"/compute/clusters/{clusterId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
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
            PrepareGPUClusterServiceUpdateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                clusterId: clusterId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGPUClusterServiceUpdateResponse(
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
                ProcessGPUClusterServiceUpdateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Together.GPUClusterInfo.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::Together.GPUClusterInfo.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Update a GPU Cluster.<br/>
        /// Update the configuration of an existing GPU cluster.
        /// </summary>
        /// <param name="clusterId">
        /// The ID of the cluster to update
        /// </param>
        /// <param name="clusterType">
        /// Type of cluster to update.
        /// </param>
        /// <param name="numGpus">
        /// Number of GPUs to allocate in the cluster. This must be multiple of 8. For example, 8, 16 or 24
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Together.GPUClusterInfo> GPUClusterServiceUpdateAsync(
            string clusterId,
            global::Together.GPUClusterUpdateRequestClusterType? clusterType = default,
            int? numGpus = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Together.GPUClusterUpdateRequest
            {
                ClusterType = clusterType,
                NumGpus = numGpus,
            };

            return await GPUClusterServiceUpdateAsync(
                clusterId: clusterId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}