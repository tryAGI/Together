#nullable enable

namespace Together
{
    public partial interface IEndpointServiceClient
    {
        /// <summary>
        /// Get endpoint analytics<br/>
        /// Returns aggregated request, token, latency, throughput, error, and resource-utilization metrics for an endpoint over a time range. Optionally includes time-series buckets and a per-deployment breakdown.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="id">
        /// Endpoint identifier.
        /// </param>
        /// <param name="deploymentId">
        /// Restrict to a single deployment under this endpoint.
        /// </param>
        /// <param name="startTime">
        /// Inclusive start of the time range. Defaults to 24 hours ago if unset.
        /// </param>
        /// <param name="endTime">
        /// Exclusive end of the time range. Defaults to now if unset.
        /// </param>
        /// <param name="includeTimeSeries">
        /// When true, include per-bucket time series in the response.
        /// </param>
        /// <param name="granularity">
        /// Time-series bucket duration, such as `1m`, `1h`, or `1d`. Defaults to `1d`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeAnalyticsData> EndpointServiceGetEndpointAnalyticsAsync(
            string projectId,
            string id,
            string? deploymentId = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            bool? includeTimeSeries = default,
            string? granularity = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get endpoint analytics<br/>
        /// Returns aggregated request, token, latency, throughput, error, and resource-utilization metrics for an endpoint over a time range. Optionally includes time-series buckets and a per-deployment breakdown.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="id">
        /// Endpoint identifier.
        /// </param>
        /// <param name="deploymentId">
        /// Restrict to a single deployment under this endpoint.
        /// </param>
        /// <param name="startTime">
        /// Inclusive start of the time range. Defaults to 24 hours ago if unset.
        /// </param>
        /// <param name="endTime">
        /// Exclusive end of the time range. Defaults to now if unset.
        /// </param>
        /// <param name="includeTimeSeries">
        /// When true, include per-bucket time series in the response.
        /// </param>
        /// <param name="granularity">
        /// Time-series bucket duration, such as `1m`, `1h`, or `1d`. Defaults to `1d`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeAnalyticsData>> EndpointServiceGetEndpointAnalyticsAsResponseAsync(
            string projectId,
            string id,
            string? deploymentId = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            bool? includeTimeSeries = default,
            string? granularity = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}