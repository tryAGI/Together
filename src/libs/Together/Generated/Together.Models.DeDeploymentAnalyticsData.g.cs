
#nullable enable

namespace Together
{
    /// <summary>
    /// Usage and performance analytics for one deployment under an endpoint.
    /// </summary>
    public sealed partial class DeDeploymentAnalyticsData
    {
        /// <summary>
        /// ID of the deployment summarized by these analytics.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentId")]
        public string? DeploymentId { get; set; }

        /// <summary>
        /// ID of the deployment's parent endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpointId")]
        public string? EndpointId { get; set; }

        /// <summary>
        /// Closed-open time range covered by the analytics.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeRange")]
        public global::Together.DeMetricsTimeRange? TimeRange { get; set; }

        /// <summary>
        /// Aggregate operational metrics for the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        public global::Together.DeDeploymentMetrics? Metrics { get; set; }

        /// <summary>
        /// Per-bucket metric samples for the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeSeries")]
        public global::System.Collections.Generic.IList<global::Together.DeTimeSeriesDataPoint>? TimeSeries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeDeploymentAnalyticsData" /> class.
        /// </summary>
        /// <param name="deploymentId">
        /// ID of the deployment summarized by these analytics.
        /// </param>
        /// <param name="endpointId">
        /// ID of the deployment's parent endpoint.
        /// </param>
        /// <param name="timeRange">
        /// Closed-open time range covered by the analytics.
        /// </param>
        /// <param name="metrics">
        /// Aggregate operational metrics for the deployment.
        /// </param>
        /// <param name="timeSeries">
        /// Per-bucket metric samples for the deployment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeDeploymentAnalyticsData(
            string? deploymentId,
            string? endpointId,
            global::Together.DeMetricsTimeRange? timeRange,
            global::Together.DeDeploymentMetrics? metrics,
            global::System.Collections.Generic.IList<global::Together.DeTimeSeriesDataPoint>? timeSeries)
        {
            this.DeploymentId = deploymentId;
            this.EndpointId = endpointId;
            this.TimeRange = timeRange;
            this.Metrics = metrics;
            this.TimeSeries = timeSeries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeDeploymentAnalyticsData" /> class.
        /// </summary>
        public DeDeploymentAnalyticsData()
        {
        }

    }
}