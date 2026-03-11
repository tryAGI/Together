
#nullable enable

namespace Together
{
    /// <summary>
    /// Autoscaling config for HTTPTotalRequests and HTTPAvgRequestDuration metrics
    /// </summary>
    public sealed partial class HTTPAutoscalingConfig
    {
        /// <summary>
        /// Metric must be HTTPTotalRequests or HTTPAvgRequestDuration<br/>
        /// Example: HTTPTotalRequests
        /// </summary>
        /// <example>HTTPTotalRequests</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.HTTPAutoscalingConfigMetricJsonConverter))]
        public global::Together.HTTPAutoscalingConfigMetric? Metric { get; set; }

        /// <summary>
        /// Target is the threshold value. Default: 100 for HTTPTotalRequests, 500 (ms) for HTTPAvgRequestDuration<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        public double? Target { get; set; }

        /// <summary>
        /// TimeIntervalMinutes is the rate window in minutes. Default: 10<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_interval_minutes")]
        public int? TimeIntervalMinutes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HTTPAutoscalingConfig" /> class.
        /// </summary>
        /// <param name="metric">
        /// Metric must be HTTPTotalRequests or HTTPAvgRequestDuration<br/>
        /// Example: HTTPTotalRequests
        /// </param>
        /// <param name="target">
        /// Target is the threshold value. Default: 100 for HTTPTotalRequests, 500 (ms) for HTTPAvgRequestDuration<br/>
        /// Example: 100
        /// </param>
        /// <param name="timeIntervalMinutes">
        /// TimeIntervalMinutes is the rate window in minutes. Default: 10<br/>
        /// Example: 10
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HTTPAutoscalingConfig(
            global::Together.HTTPAutoscalingConfigMetric? metric,
            double? target,
            int? timeIntervalMinutes)
        {
            this.Metric = metric;
            this.Target = target;
            this.TimeIntervalMinutes = timeIntervalMinutes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HTTPAutoscalingConfig" /> class.
        /// </summary>
        public HTTPAutoscalingConfig()
        {
        }
    }
}