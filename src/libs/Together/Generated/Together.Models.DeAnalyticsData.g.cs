
#nullable enable

namespace Together
{
    /// <summary>
    /// Endpoint-wide usage and performance analytics with optional time-series and per-deployment breakdowns.
    /// </summary>
    public sealed partial class DeAnalyticsData
    {
        /// <summary>
        /// ID of the endpoint summarized by these analytics.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpointId")]
        public string? EndpointId { get; set; }

        /// <summary>
        /// Closed-open time range covered by the analytics.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeRange")]
        public global::Together.DeMetricsTimeRange? TimeRange { get; set; }

        /// <summary>
        /// Aggregated metrics over the time range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        public global::Together.DeEndpointMetrics? Metrics { get; set; }

        /// <summary>
        /// Per-bucket metric samples, included only when `includeTimeSeries` is true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeSeries")]
        public global::System.Collections.Generic.IList<global::Together.DeTimeSeriesDataPoint>? TimeSeries { get; set; }

        /// <summary>
        /// Per-deployment analytics.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentAnalytics")]
        public global::System.Collections.Generic.IList<global::Together.DeDeploymentAnalyticsData>? DeploymentAnalytics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeAnalyticsData" /> class.
        /// </summary>
        /// <param name="endpointId">
        /// ID of the endpoint summarized by these analytics.
        /// </param>
        /// <param name="timeRange">
        /// Closed-open time range covered by the analytics.
        /// </param>
        /// <param name="metrics">
        /// Aggregated metrics over the time range.
        /// </param>
        /// <param name="timeSeries">
        /// Per-bucket metric samples, included only when `includeTimeSeries` is true.
        /// </param>
        /// <param name="deploymentAnalytics">
        /// Per-deployment analytics.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeAnalyticsData(
            string? endpointId,
            global::Together.DeMetricsTimeRange? timeRange,
            global::Together.DeEndpointMetrics? metrics,
            global::System.Collections.Generic.IList<global::Together.DeTimeSeriesDataPoint>? timeSeries,
            global::System.Collections.Generic.IList<global::Together.DeDeploymentAnalyticsData>? deploymentAnalytics)
        {
            this.EndpointId = endpointId;
            this.TimeRange = timeRange;
            this.Metrics = metrics;
            this.TimeSeries = timeSeries;
            this.DeploymentAnalytics = deploymentAnalytics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeAnalyticsData" /> class.
        /// </summary>
        public DeAnalyticsData()
        {
        }

    }
}