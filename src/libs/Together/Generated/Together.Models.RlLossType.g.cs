
#nullable enable

namespace Together
{
    /// <summary>
    /// Type of loss function used for RL training.<br/>
    /// Default Value: LOSS_TYPE_UNSPECIFIED
    /// </summary>
    public enum RlLossType
    {
        /// <summary>
        ///
        /// </summary>
        LossTypeCispo,
        /// <summary>
        ///
        /// </summary>
        LossTypeCrossEntropy,
        /// <summary>
        ///
        /// </summary>
        LossTypeDro,
        /// <summary>
        ///
        /// </summary>
        LossTypeGrpo,
        /// <summary>
        ///
        /// </summary>
        LossTypeImportanceSampling,
        /// <summary>
        ///
        /// </summary>
        LossTypePpo,
        /// <summary>
        ///
        /// </summary>
        LossTypeUnspecified,
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
                RlLossType.LossTypeCispo => "LOSS_TYPE_CISPO",
                RlLossType.LossTypeCrossEntropy => "LOSS_TYPE_CROSS_ENTROPY",
                RlLossType.LossTypeDro => "LOSS_TYPE_DRO",
                RlLossType.LossTypeGrpo => "LOSS_TYPE_GRPO",
                RlLossType.LossTypeImportanceSampling => "LOSS_TYPE_IMPORTANCE_SAMPLING",
                RlLossType.LossTypePpo => "LOSS_TYPE_PPO",
                RlLossType.LossTypeUnspecified => "LOSS_TYPE_UNSPECIFIED",
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
                "LOSS_TYPE_CISPO" => RlLossType.LossTypeCispo,
                "LOSS_TYPE_CROSS_ENTROPY" => RlLossType.LossTypeCrossEntropy,
                "LOSS_TYPE_DRO" => RlLossType.LossTypeDro,
                "LOSS_TYPE_GRPO" => RlLossType.LossTypeGrpo,
                "LOSS_TYPE_IMPORTANCE_SAMPLING" => RlLossType.LossTypeImportanceSampling,
                "LOSS_TYPE_PPO" => RlLossType.LossTypePpo,
                "LOSS_TYPE_UNSPECIFIED" => RlLossType.LossTypeUnspecified,
                _ => null,
            };
        }
    }
}