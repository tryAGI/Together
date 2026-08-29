
#nullable enable

namespace Together
{
    /// <summary>
    /// Operational metrics aggregated across all deployments receiving traffic for an endpoint.
    /// </summary>
    public sealed partial class DeEndpointMetrics
    {
        /// <summary>
        /// The endpoint these metrics describe.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpointId")]
        public string? EndpointId { get; set; }

        /// <summary>
        /// Time range covered by the metrics.
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
        /// Per-deployment breakdown, if the endpoint has multiple deployments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentMetrics")]
        public global::System.Collections.Generic.IList<global::Together.DeDeploymentMetrics>? DeploymentMetrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeEndpointMetrics" /> class.
        /// </summary>
        /// <param name="endpointId">
        /// The endpoint these metrics describe.
        /// </param>
        /// <param name="timeRange">
        /// Time range covered by the metrics.
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
        /// <param name="deploymentMetrics">
        /// Per-deployment breakdown, if the endpoint has multiple deployments.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeEndpointMetrics(
            string? endpointId,
            global::Together.DeMetricsTimeRange? timeRange,
            global::Together.DeRequestMetrics? requestMetrics,
            global::Together.DeLatencyMetrics? latencyMetrics,
            global::Together.DeThroughputMetrics? throughputMetrics,
            global::Together.DeErrorMetrics? errorMetrics,
            global::Together.DeResourceUtilization? resourceUtilization,
            global::Together.DeTokenMetrics? tokenMetrics,
            global::System.Collections.Generic.IList<global::Together.DeDeploymentMetrics>? deploymentMetrics)
        {
            this.EndpointId = endpointId;
            this.TimeRange = timeRange;
            this.RequestMetrics = requestMetrics;
            this.LatencyMetrics = latencyMetrics;
            this.ThroughputMetrics = throughputMetrics;
            this.ErrorMetrics = errorMetrics;
            this.ResourceUtilization = resourceUtilization;
            this.TokenMetrics = tokenMetrics;
            this.DeploymentMetrics = deploymentMetrics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeEndpointMetrics" /> class.
        /// </summary>
        public DeEndpointMetrics()
        {
        }

    }
}