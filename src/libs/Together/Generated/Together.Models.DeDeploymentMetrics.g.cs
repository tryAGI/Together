
#nullable enable

namespace Together
{
    /// <summary>
    /// Operational metrics for one deployment under an endpoint.
    /// </summary>
    public sealed partial class DeDeploymentMetrics
    {
        /// <summary>
        /// ID of the deployment summarized by these metrics.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentId")]
        public string? DeploymentId { get; set; }

        /// <summary>
        /// ID of the deployment's parent endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpointId")]
        public string? EndpointId { get; set; }

        /// <summary>
        /// Closed-open time range covered by the metrics.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeRange")]
        public global::Together.DeMetricsTimeRange? TimeRange { get; set; }

        /// <summary>
        /// Request counts and rates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestMetrics")]
        public global::Together.DeRequestMetrics? RequestMetrics { get; set; }

        /// <summary>
        /// Time-to-first-token, end-to-end, and inter-token latency percentiles.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latencyMetrics")]
        public global::Together.DeLatencyMetrics? LatencyMetrics { get; set; }

        /// <summary>
        /// Token, request, and batching throughput.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("throughputMetrics")]
        public global::Together.DeThroughputMetrics? ThroughputMetrics { get; set; }

        /// <summary>
        /// Error rate and counts by error type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorMetrics")]
        public global::Together.DeErrorMetrics? ErrorMetrics { get; set; }

        /// <summary>
        /// Average CPU, GPU, memory, and network utilization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceUtilization")]
        public global::Together.DeResourceUtilization? ResourceUtilization { get; set; }

        /// <summary>
        /// Input and output token totals and averages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenMetrics")]
        public global::Together.DeTokenMetrics? TokenMetrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeDeploymentMetrics" /> class.
        /// </summary>
        /// <param name="deploymentId">
        /// ID of the deployment summarized by these metrics.
        /// </param>
        /// <param name="endpointId">
        /// ID of the deployment's parent endpoint.
        /// </param>
        /// <param name="timeRange">
        /// Closed-open time range covered by the metrics.
        /// </param>
        /// <param name="requestMetrics">
        /// Request counts and rates.
        /// </param>
        /// <param name="latencyMetrics">
        /// Time-to-first-token, end-to-end, and inter-token latency percentiles.
        /// </param>
        /// <param name="throughputMetrics">
        /// Token, request, and batching throughput.
        /// </param>
        /// <param name="errorMetrics">
        /// Error rate and counts by error type.
        /// </param>
        /// <param name="resourceUtilization">
        /// Average CPU, GPU, memory, and network utilization.
        /// </param>
        /// <param name="tokenMetrics">
        /// Input and output token totals and averages.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeDeploymentMetrics(
            string? deploymentId,
            string? endpointId,
            global::Together.DeMetricsTimeRange? timeRange,
            global::Together.DeRequestMetrics? requestMetrics,
            global::Together.DeLatencyMetrics? latencyMetrics,
            global::Together.DeThroughputMetrics? throughputMetrics,
            global::Together.DeErrorMetrics? errorMetrics,
            global::Together.DeResourceUtilization? resourceUtilization,
            global::Together.DeTokenMetrics? tokenMetrics)
        {
            this.DeploymentId = deploymentId;
            this.EndpointId = endpointId;
            this.TimeRange = timeRange;
            this.RequestMetrics = requestMetrics;
            this.LatencyMetrics = latencyMetrics;
            this.ThroughputMetrics = throughputMetrics;
            this.ErrorMetrics = errorMetrics;
            this.ResourceUtilization = resourceUtilization;
            this.TokenMetrics = tokenMetrics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeDeploymentMetrics" /> class.
        /// </summary>
        public DeDeploymentMetrics()
        {
        }

    }
}