
#nullable enable

namespace Together
{
    public partial class RemediationServiceClient
    {


        private static readonly global::Together.EndPointSecurityRequirement s_RemediationServiceListRemediationsSecurityRequirement0 =
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
        private static readonly global::Together.EndPointSecurityRequirement[] s_RemediationServiceListRemediationsSecurityRequirements =
            new global::Together.EndPointSecurityRequirement[]
            {                s_RemediationServiceListRemediationsSecurityRequirement0,
            };
        partial void PrepareRemediationServiceListRemediationsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string clusterId,
            ref string instanceId,
            ref int? pageSize,
            ref string? pageToken,
            global::System.Collections.Generic.IList<global::Together.RemediationServiceListRemediationsStateItem>? state,
            ref string? orderBy,
            ref global::Together.RemediationServiceListRemediationsMode? mode);
        partial void PrepareRemediationServiceListRemediationsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string clusterId,
            string instanceId,
            int? pageSize,
            string? pageToken,
            global::System.Collections.Generic.IList<global::Together.RemediationServiceListRemediationsStateItem>? state,
            string? orderBy,
            global::Together.RemediationServiceListRemediationsMode? mode);
        partial void ProcessRemediationServiceListRemediationsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessRemediationServiceListRemediationsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Lists remediations for an instance or cluster.
        /// </summary>
        /// <param name="clusterId"></param>
        /// <param name="instanceId">
        /// To list remediations on a specific node, pass the node's instance ID.<br/>
        /// To list remediations for all nodes in a cluster, pass `-` as a wildcard for the instance ID.
        /// </param>
        /// <param name="pageSize">
        /// Maximum results to return.
        /// </param>
        /// <param name="pageToken">
        /// Pagination token from previous request.
        /// </param>
        /// <param name="state">
        /// Filter by state(s). Returns remediations matching any of the specified states.<br/>
        /// - `PENDING_APPROVAL`: Awaiting approval before processing can begin.<br/>
        /// - `PENDING`: Approved and queued for processing.<br/>
        /// - `RUNNING`: Actively being processed.<br/>
        /// - `SUCCEEDED`: Successfully completed.<br/>
        /// - `FAILED`: Failed with an error.<br/>
        /// - `CANCELLED`: Cancelled by user or system.<br/>
        /// - `AUTO_RESOLVED`: The underlying issue was automatically resolved before processing.
        /// </param>
        /// <param name="orderBy">
        /// Order by expression.
        /// </param>
        /// <param name="mode">
        /// Filter by remediation mode. Returns only remediations matching the specified mode.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// import together<br/>
        /// client = together.Together(api_key="your_api_key")<br/>
        /// remediations = client.beta.clusters.remediations.list(<br/>
        ///   cluster_id="cluster_id",<br/>
        ///   instance_id="-",<br/>
        /// )<br/>
        /// for remediation in remediations:<br/>
        ///   print(remediation)
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Together.ListRemediationsResponse> RemediationServiceListRemediationsAsync(
            string clusterId,
            string instanceId,
            int? pageSize = default,
            string? pageToken = default,
            global::System.Collections.Generic.IList<global::Together.RemediationServiceListRemediationsStateItem>? state = default,
            string? orderBy = default,
            global::Together.RemediationServiceListRemediationsMode? mode = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await RemediationServiceListRemediationsAsResponseAsync(
                clusterId: clusterId,
                instanceId: instanceId,
                pageSize: pageSize,
                pageToken: pageToken,
                state: state,
                orderBy: orderBy,
                mode: mode,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Lists remediations for an instance or cluster.
        /// </summary>
        /// <param name="clusterId"></param>
        /// <param name="instanceId">
        /// To list remediations on a specific node, pass the node's instance ID.<br/>
        /// To list remediations for all nodes in a cluster, pass `-` as a wildcard for the instance ID.
        /// </param>
        /// <param name="pageSize">
        /// Maximum results to return.
        /// </param>
        /// <param name="pageToken">
        /// Pagination token from previous request.
        /// </param>
        /// <param name="state">
        /// Filter by state(s). Returns remediations matching any of the specified states.<br/>
        /// - `PENDING_APPROVAL`: Awaiting approval before processing can begin.<br/>
        /// - `PENDING`: Approved and queued for processing.<br/>
        /// - `RUNNING`: Actively being processed.<br/>
        /// - `SUCCEEDED`: Successfully completed.<br/>
        /// - `FAILED`: Failed with an error.<br/>
        /// - `CANCELLED`: Cancelled by user or system.<br/>
        /// - `AUTO_RESOLVED`: The underlying issue was automatically resolved before processing.
        /// </param>
        /// <param name="orderBy">
        /// Order by expression.
        /// </param>
        /// <param name="mode">
        /// Filter by remediation mode. Returns only remediations matching the specified mode.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// import together<br/>
        /// client = together.Together(api_key="your_api_key")<br/>
        /// remediations = client.beta.clusters.remediations.list(<br/>
        ///   cluster_id="cluster_id",<br/>
        ///   instance_id="-",<br/>
        /// )<br/>
        /// for remediation in remediations:<br/>
        ///   print(remediation)
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.ListRemediationsResponse>> RemediationServiceListRemediationsAsResponseAsync(
            string clusterId,
            string instanceId,
            int? pageSize = default,
            string? pageToken = default,
            global::System.Collections.Generic.IList<global::Together.RemediationServiceListRemediationsStateItem>? state = default,
            string? orderBy = default,
            global::Together.RemediationServiceListRemediationsMode? mode = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareRemediationServiceListRemediationsArguments(
                httpClient: HttpClient,
                clusterId: ref clusterId,
                instanceId: ref instanceId,
                pageSize: ref pageSize,
                pageToken: ref pageToken,
                state: state,
                orderBy: ref orderBy,
                mode: ref mode);


            var __authorizations = global::Together.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_RemediationServiceListRemediationsSecurityRequirements,
                operationName: "RemediationServiceListRemediationsAsync");

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
                                path: $"/compute/clusters/{clusterId}/instances/{instanceId}/remediations",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("page_size", pageSize?.ToString())
                                .AddOptionalParameter("page_token", pageToken)
                                .AddOptionalParameter("state", state, selector: static x => x.ToValueString(), delimiter: ",", explode: true)
                                .AddOptionalParameter("order_by", orderBy)
                                .AddOptionalParameter("mode", mode?.ToValueString())
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Together.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
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
                global::Together.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareRemediationServiceListRemediationsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    clusterId: clusterId!,
                    instanceId: instanceId!,
                    pageSize: pageSize,
                    pageToken: pageToken,
                    state: state,
                    orderBy: orderBy,
                    mode: mode);

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
                                operationId: "RemediationServiceListRemediations",
                                methodName: "RemediationServiceListRemediationsAsync",
                                pathTemplate: "$\"/compute/clusters/{clusterId}/instances/{instanceId}/remediations\"",
                                httpMethod: "GET",
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
                                operationId: "RemediationServiceListRemediations",
                                methodName: "RemediationServiceListRemediationsAsync",
                                pathTemplate: "$\"/compute/clusters/{clusterId}/instances/{instanceId}/remediations\"",
                                httpMethod: "GET",
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
                                operationId: "RemediationServiceListRemediations",
                                methodName: "RemediationServiceListRemediationsAsync",
                                pathTemplate: "$\"/compute/clusters/{clusterId}/instances/{instanceId}/remediations\"",
                                httpMethod: "GET",
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
                ProcessRemediationServiceListRemediationsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Together.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Together.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "RemediationServiceListRemediations",
                                methodName: "RemediationServiceListRemediationsAsync",
                                pathTemplate: "$\"/compute/clusters/{clusterId}/instances/{instanceId}/remediations\"",
                                httpMethod: "GET",
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
                                operationId: "RemediationServiceListRemediations",
                                methodName: "RemediationServiceListRemediationsAsync",
                                pathTemplate: "$\"/compute/clusters/{clusterId}/instances/{instanceId}/remediations\"",
                                httpMethod: "GET",
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
                                ProcessRemediationServiceListRemediationsResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Together.ListRemediationsResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Together.AutoSDKHttpResponse<global::Together.ListRemediationsResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Together.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
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
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Together.ListRemediationsResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Together.AutoSDKHttpResponse<global::Together.ListRemediationsResponse>(
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
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}