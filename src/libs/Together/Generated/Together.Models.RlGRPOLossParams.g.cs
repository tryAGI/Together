
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RlGRPOLossParams
    {
        /// <summary>
        /// Default Value: GRPO_LOSS_AGGREGATION_TYPE_UNSPECIFIED
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agg_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.RlGRPOLossAggregationTypeJsonConverter))]
        public global::Together.RlGRPOLossAggregationType? AggType { get; set; }

        /// <summary>
        /// KL penalty coefficient<br/>
        /// Default Value: 0.0<br/>
        /// Example: 0.1
        /// </summary>
        /// <example>0.1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("beta")]
        public float? Beta { get; set; }

        /// <summary>
        /// Upper clip bound for importance ratio<br/>
        /// Default Value: 0.28<br/>
        /// Example: 0.28
        /// </summary>
        /// <example>0.28</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("clip_high")]
        public float? ClipHigh { get; set; }

        /// <summary>
        /// Lower clip bound for importance ratio<br/>
        /// Default Value: 0.2<br/>
        /// Example: 0.2
        /// </summary>
        /// <example>0.2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("clip_low")]
        public float? ClipLow { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlGRPOLossParams" /> class.
        /// </summary>
        /// <param name="aggType">
        /// Default Value: GRPO_LOSS_AGGREGATION_TYPE_UNSPECIFIED
        /// </param>
        /// <param name="beta">
        /// KL penalty coefficient<br/>
        /// Default Value: 0.0<br/>
        /// Example: 0.1
        /// </param>
        /// <param name="clipHigh">
        /// Upper clip bound for importance ratio<br/>
        /// Default Value: 0.28<br/>
        /// Example: 0.28
        /// </param>
        /// <param name="clipLow">
        /// Lower clip bound for importance ratio<br/>
        /// Default Value: 0.2<br/>
        /// Example: 0.2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlGRPOLossParams(
            global::Together.RlGRPOLossAggregationType? aggType,
            float? beta,
            float? clipHigh,
            float? clipLow)
        {
            this.AggType = aggType;
            this.Beta = beta;
            this.ClipHigh = clipHigh;
            this.ClipLow = clipLow;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlGRPOLossParams" /> class.
        /// </summary>
        public RlGRPOLossParams()
        {
        }
    }
}