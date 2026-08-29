#nullable enable

namespace Together
{
    public partial interface IHealthCheckServiceClient
    {
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
        global::System.Threading.Tasks.Task<global::Together.ListPassiveHealthCheckAlertsResponse> HealthCheckServiceListPassiveHealthCheckAlertsAsync(
            string? intentId = default,
            string? instanceId = default,
            string? clusterId = default,
            int? pageSize = default,
            string? pageToken = default,
            global::Together.HealthCheckServiceListPassiveHealthCheckAlertsStatus? status = default,
            global::System.Collections.Generic.IList<global::Together.HealthCheckServiceListPassiveHealthCheckAlertsSeverityFilterItem>? severityFilter = default,
            global::Together.HealthCheckServiceListPassiveHealthCheckAlertsOrderBy? orderBy = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
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
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.ListPassiveHealthCheckAlertsResponse>> HealthCheckServiceListPassiveHealthCheckAlertsAsResponseAsync(
            string? intentId = default,
            string? instanceId = default,
            string? clusterId = default,
            int? pageSize = default,
            string? pageToken = default,
            global::Together.HealthCheckServiceListPassiveHealthCheckAlertsStatus? status = default,
            global::System.Collections.Generic.IList<global::Together.HealthCheckServiceListPassiveHealthCheckAlertsSeverityFilterItem>? severityFilter = default,
            global::Together.HealthCheckServiceListPassiveHealthCheckAlertsOrderBy? orderBy = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}