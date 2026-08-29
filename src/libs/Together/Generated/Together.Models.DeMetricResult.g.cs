
#nullable enable

namespace Together
{
    /// <summary>
    /// Observed metric value enriched with its rollout rule and verdict.
    /// </summary>
    public sealed partial class DeMetricResult
    {
        /// <summary>
        /// Metric name as exported to the observability backend.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Aggregation used for the metric.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stat")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeMetricResultStatJsonConverter))]
        public global::Together.DeMetricResultStat? Stat { get; set; }

        /// <summary>
        /// Percentile value, such as 99. Set only when stat is METRIC_STAT_TYPE_PERCENTILE.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentile")]
        public int? Percentile { get; set; }

        /// <summary>
        /// Evaluation form used by the metric rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("check")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeMetricResultCheckJsonConverter))]
        public global::Together.DeMetricResultCheck? Check { get; set; }

        /// <summary>
        /// Observed source baseline. Set only for regression checks; a 0 reading serializes explicitly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceValue")]
        public double? SourceValue { get; set; }

        /// <summary>
        /// Observed target value. A 0 reading serializes explicitly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetValue")]
        public double? TargetValue { get; set; }

        /// <summary>
        /// Threshold criteria used when check is METRIC_CHECK_TYPE_THRESHOLD.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public double? Threshold { get; set; }

        /// <summary>
        /// Threshold comparison operator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeMetricResultOperatorJsonConverter))]
        public global::Together.DeMetricResultOperator? Operator { get; set; }

        /// <summary>
        /// Regression percentage limit used when check is METRIC_CHECK_TYPE_REGRESSION.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxRegressionPercent")]
        public double? MaxRegressionPercent { get; set; }

        /// <summary>
        /// Direction that indicates whether higher or lower values are worse.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeMetricResultDirectionJsonConverter))]
        public global::Together.DeMetricResultDirection? Direction { get; set; }

        /// <summary>
        /// Result of evaluating this metric at the gate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verdict")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeMetricResultVerdictJsonConverter))]
        public global::Together.DeMetricResultVerdict? Verdict { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeMetricResult" /> class.
        /// </summary>
        /// <param name="name">
        /// Metric name as exported to the observability backend.
        /// </param>
        /// <param name="stat">
        /// Aggregation used for the metric.
        /// </param>
        /// <param name="percentile">
        /// Percentile value, such as 99. Set only when stat is METRIC_STAT_TYPE_PERCENTILE.
        /// </param>
        /// <param name="check">
        /// Evaluation form used by the metric rule.
        /// </param>
        /// <param name="sourceValue">
        /// Observed source baseline. Set only for regression checks; a 0 reading serializes explicitly.
        /// </param>
        /// <param name="targetValue">
        /// Observed target value. A 0 reading serializes explicitly.
        /// </param>
        /// <param name="threshold">
        /// Threshold criteria used when check is METRIC_CHECK_TYPE_THRESHOLD.
        /// </param>
        /// <param name="operator">
        /// Threshold comparison operator.
        /// </param>
        /// <param name="maxRegressionPercent">
        /// Regression percentage limit used when check is METRIC_CHECK_TYPE_REGRESSION.
        /// </param>
        /// <param name="direction">
        /// Direction that indicates whether higher or lower values are worse.
        /// </param>
        /// <param name="verdict">
        /// Result of evaluating this metric at the gate.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeMetricResult(
            string? name,
            global::Together.DeMetricResultStat? stat,
            int? percentile,
            global::Together.DeMetricResultCheck? check,
            double? sourceValue,
            double? targetValue,
            double? threshold,
            global::Together.DeMetricResultOperator? @operator,
            double? maxRegressionPercent,
            global::Together.DeMetricResultDirection? direction,
            global::Together.DeMetricResultVerdict? verdict)
        {
            this.Name = name;
            this.Stat = stat;
            this.Percentile = percentile;
            this.Check = check;
            this.SourceValue = sourceValue;
            this.TargetValue = targetValue;
            this.Threshold = threshold;
            this.Operator = @operator;
            this.MaxRegressionPercent = maxRegressionPercent;
            this.Direction = direction;
            this.Verdict = verdict;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeMetricResult" /> class.
        /// </summary>
        public DeMetricResult()
        {
        }

    }
}