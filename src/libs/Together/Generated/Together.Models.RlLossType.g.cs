
#nullable enable

namespace Together
{
    /// <summary>
    /// Default Value: LOSS_TYPE_UNSPECIFIED
    /// </summary>
    public enum RlLossType
    {
        /// <summary>
        /// 
        /// </summary>
        LossTypeUnspecified,
        /// <summary>
        /// 
        /// </summary>
        LossTypeCrossEntropy,
        /// <summary>
        /// 
        /// </summary>
        LossTypeGrpo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RlLossTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RlLossType value)
        {
            return value switch
            {
                RlLossType.LossTypeUnspecified => "LOSS_TYPE_UNSPECIFIED",
                RlLossType.LossTypeCrossEntropy => "LOSS_TYPE_CROSS_ENTROPY",
                RlLossType.LossTypeGrpo => "LOSS_TYPE_GRPO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RlLossType? ToEnum(string value)
        {
            return value switch
            {
                "LOSS_TYPE_UNSPECIFIED" => RlLossType.LossTypeUnspecified,
                "LOSS_TYPE_CROSS_ENTROPY" => RlLossType.LossTypeCrossEntropy,
                "LOSS_TYPE_GRPO" => RlLossType.LossTypeGrpo,
                _ => null,
            };
        }
    }
}