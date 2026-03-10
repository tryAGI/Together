
#nullable enable

namespace Together
{
    /// <summary>
    /// Autoscaling config for CustomMetric metric
    /// </summary>
    public sealed partial class CustomMetricAutoscalingConfig
    {
        /// <summary>
        /// CustomMetricName is the Prometheus metric name. Required. Must match [a-zA-Z_:][a-zA-Z0-9_:]*<br/>
        /// Example: my_custom_metric
        /// </summary>
        /// <example>my_custom_metric</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_metric_name")]
        public string? CustomMetricName { get; set; }

        /// <summary>
        /// Metric must be CustomMetric<br/>
        /// Example: CustomMetric
        /// </summary>
        /// <example>CustomMetric</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.CustomMetricAutoscalingConfigMetricJsonConverter))]
        public global::Together.CustomMetricAutoscalingConfigMetric? Metric { get; set; }

        /// <summary>
        /// Target is the threshold value. Default: 500<br/>
        /// Example: 500
        /// </summary>
        /// <example>500</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        public double? Target { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomMetricAutoscalingConfig" /> class.
        /// </summary>
        /// <param name="customMetricName">
        /// CustomMetricName is the Prometheus metric name. Required. Must match [a-zA-Z_:][a-zA-Z0-9_:]*<br/>
        /// Example: my_custom_metric
        /// </param>
        /// <param name="metric">
        /// Metric must be CustomMetric<br/>
        /// Example: CustomMetric
        /// </param>
        /// <param name="target">
        /// Target is the threshold value. Default: 500<br/>
        /// Example: 500
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomMetricAutoscalingConfig(
            string? customMetricName,
            global::Together.CustomMetricAutoscalingConfigMetric? metric,
            double? target)
        {
            this.CustomMetricName = customMetricName;
            this.Metric = metric;
            this.Target = target;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomMetricAutoscalingConfig" /> class.
        /// </summary>
        public CustomMetricAutoscalingConfig()
        {
        }
    }
}