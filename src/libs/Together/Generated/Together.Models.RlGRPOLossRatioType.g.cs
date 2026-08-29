
#nullable enable

namespace Together
{
    /// <summary>
    /// Controls whether GRPO loss uses token-level or sequence-level importance ratios.<br/>
    /// Default Value: GRPO_LOSS_RATIO_TYPE_TOKEN
    /// </summary>
    public enum RlGRPOLossRatioType
    {
        /// <summary>
        ///
        /// </summary>
        GrpoLossRatioTypeSequence,
        /// <summary>
        ///
        /// </summary>
        GrpoLossRatioTypeToken,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RlGRPOLossRatioTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RlGRPOLossRatioType value)
        {
            return value switch
            {
                RlGRPOLossRatioType.GrpoLossRatioTypeSequence => "GRPO_LOSS_RATIO_TYPE_SEQUENCE",
                RlGRPOLossRatioType.GrpoLossRatioTypeToken => "GRPO_LOSS_RATIO_TYPE_TOKEN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RlGRPOLossRatioType? ToEnum(string value)
        {
            return value switch
            {
                "GRPO_LOSS_RATIO_TYPE_SEQUENCE" => RlGRPOLossRatioType.GrpoLossRatioTypeSequence,
                "GRPO_LOSS_RATIO_TYPE_TOKEN" => RlGRPOLossRatioType.GrpoLossRatioTypeToken,
                _ => null,
            };
        }
    }
}