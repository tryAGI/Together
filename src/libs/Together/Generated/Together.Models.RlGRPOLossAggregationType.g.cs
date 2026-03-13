
#nullable enable

namespace Together
{
    /// <summary>
    /// Default Value: GRPO_LOSS_AGGREGATION_TYPE_UNSPECIFIED
    /// </summary>
    public enum RlGRPOLossAggregationType
    {
        /// <summary>
        /// 
        /// </summary>
        GrpoLossAggregationTypeUnspecified,
        /// <summary>
        /// 
        /// </summary>
        GrpoLossAggregationTypeFixedHorizon,
        /// <summary>
        /// 
        /// </summary>
        GrpoLossAggregationTypeTokenMean,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RlGRPOLossAggregationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RlGRPOLossAggregationType value)
        {
            return value switch
            {
                RlGRPOLossAggregationType.GrpoLossAggregationTypeUnspecified => "GRPO_LOSS_AGGREGATION_TYPE_UNSPECIFIED",
                RlGRPOLossAggregationType.GrpoLossAggregationTypeFixedHorizon => "GRPO_LOSS_AGGREGATION_TYPE_FIXED_HORIZON",
                RlGRPOLossAggregationType.GrpoLossAggregationTypeTokenMean => "GRPO_LOSS_AGGREGATION_TYPE_TOKEN_MEAN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RlGRPOLossAggregationType? ToEnum(string value)
        {
            return value switch
            {
                "GRPO_LOSS_AGGREGATION_TYPE_UNSPECIFIED" => RlGRPOLossAggregationType.GrpoLossAggregationTypeUnspecified,
                "GRPO_LOSS_AGGREGATION_TYPE_FIXED_HORIZON" => RlGRPOLossAggregationType.GrpoLossAggregationTypeFixedHorizon,
                "GRPO_LOSS_AGGREGATION_TYPE_TOKEN_MEAN" => RlGRPOLossAggregationType.GrpoLossAggregationTypeTokenMean,
                _ => null,
            };
        }
    }
}