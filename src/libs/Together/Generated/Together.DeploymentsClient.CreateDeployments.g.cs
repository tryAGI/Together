
#nullable enable

namespace Together
{
    public partial class DeploymentsClient
    {
        partial void PrepareCreateDeploymentsArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Together.CreateDeploymentRequest request);
        partial void PrepareCreateDeploymentsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Together.CreateDeploymentRequest request);
        partial void ProcessCreateDeploymentsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateDeploymentsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a new deployment<br/>
        /// Create a new deployment with specified configuration
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// deployment = client.beta.jig.deploy(<br/>
        ///   name="my-deployment",<br/>
        ///   gpu_type="h100-80gb",<br/>
        ///   image="registry.together.xyz/proj_abcdefg1234567890/my-image:latest"<br/>
        /// )<br/>
        /// print(deployment)
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Together.DeploymentResponseItem> CreateDeploymentsAsync(

            global::Together.CreateDeploymentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateDeploymentsArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::Together.PathBuilder(
                path: "/deployments",
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
            PrepareCreateDeploymentsRequest(
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
            ProcessCreateDeploymentsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Invalid request
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                string? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::System.Text.Json.JsonSerializer.Deserialize<string?>(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::System.Text.Json.JsonSerializer.Deserialize<string?>(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::Together.ApiException<string>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Internal server error
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::System.Exception? __exception_500 = null;
                string? __value_500 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_500 = global::System.Text.Json.JsonSerializer.Deserialize<string?>(__content_500, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_500 = global::System.Text.Json.JsonSerializer.Deserialize<string?>(__content_500, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_500 = __ex;
                }

                throw new global::Together.ApiException<string>(
                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_500,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_500,
                    ResponseObject = __value_500,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

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
                ProcessCreateDeploymentsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Together.DeploymentResponseItem.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::Together.DeploymentResponseItem.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Create a new deployment<br/>
        /// Create a new deployment with specified configuration
        /// </summary>
        /// <param name="args">
        /// Args overrides the container's CMD. Provide as an array of arguments (e.g., ["python", "app.py"])
        /// </param>
        /// <param name="autoscaling">
        /// Autoscaling configuration. Example: {"metric": "QueueBacklogPerWorker", "target": 1.01} to scale based on queue backlog. Omit or set to null to disable autoscaling
        /// </param>
        /// <param name="command">
        /// Command overrides the container's ENTRYPOINT. Provide as an array (e.g., ["/bin/sh", "-c"])
        /// </param>
        /// <param name="cpu">
        /// CPU is the number of CPU cores to allocate per container instance (e.g., 0.1 = 100 milli cores)
        /// </param>
        /// <param name="description">
        /// Description is an optional human-readable description of your deployment
        /// </param>
        /// <param name="environmentVariables">
        /// EnvironmentVariables is a list of environment variables to set in the container. Each must have a name and either a value or value_from_secret
        /// </param>
        /// <param name="gpuCount">
        /// GPUCount is the number of GPUs to allocate per container instance. Defaults to 0 if not specified
        /// </param>
        /// <param name="gpuType">
        /// GPUType specifies the GPU hardware to use (e.g., "h100-80gb").
        /// </param>
        /// <param name="healthCheckPath">
        /// HealthCheckPath is the HTTP path for health checks (e.g., "/health"). If set, the platform will check this endpoint to determine container health
        /// </param>
        /// <param name="image">
        /// Image is the container image to deploy from registry.together.ai.
        /// </param>
        /// <param name="maxReplicas">
        /// MaxReplicas is the maximum number of container instances that can be scaled up to. If not set, will be set to MinReplicas
        /// </param>
        /// <param name="memory">
        /// Memory is the amount of RAM to allocate per container instance in GiB (e.g., 0.5 = 512MiB)
        /// </param>
        /// <param name="minReplicas">
        /// MinReplicas is the minimum number of container instances to run. Defaults to 1 if not specified
        /// </param>
        /// <param name="name">
        /// Name is the unique identifier for your deployment. Must contain only alphanumeric characters, underscores, or hyphens (1-100 characters)
        /// </param>
        /// <param name="port">
        /// Port is the container port your application listens on (e.g., 8080 for web servers). Required if your application serves traffic
        /// </param>
        /// <param name="storage">
        /// Storage is the amount of ephemeral disk storage to allocate per container instance (e.g., 10 = 10GiB)
        /// </param>
        /// <param name="terminationGracePeriodSeconds">
        /// TerminationGracePeriodSeconds is the time in seconds to wait for graceful shutdown before forcefully terminating the replica
        /// </param>
        /// <param name="volumes">
        /// Volumes is a list of volume mounts to attach to the container. Each mount must reference an existing volume by name
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Together.DeploymentResponseItem> CreateDeploymentsAsync(
            string image,
            string name,
            global::System.Collections.Generic.IList<string>? args = default,
            global::Together.OneOf<global::Together.HTTPAutoscalingConfig, global::Together.QueueAutoscalingConfig, global::Together.CustomMetricAutoscalingConfig>? autoscaling = default,
            global::System.Collections.Generic.IList<string>? command = default,
            double? cpu = default,
            string? description = default,
            global::System.Collections.Generic.IList<global::Together.EnvironmentVariable>? environmentVariables = default,
            int? gpuCount = default,
            global::Together.CreateDeploymentRequestGpuType gpuType = default,
            string? healthCheckPath = default,
            int? maxReplicas = default,
            double? memory = default,
            int? minReplicas = default,
            int? port = default,
            int? storage = default,
            int? terminationGracePeriodSeconds = default,
            global::System.Collections.Generic.IList<global::Together.VolumeMount>? volumes = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Together.CreateDeploymentRequest
            {
                Args = args,
                Autoscaling = autoscaling,
                Command = command,
                Cpu = cpu,
                Description = description,
                EnvironmentVariables = environmentVariables,
                GpuCount = gpuCount,
                GpuType = gpuType,
                HealthCheckPath = healthCheckPath,
                Image = image,
                MaxReplicas = maxReplicas,
                Memory = memory,
                MinReplicas = minReplicas,
                Name = name,
                Port = port,
                Storage = storage,
                TerminationGracePeriodSeconds = terminationGracePeriodSeconds,
                Volumes = volumes,
            };

            return await CreateDeploymentsAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}