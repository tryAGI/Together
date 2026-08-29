
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RlGRPOLossParams
    {
        /// <summary>
        /// Lower clip threshold for the importance-sampling ratio. The ratio is clamped to this bound; tighter clipping makes policy updates more conservative. Must be &lt;= 1.<br/>
        /// Default Value: 0.8<br/>
        /// Example: 0.8
        /// </summary>
        /// <example>0.8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("clip_low_threshold")]
        public float? ClipLowThreshold { get; set; }

        /// <summary>
        /// Upper clip threshold for the importance-sampling ratio. The ratio is clamped to this bound; tighter clipping makes policy updates more conservative. Must be &gt;= 1.<br/>
        /// Default Value: 1.2<br/>
        /// Example: 1.2
        /// </summary>
        /// <example>1.2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("clip_high_threshold")]
        public float? ClipHighThreshold { get; set; }

        /// <summary>
        /// KL penalty coefficient<br/>
        /// Default Value: 0.0<br/>
        /// Example: 0.1
        /// </summary>
        /// <example>0.1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("beta")]
        public double? Beta { get; set; }

        /// <summary>
        /// Aggregation type for loss computation<br/>
        /// Default Value: GRPO_LOSS_AGGREGATION_TYPE_FIXED_HORIZON
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agg_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.RlGRPOLossAggregationTypeJsonConverter))]
        public global::Together.RlGRPOLossAggregationType? AggType { get; set; }

        /// <summary>
        /// Controls how the importance-sampling ratio is computed in GRPO loss. Defaults to token-level ratios, which is the standard GRPO behavior. Use sequence-level ratios to enable GSPO-style loss calculation instead.<br/>
        /// Default Value: GRPO_LOSS_RATIO_TYPE_TOKEN
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.RlGRPOLossRatioTypeJsonConverter))]
        public global::Together.RlGRPOLossRatioType? RatioType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlGRPOLossParams" /> class.
        /// </summary>
        /// <param name="clipLowThreshold">
        /// Lower clip threshold for the importance-sampling ratio. The ratio is clamped to this bound; tighter clipping makes policy updates more conservative. Must be &lt;= 1.<br/>
        /// Default Value: 0.8<br/>
        /// Example: 0.8
        /// </param>
        /// <param name="clipHighThreshold">
        /// Upper clip threshold for the importance-sampling ratio. The ratio is clamped to this bound; tighter clipping makes policy updates more conservative. Must be &gt;= 1.<br/>
        /// Default Value: 1.2<br/>
        /// Example: 1.2
        /// </param>
        /// <param name="beta">
        /// KL penalty coefficient<br/>
        /// Default Value: 0.0<br/>
        /// Example: 0.1
        /// </param>
        /// <param name="aggType">
        /// Aggregation type for loss computation<br/>
        /// Default Value: GRPO_LOSS_AGGREGATION_TYPE_FIXED_HORIZON
        /// </param>
        /// <param name="ratioType">
        /// Controls how the importance-sampling ratio is computed in GRPO loss. Defaults to token-level ratios, which is the standard GRPO behavior. Use sequence-level ratios to enable GSPO-style loss calculation instead.<br/>
        /// Default Value: GRPO_LOSS_RATIO_TYPE_TOKEN
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlGRPOLossParams(
            float? clipLowThreshold,
            float? clipHighThreshold,
            double? beta,
            global::Together.RlGRPOLossAggregationType? aggType,
            global::Together.RlGRPOLossRatioType? ratioType)
        {
            this.ClipLowThreshold = clipLowThreshold;
            this.ClipHighThreshold = clipHighThreshold;
            this.Beta = beta;
            this.AggType = aggType;
            this.RatioType = ratioType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlGRPOLossParams" /> class.
        /// </summary>
        public RlGRPOLossParams()
        {
        }

    }
}