
#nullable enable

namespace Together
{
    public partial class GPUClusterServiceClient
    {


        private static readonly global::Together.EndPointSecurityRequirement s_GPUClusterServiceCreateSecurityRequirement0 =
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
        private static readonly global::Together.EndPointSecurityRequirement[] s_GPUClusterServiceCreateSecurityRequirements =
            new global::Together.EndPointSecurityRequirement[]
            {                s_GPUClusterServiceCreateSecurityRequirement0,
            };
        partial void PrepareGPUClusterServiceCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Together.GPUClusterCreateRequest request);
        partial void PrepareGPUClusterServiceCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Together.GPUClusterCreateRequest request);
        partial void ProcessGPUClusterServiceCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGPUClusterServiceCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create GPU Cluster<br/>
        /// Create an Instant Cluster on Together's high-performance GPU clusters.<br/>
        /// With features like on-demand scaling, long-lived resizable high-bandwidth shared DC-local storage,<br/>
        /// Kubernetes and Slurm cluster flavors, a REST API, and Terraform support,<br/>
        /// you can run workloads flexibly without complex infrastructure management.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// response = client.beta.clusters.create(<br/>
        ///   cluster_name="my-gpu-cluster",<br/>
        ///   region="us-central-8",<br/>
        ///   gpu_type="H100_SXM",<br/>
        ///   num_gpus=8,<br/>
        ///   driver_version="CUDA_12_6_560",<br/>
        ///   billint_type="ON_DEMAND",<br/>
        /// )<br/>
        /// print(response.cluster_id)
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Together.GPUClusterInfo> GPUClusterServiceCreateAsync(

            global::Together.GPUClusterCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareGPUClusterServiceCreateArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Together.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GPUClusterServiceCreateSecurityRequirements,
                operationName: "GPUClusterServiceCreateAsync");

            var __pathBuilder = new global::Together.PathBuilder(
                path: "/compute/clusters",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGPUClusterServiceCreateRequest(
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
            ProcessGPUClusterServiceCreateResponse(
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
                ProcessGPUClusterServiceCreateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Together.GPUClusterInfo.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Together.GPUClusterInfo.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Create GPU Cluster<br/>
        /// Create an Instant Cluster on Together's high-performance GPU clusters.<br/>
        /// With features like on-demand scaling, long-lived resizable high-bandwidth shared DC-local storage,<br/>
        /// Kubernetes and Slurm cluster flavors, a REST API, and Terraform support,<br/>
        /// you can run workloads flexibly without complex infrastructure management.
        /// </summary>
        /// <param name="clusterType">
        /// Type of cluster to create.
        /// </param>
        /// <param name="region">
        /// Region to create the GPU cluster in. Usable regions can be found from `client.clusters.list_regions()`
        /// </param>
        /// <param name="gpuType">
        /// Type of GPU to use in the cluster
        /// </param>
        /// <param name="numGpus">
        /// Number of GPUs to allocate in the cluster. This must be multiple of 8. For example, 8, 16 or 24
        /// </param>
        /// <param name="clusterName">
        /// Name of the GPU cluster.
        /// </param>
        /// <param name="durationDays">
        /// Duration in days to keep the cluster running.
        /// </param>
        /// <param name="driverVersion">
        /// NVIDIA driver version to use in the cluster.
        /// </param>
        /// <param name="sharedVolume">
        /// Inline configuration to create a shared volume with the cluster creation.
        /// </param>
        /// <param name="volumeId">
        /// ID of an existing volume to use with the cluster creation.
        /// </param>
        /// <param name="billingType">
        /// RESERVED billing types allow you to specify the duration of the cluster reservation via the duration_days field.<br/>
        /// ON_DEMAND billing types will give you ownership of the cluster until you delete it.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Together.GPUClusterInfo> GPUClusterServiceCreateAsync(
            string region,
            global::Together.GPUClusterCreateRequestGpuType gpuType,
            int numGpus,
            string clusterName,
            global::Together.GPUClusterCreateRequestDriverVersion driverVersion,
            global::Together.GPUClusterCreateRequestBillingType billingType,
            global::Together.GPUClusterCreateRequestClusterType? clusterType = default,
            int? durationDays = default,
            global::Together.GPUClustersSharedVolumeCreateRequest? sharedVolume = default,
            string? volumeId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Together.GPUClusterCreateRequest
            {
                ClusterType = clusterType,
                Region = region,
                GpuType = gpuType,
                NumGpus = numGpus,
                ClusterName = clusterName,
                DurationDays = durationDays,
                DriverVersion = driverVersion,
                SharedVolume = sharedVolume,
                VolumeId = volumeId,
                BillingType = billingType,
            };

            return await GPUClusterServiceCreateAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}