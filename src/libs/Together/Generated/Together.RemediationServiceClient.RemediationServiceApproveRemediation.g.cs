
#nullable enable

namespace Together
{
    public partial class RemediationServiceClient
    {

        private static readonly global::Together.AutoSDKServer[] s_RemediationServiceApproveRemediationServers = new global::Together.AutoSDKServer[]
        {            new global::Together.AutoSDKServer(
                id: "https-api-together-ai-v1",
                name: "Default environment for APIs",
                url: "https://api.together.ai/v1",
                description: "Default environment for APIs"),
            new global::Together.AutoSDKServer(
                id: "https-api-inference-together-ai-v2",
                name: "Optimized environment for inference",
                url: "https://api-inference.together.ai/v2",
                description: "Optimized environment for inference"),
        };


        private static readonly global::Together.EndPointSecurityRequirement s_RemediationServiceApproveRemediationSecurityRequirement0 =
            new global::Together.EndPointSecurityRequirement
            {
                Authorizations = new global::Together.EndPointAuthorizationRequirement[]
                {                    new global::Together.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "BearerAuth",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Together.EndPointSecurityRequirement[] s_RemediationServiceApproveRemediationSecurityRequirements =
            new global::Together.EndPointSecurityRequirement[]
            {                s_RemediationServiceApproveRemediationSecurityRequirement0,
            };
        partial void PrepareRemediationServiceApproveRemediationArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string clusterId,
            ref string instanceId,
            ref string remediationId,
            global::Together.ApproveRemediationRequest request);
        partial void PrepareRemediationServiceApproveRemediationRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string clusterId,
            string instanceId,
            string remediationId,
            global::Together.ApproveRemediationRequest request);
        partial void ProcessRemediationServiceApproveRemediationResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessRemediationServiceApproveRemediationResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Approves a pending remediation.<br/>
        /// Only remediations with state PENDING_APPROVAL can be approved.<br/>
        /// On APPROVE: state changes to PENDING and the remediation process begins.<br/>
        /// The reviewed_by, review_time, and review_comment fields are populated<br/>
        /// on the remediation after approval.
        /// </summary>
        /// <param name="clusterId"></param>
        /// <param name="instanceId"></param>
        /// <param name="remediationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Together.Remediation> RemediationServiceApproveRemediationAsync(
            string clusterId,
            string instanceId,
            string remediationId,

            global::Together.ApproveRemediationRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await RemediationServiceApproveRemediationAsResponseAsync(
                clusterId: clusterId,
                instanceId: instanceId,
                remediationId: remediationId,

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Approves a pending remediation.<br/>
        /// Only remediations with state PENDING_APPROVAL can be approved.<br/>
        /// On APPROVE: state changes to PENDING and the remediation process begins.<br/>
        /// The reviewed_by, review_time, and review_comment fields are populated<br/>
        /// on the remediation after approval.
        /// </summary>
        /// <param name="clusterId"></param>
        /// <param name="instanceId"></param>
        /// <param name="remediationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.Remediation>> RemediationServiceApproveRemediationAsResponseAsync(
            string clusterId,
            string instanceId,
            string remediationId,

            global::Together.ApproveRemediationRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareRemediationServiceApproveRemediationArguments(
                httpClient: HttpClient,
                clusterId: ref clusterId,
                instanceId: ref instanceId,
                remediationId: ref remediationId,
                request: request);


            var __authorizations = global::Together.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_RemediationServiceApproveRemediationSecurityRequirements,
                operationName: "RemediationServiceApproveRemediationAsync");

            using var __timeoutCancellationTokenSource = global::Together.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Together.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Together.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Together.PathBuilder(
                                path: $"/compute/clusters/{clusterId}/instances/{instanceId}/remediations/{remediationId}/approve",
                                baseUri: ResolveBaseUri(
                                servers: s_RemediationServiceApproveRemediationServers,
                                defaultBaseUrl: "https://api.together.ai/v1"));
                            var __path = __pathBuilder.ToString();
                __path = global::Together.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                global::Together.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareRemediationServiceApproveRemediationRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    clusterId: clusterId!,
                    instanceId: instanceId!,
                    remediationId: remediationId!,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Together.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Together.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "RemediationServiceApproveRemediation",
                                methodName: "RemediationServiceApproveRemediationAsync",
                                pathTemplate: "$\"/compute/clusters/{clusterId}/instances/{instanceId}/remediations/{remediationId}/approve\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Together.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Together.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Together.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "RemediationServiceApproveRemediation",
                                methodName: "RemediationServiceApproveRemediationAsync",
                                pathTemplate: "$\"/compute/clusters/{clusterId}/instances/{instanceId}/remediations/{remediationId}/approve\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Together.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Together.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Together.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Together.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Together.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "RemediationServiceApproveRemediation",
                                methodName: "RemediationServiceApproveRemediationAsync",
                                pathTemplate: "$\"/compute/clusters/{clusterId}/instances/{instanceId}/remediations/{remediationId}/approve\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Together.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessRemediationServiceApproveRemediationResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Together.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Together.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "RemediationServiceApproveRemediation",
                                methodName: "RemediationServiceApproveRemediationAsync",
                                pathTemplate: "$\"/compute/clusters/{clusterId}/instances/{instanceId}/remediations/{remediationId}/approve\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Together.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Together.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "RemediationServiceApproveRemediation",
                                methodName: "RemediationServiceApproveRemediationAsync",
                                pathTemplate: "$\"/compute/clusters/{clusterId}/instances/{instanceId}/remediations/{remediationId}/approve\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessRemediationServiceApproveRemediationResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Together.Remediation.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Together.AutoSDKHttpResponse<global::Together.Remediation>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Together.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::Together.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Together.Remediation.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Together.AutoSDKHttpResponse<global::Together.Remediation>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Together.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::Together.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Approves a pending remediation.<br/>
        /// Only remediations with state PENDING_APPROVAL can be approved.<br/>
        /// On APPROVE: state changes to PENDING and the remediation process begins.<br/>
        /// The reviewed_by, review_time, and review_comment fields are populated<br/>
        /// on the remediation after approval.
        /// </summary>
        /// <param name="clusterId"></param>
        /// <param name="instanceId"></param>
        /// <param name="remediationId"></param>
        /// <param name="comment">
        /// Approval comment explaining the decision.
        /// </param>
        /// <param name="mode">
        /// Remediation mode to use after approval. When omitted, the remediation keeps its existing mode.<br/>
        /// - `REMEDIATION_MODE_VM_ONLY`: Deletes the VM and provisions a new one on any available host.<br/>
        /// - `REMEDIATION_MODE_HOST_AWARE`: Cordons the host, deletes the VM, and provisions a new one on a different host.<br/>
        /// - `REMEDIATION_MODE_EVICT_WITHOUT_REPLACEMENT`: Evicts the VM without provisioning a replacement.<br/>
        /// - `REMEDIATION_MODE_REBOOT_VM`: Reboots the VM in place.<br/>
        /// - `REMEDIATION_MODE_HOST_POWER_CYCLE`: Power-cycles the bare-metal host after cordoning it. This mode cannot be set as an approval override; create a host power-cycle remediation directly.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Together.Remediation> RemediationServiceApproveRemediationAsync(
            string clusterId,
            string instanceId,
            string remediationId,
            string? comment = default,
            global::Together.ApproveRemediationRequestMode? mode = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Together.ApproveRemediationRequest
            {
                Comment = comment,
                Mode = mode,
            };

            return await RemediationServiceApproveRemediationAsync(
                clusterId: clusterId,
                instanceId: instanceId,
                remediationId: remediationId,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}