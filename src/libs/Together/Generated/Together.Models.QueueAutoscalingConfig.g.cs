
#nullable enable

namespace Together
{
    /// <summary>
    /// Autoscaling config for QueueBacklogPerWorker metric
    /// </summary>
    public sealed partial class QueueAutoscalingConfig
    {
        /// <summary>
        /// Metric must be QueueBacklogPerWorker<br/>
        /// Example: QueueBacklogPerWorker
        /// </summary>
        /// <example>QueueBacklogPerWorker</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.QueueAutoscalingConfigMetricJsonConverter))]
        public global::Together.QueueAutoscalingConfigMetric? Metric { get; set; }

        /// <summary>
        /// Model overrides the model name for queue status lookup. Defaults to the deployment app name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Target is the threshold value. Default: 1.01<br/>
        /// Example: 1.01
        /// </summary>
        /// <example>1.01</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        public double? Target { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueAutoscalingConfig" /> class.
        /// </summary>
        /// <param name="metric">
        /// Metric must be QueueBacklogPerWorker<br/>
        /// Example: QueueBacklogPerWorker
        /// </param>
        /// <param name="model">
        /// Model overrides the model name for queue status lookup. Defaults to the deployment app name
        /// </param>
        /// <param name="target">
        /// Target is the threshold value. Default: 1.01<br/>
        /// Example: 1.01
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueAutoscalingConfig(
            global::Together.QueueAutoscalingConfigMetric? metric,
            string? model,
            double? target)
        {
            this.Metric = metric;
            this.Model = model;
            this.Target = target;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueAutoscalingConfig" /> class.
        /// </summary>
        public QueueAutoscalingConfig()
        {
        }
    }
}