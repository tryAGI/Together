
#nullable enable

namespace Together
{
    public partial class EndpointServiceClient
    {

        private static readonly global::Together.AutoSDKServer[] s_EndpointServiceListEndpointEventsServers = new global::Together.AutoSDKServer[]
        {            new global::Together.AutoSDKServer(
                id: "https-api-together-ai-v2",
                name: "api.together.ai v2",
                url: "https://api.together.ai/v2",
                description: ""),
        };


        private static readonly global::Together.EndPointSecurityRequirement s_EndpointServiceListEndpointEventsSecurityRequirement0 =
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
        private static readonly global::Together.EndPointSecurityRequirement[] s_EndpointServiceListEndpointEventsSecurityRequirements =
            new global::Together.EndPointSecurityRequirement[]
            {                s_EndpointServiceListEndpointEventsSecurityRequirement0,
            };
        partial void PrepareEndpointServiceListEndpointEventsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string projectId,
            ref string id,
            ref int? limit,
            ref string? after,
            global::System.Collections.Generic.IList<string>? types,
            ref global::Together.EndpointServiceListEndpointEventsMinLevel? minLevel,
            ref global::System.DateTime? since,
            ref global::System.DateTime? until,
            global::System.Collections.Generic.IList<string>? deploymentIds,
            global::System.Collections.Generic.IList<global::Together.EndpointServiceListEndpointEventsSourceKind>? sourceKinds,
            ref string? subjectId);
        partial void PrepareEndpointServiceListEndpointEventsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string projectId,
            string id,
            int? limit,
            string? after,
            global::System.Collections.Generic.IList<string>? types,
            global::Together.EndpointServiceListEndpointEventsMinLevel? minLevel,
            global::System.DateTime? since,
            global::System.DateTime? until,
            global::System.Collections.Generic.IList<string>? deploymentIds,
            global::System.Collections.Generic.IList<global::Together.EndpointServiceListEndpointEventsSourceKind>? sourceKinds,
            string? subjectId);
        partial void ProcessEndpointServiceListEndpointEventsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessEndpointServiceListEndpointEventsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List endpoint events<br/>
        /// Lists an endpoint's audit and lifecycle events newest first. The feed combines endpoint changes with provisioning, scaling, readiness, rollout, and other events from deployments under the endpoint.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="id">
        /// Endpoint identifier.
        /// </param>
        /// <param name="limit">
        /// Maximum number of events to return. Max 10000, defaults to 50.
        /// </param>
        /// <param name="after">
        /// Cursor from a previous endpoint event list response.
        /// </param>
        /// <param name="types">
        /// Event types to include, such as `deployment.scaled` or `condition.set`. Combined with other filters using AND.
        /// </param>
        /// <param name="minLevel">
        /// Minimum severity. Omit to disable severity filtering.
        /// </param>
        /// <param name="since">
        /// Return only events at or after this time.
        /// </param>
        /// <param name="until">
        /// Return only events strictly before this time.
        /// </param>
        /// <param name="deploymentIds">
        /// Deployment IDs whose events should be included. Every ID must belong to the endpoint. Supplying this filter excludes endpoint-scoped events unless `SOURCE_KIND_ENDPOINT` is also included in `sourceKinds`.
        /// </param>
        /// <param name="sourceKinds">
        /// Resource kinds whose events should be included. Omit to include both endpoint- and deployment-scoped events.
        /// </param>
        /// <param name="subjectId">
        /// ID of a subject associated with the event, such as a rollout. Combined with other filters using AND.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Together.DeListEndpointEventsResponse> EndpointServiceListEndpointEventsAsync(
            string projectId,
            string id,
            int? limit = default,
            string? after = default,
            global::System.Collections.Generic.IList<string>? types = default,
            global::Together.EndpointServiceListEndpointEventsMinLevel? minLevel = default,
            global::System.DateTime? since = default,
            global::System.DateTime? until = default,
            global::System.Collections.Generic.IList<string>? deploymentIds = default,
            global::System.Collections.Generic.IList<global::Together.EndpointServiceListEndpointEventsSourceKind>? sourceKinds = default,
            string? subjectId = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await EndpointServiceListEndpointEventsAsResponseAsync(
                projectId: projectId,
                id: id,
                limit: limit,
                after: after,
                types: types,
                minLevel: minLevel,
                since: since,
                until: until,
                deploymentIds: deploymentIds,
                sourceKinds: sourceKinds,
                subjectId: subjectId,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// List endpoint events<br/>
        /// Lists an endpoint's audit and lifecycle events newest first. The feed combines endpoint changes with provisioning, scaling, readiness, rollout, and other events from deployments under the endpoint.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="id">
        /// Endpoint identifier.
        /// </param>
        /// <param name="limit">
        /// Maximum number of events to return. Max 10000, defaults to 50.
        /// </param>
        /// <param name="after">
        /// Cursor from a previous endpoint event list response.
        /// </param>
        /// <param name="types">
        /// Event types to include, such as `deployment.scaled` or `condition.set`. Combined with other filters using AND.
        /// </param>
        /// <param name="minLevel">
        /// Minimum severity. Omit to disable severity filtering.
        /// </param>
        /// <param name="since">
        /// Return only events at or after this time.
        /// </param>
        /// <param name="until">
        /// Return only events strictly before this time.
        /// </param>
        /// <param name="deploymentIds">
        /// Deployment IDs whose events should be included. Every ID must belong to the endpoint. Supplying this filter excludes endpoint-scoped events unless `SOURCE_KIND_ENDPOINT` is also included in `sourceKinds`.
        /// </param>
        /// <param name="sourceKinds">
        /// Resource kinds whose events should be included. Omit to include both endpoint- and deployment-scoped events.
        /// </param>
        /// <param name="subjectId">
        /// ID of a subject associated with the event, such as a rollout. Combined with other filters using AND.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeListEndpointEventsResponse>> EndpointServiceListEndpointEventsAsResponseAsync(
            string projectId,
            string id,
            int? limit = default,
            string? after = default,
            global::System.Collections.Generic.IList<string>? types = default,
            global::Together.EndpointServiceListEndpointEventsMinLevel? minLevel = default,
            global::System.DateTime? since = default,
            global::System.DateTime? until = default,
            global::System.Collections.Generic.IList<string>? deploymentIds = default,
            global::System.Collections.Generic.IList<global::Together.EndpointServiceListEndpointEventsSourceKind>? sourceKinds = default,
            string? subjectId = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareEndpointServiceListEndpointEventsArguments(
                httpClient: HttpClient,
                projectId: ref projectId,
                id: ref id,
                limit: ref limit,
                after: ref after,
                types: types,
                minLevel: ref minLevel,
                since: ref since,
                until: ref until,
                deploymentIds: deploymentIds,
                sourceKinds: sourceKinds,
                subjectId: ref subjectId);


            var __authorizations = global::Together.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_EndpointServiceListEndpointEventsSecurityRequirements,
                operationName: "EndpointServiceListEndpointEventsAsync");

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
                                path: $"/projects/{projectId}/endpoints/{id}/events",
                                baseUri: ResolveBaseUri(
                                servers: s_EndpointServiceListEndpointEventsServers,
                                defaultBaseUrl: "https://api.together.ai/v2"));
                            __pathBuilder
                                .AddOptionalParameter("limit", limit?.ToString())
                                .AddOptionalParameter("after", after)
                                .AddOptionalParameter("types", types, delimiter: ",", explode: true)
                                .AddOptionalParameter("minLevel", minLevel?.ToValueString())
                                .AddOptionalParameter("since", since?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("until", until?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("deploymentIds", deploymentIds, delimiter: ",", explode: true)
                                .AddOptionalParameter("sourceKinds", sourceKinds, selector: static x => x.ToValueString(), delimiter: ",", explode: true)
                                .AddOptionalParameter("subjectId", subjectId)
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
                PrepareEndpointServiceListEndpointEventsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    projectId: projectId!,
                    id: id!,
                    limit: limit,
                    after: after,
                    types: types,
                    minLevel: minLevel,
                    since: since,
                    until: until,
                    deploymentIds: deploymentIds,
                    sourceKinds: sourceKinds,
                    subjectId: subjectId);

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
                                operationId: "EndpointServiceListEndpointEvents",
                                methodName: "EndpointServiceListEndpointEventsAsync",
                                pathTemplate: "$\"/projects/{projectId}/endpoints/{id}/events\"",
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
                                operationId: "EndpointServiceListEndpointEvents",
                                methodName: "EndpointServiceListEndpointEventsAsync",
                                pathTemplate: "$\"/projects/{projectId}/endpoints/{id}/events\"",
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
                                operationId: "EndpointServiceListEndpointEvents",
                                methodName: "EndpointServiceListEndpointEventsAsync",
                                pathTemplate: "$\"/projects/{projectId}/endpoints/{id}/events\"",
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
                ProcessEndpointServiceListEndpointEventsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Together.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Together.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "EndpointServiceListEndpointEvents",
                                methodName: "EndpointServiceListEndpointEventsAsync",
                                pathTemplate: "$\"/projects/{projectId}/endpoints/{id}/events\"",
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
                                operationId: "EndpointServiceListEndpointEvents",
                                methodName: "EndpointServiceListEndpointEventsAsync",
                                pathTemplate: "$\"/projects/{projectId}/endpoints/{id}/events\"",
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
                            // Default error response
                            if (!__response.IsSuccessStatusCode)
                            {
                                string? __content_default = null;
                                global::System.Exception? __exception_default = null;
                                global::Together.ErrorData? __value_default = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_default = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_default = global::Together.ErrorData.FromJson(__content_default, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_default = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_default = global::Together.ErrorData.FromJson(__content_default, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_default = __ex;
                                }


                                throw global::Together.ApiException<global::Together.ErrorData>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_default ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_default,
                                    responseBody: __content_default,
                                    responseObject: __value_default,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
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
                                ProcessEndpointServiceListEndpointEventsResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Together.DeListEndpointEventsResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Together.AutoSDKHttpResponse<global::Together.DeListEndpointEventsResponse>(
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

                                    var __value = await global::Together.DeListEndpointEventsResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Together.AutoSDKHttpResponse<global::Together.DeListEndpointEventsResponse>(
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