
#nullable enable

namespace Together
{
    /// <summary>
    /// Metric gate evaluated during a rollout.
    /// </summary>
    public sealed partial class DeMetricRule
    {
        /// <summary>
        /// Required catalogue key for the metric to gate on. `serving_latency` is retired.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeMetricRuleNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.DeMetricRuleName Name { get; set; }

        /// <summary>
        /// Required aggregation used for the metric.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stat")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeMetricRuleStatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.DeMetricRuleStat Stat { get; set; }

        /// <summary>
        /// Percentile value, such as 99. Set only when stat is METRIC_STAT_TYPE_PERCENTILE.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentile")]
        public int? Percentile { get; set; }

        /// <summary>
        /// Threshold evaluation criteria. Mutually exclusive with regressionCheck.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thresholdCheck")]
        public global::Together.DeThresholdCheck? ThresholdCheck { get; set; }

        /// <summary>
        /// Regression evaluation criteria. Mutually exclusive with thresholdCheck.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regressionCheck")]
        public global::Together.DeRegressionCheck? RegressionCheck { get; set; }

        /// <summary>
        /// Optional query window for the metric. Defaults to the step soak duration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("window")]
        public string? Window { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeMetricRule" /> class.
        /// </summary>
        /// <param name="name">
        /// Required catalogue key for the metric to gate on. `serving_latency` is retired.
        /// </param>
        /// <param name="stat">
        /// Required aggregation used for the metric.
        /// </param>
        /// <param name="percentile">
        /// Percentile value, such as 99. Set only when stat is METRIC_STAT_TYPE_PERCENTILE.
        /// </param>
        /// <param name="thresholdCheck">
        /// Threshold evaluation criteria. Mutually exclusive with regressionCheck.
        /// </param>
        /// <param name="regressionCheck">
        /// Regression evaluation criteria. Mutually exclusive with thresholdCheck.
        /// </param>
        /// <param name="window">
        /// Optional query window for the metric. Defaults to the step soak duration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeMetricRule(
            global::Together.DeMetricRuleName name,
            global::Together.DeMetricRuleStat stat,
            int? percentile,
            global::Together.DeThresholdCheck? thresholdCheck,
            global::Together.DeRegressionCheck? regressionCheck,
            string? window)
        {
            this.Name = name;
            this.Stat = stat;
            this.Percentile = percentile;
            this.ThresholdCheck = thresholdCheck;
            this.RegressionCheck = regressionCheck;
            this.Window = window;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeMetricRule" /> class.
        /// </summary>
        public DeMetricRule()
        {
        }

    }
}