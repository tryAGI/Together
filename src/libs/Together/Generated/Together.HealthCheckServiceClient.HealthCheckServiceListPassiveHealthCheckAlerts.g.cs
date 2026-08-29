
#nullable enable

namespace Together
{
    public partial class HealthCheckServiceClient
    {

        private static readonly global::Together.AutoSDKServer[] s_HealthCheckServiceListPassiveHealthCheckAlertsServers = new global::Together.AutoSDKServer[]
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


        private static readonly global::Together.EndPointSecurityRequirement s_HealthCheckServiceListPassiveHealthCheckAlertsSecurityRequirement0 =
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
        private static readonly global::Together.EndPointSecurityRequirement[] s_HealthCheckServiceListPassiveHealthCheckAlertsSecurityRequirements =
            new global::Together.EndPointSecurityRequirement[]
            {                s_HealthCheckServiceListPassiveHealthCheckAlertsSecurityRequirement0,
            };
        partial void PrepareHealthCheckServiceListPassiveHealthCheckAlertsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? intentId,
            ref string? instanceId,
            ref string? clusterId,
            ref int? pageSize,
            ref string? pageToken,
            ref global::Together.HealthCheckServiceListPassiveHealthCheckAlertsStatus? status,
            global::System.Collections.Generic.IList<global::Together.HealthCheckServiceListPassiveHealthCheckAlertsSeverityFilterItem>? severityFilter,
            ref global::Together.HealthCheckServiceListPassiveHealthCheckAlertsOrderBy? orderBy);
        partial void PrepareHealthCheckServiceListPassiveHealthCheckAlertsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? intentId,
            string? instanceId,
            string? clusterId,
            int? pageSize,
            string? pageToken,
            global::Together.HealthCheckServiceListPassiveHealthCheckAlertsStatus? status,
            global::System.Collections.Generic.IList<global::Together.HealthCheckServiceListPassiveHealthCheckAlertsSeverityFilterItem>? severityFilter,
            global::Together.HealthCheckServiceListPassiveHealthCheckAlertsOrderBy? orderBy);
        partial void ProcessHealthCheckServiceListPassiveHealthCheckAlertsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessHealthCheckServiceListPassiveHealthCheckAlertsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List passive health check alerts<br/>
        /// Lists passive health check alerts. Filters combine across axes; empty values skip that axis.
        /// </summary>
        /// <param name="intentId">
        /// Remediation intent ID to filter by.
        /// </param>
        /// <param name="instanceId">
        /// Instance ID to filter by.
        /// </param>
        /// <param name="clusterId">
        /// Optional instance cluster ID to filter by. Required for non-admin callers.
        /// </param>
        /// <param name="pageSize">
        /// Max number of results to return.<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="pageToken">
        /// Opaque pagination token from the previous response.
        /// </param>
        /// <param name="status">
        /// Lifecycle filter. Omit to return firing alerts.
        /// </param>
        /// <param name="severityFilter">
        /// Severity tiers to include. Omit or pass an empty array to include all severities.
        /// </param>
        /// <param name="orderBy">
        /// Sort order for returned alerts. Omit for newest alerts first.<br/>
        /// Default Value: PHC_ALERT_ORDER_STARTED_AT_DESC
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Together.ListPassiveHealthCheckAlertsResponse> HealthCheckServiceListPassiveHealthCheckAlertsAsync(
            string? intentId = default,
            string? instanceId = default,
            string? clusterId = default,
            int? pageSize = default,
            string? pageToken = default,
            global::Together.HealthCheckServiceListPassiveHealthCheckAlertsStatus? status = default,
            global::System.Collections.Generic.IList<global::Together.HealthCheckServiceListPassiveHealthCheckAlertsSeverityFilterItem>? severityFilter = default,
            global::Together.HealthCheckServiceListPassiveHealthCheckAlertsOrderBy? orderBy = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await HealthCheckServiceListPassiveHealthCheckAlertsAsResponseAsync(
                intentId: intentId,
                instanceId: instanceId,
                clusterId: clusterId,
                pageSize: pageSize,
                pageToken: pageToken,
                status: status,
                severityFilter: severityFilter,
                orderBy: orderBy,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// List passive health check alerts<br/>
        /// Lists passive health check alerts. Filters combine across axes; empty values skip that axis.
        /// </summary>
        /// <param name="intentId">
        /// Remediation intent ID to filter by.
        /// </param>
        /// <param name="instanceId">
        /// Instance ID to filter by.
        /// </param>
        /// <param name="clusterId">
        /// Optional instance cluster ID to filter by. Required for non-admin callers.
        /// </param>
        /// <param name="pageSize">
        /// Max number of results to return.<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="pageToken">
        /// Opaque pagination token from the previous response.
        /// </param>
        /// <param name="status">
        /// Lifecycle filter. Omit to return firing alerts.
        /// </param>
        /// <param name="severityFilter">
        /// Severity tiers to include. Omit or pass an empty array to include all severities.
        /// </param>
        /// <param name="orderBy">
        /// Sort order for returned alerts. Omit for newest alerts first.<br/>
        /// Default Value: PHC_ALERT_ORDER_STARTED_AT_DESC
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.ListPassiveHealthCheckAlertsResponse>> HealthCheckServiceListPassiveHealthCheckAlertsAsResponseAsync(
            string? intentId = default,
            string? instanceId = default,
            string? clusterId = default,
            int? pageSize = default,
            string? pageToken = default,
            global::Together.HealthCheckServiceListPassiveHealthCheckAlertsStatus? status = default,
            global::System.Collections.Generic.IList<global::Together.HealthCheckServiceListPassiveHealthCheckAlertsSeverityFilterItem>? severityFilter = default,
            global::Together.HealthCheckServiceListPassiveHealthCheckAlertsOrderBy? orderBy = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareHealthCheckServiceListPassiveHealthCheckAlertsArguments(
                httpClient: HttpClient,
                intentId: ref intentId,
                instanceId: ref instanceId,
                clusterId: ref clusterId,
                pageSize: ref pageSize,
                pageToken: ref pageToken,
                status: ref status,
                severityFilter: severityFilter,
                orderBy: ref orderBy);


            var __authorizations = global::Together.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_HealthCheckServiceListPassiveHealthCheckAlertsSecurityRequirements,
                operationName: "HealthCheckServiceListPassiveHealthCheckAlertsAsync");

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
                                path: "/compute/passive_health_check_alerts",
                                baseUri: ResolveBaseUri(
                                servers: s_HealthCheckServiceListPassiveHealthCheckAlertsServers,
                                defaultBaseUrl: "https://api.together.ai/v1"));
                            __pathBuilder
                                .AddOptionalParameter("intent_id", intentId)
                                .AddOptionalParameter("instance_id", instanceId)
                                .AddOptionalParameter("cluster_id", clusterId)
                                .AddOptionalParameter("page_size", pageSize?.ToString())
                                .AddOptionalParameter("page_token", pageToken)
                                .AddOptionalParameter("status", status?.ToValueString())
                                .AddOptionalParameter("severity_filter", severityFilter, selector: static x => x.ToValueString(), delimiter: ",", explode: true)
                                .AddOptionalParameter("order_by", orderBy?.ToValueString())
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
                PrepareHealthCheckServiceListPassiveHealthCheckAlertsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    intentId: intentId,
                    instanceId: instanceId,
                    clusterId: clusterId,
                    pageSize: pageSize,
                    pageToken: pageToken,
                    status: status,
                    severityFilter: severityFilter,
                    orderBy: orderBy);

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
                                operationId: "HealthCheckServiceListPassiveHealthCheckAlerts",
                                methodName: "HealthCheckServiceListPassiveHealthCheckAlertsAsync",
                                pathTemplate: "\"/compute/passive_health_check_alerts\"",
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
                                operationId: "HealthCheckServiceListPassiveHealthCheckAlerts",
                                methodName: "HealthCheckServiceListPassiveHealthCheckAlertsAsync",
                                pathTemplate: "\"/compute/passive_health_check_alerts\"",
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
                                operationId: "HealthCheckServiceListPassiveHealthCheckAlerts",
                                methodName: "HealthCheckServiceListPassiveHealthCheckAlertsAsync",
                                pathTemplate: "\"/compute/passive_health_check_alerts\"",
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
                ProcessHealthCheckServiceListPassiveHealthCheckAlertsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Together.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Together.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "HealthCheckServiceListPassiveHealthCheckAlerts",
                                methodName: "HealthCheckServiceListPassiveHealthCheckAlertsAsync",
                                pathTemplate: "\"/compute/passive_health_check_alerts\"",
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
                                operationId: "HealthCheckServiceListPassiveHealthCheckAlerts",
                                methodName: "HealthCheckServiceListPassiveHealthCheckAlertsAsync",
                                pathTemplate: "\"/compute/passive_health_check_alerts\"",
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
                                ProcessHealthCheckServiceListPassiveHealthCheckAlertsResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Together.ListPassiveHealthCheckAlertsResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Together.AutoSDKHttpResponse<global::Together.ListPassiveHealthCheckAlertsResponse>(
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

                                    var __value = await global::Together.ListPassiveHealthCheckAlertsResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Together.AutoSDKHttpResponse<global::Together.ListPassiveHealthCheckAlertsResponse>(
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
    }
}