
#nullable enable

namespace Together
{
    /// <summary>
    /// Checkpoint variant: merged (full model) or adapter (LoRA weights only)<br/>
    /// Default Value: CHECKPOINT_VARIANT_UNSPECIFIED
    /// </summary>
    public enum RlCheckpointVariant
    {
        /// <summary>
        /// 
        /// </summary>
        CheckpointVariantAdapter,
        /// <summary>
        /// 
        /// </summary>
        CheckpointVariantMerged,
        /// <summary>
        /// 
        /// </summary>
        CheckpointVariantUnspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RlCheckpointVariantExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RlCheckpointVariant value)
        {
            return value switch
            {
                RlCheckpointVariant.CheckpointVariantAdapter => "CHECKPOINT_VARIANT_ADAPTER",
                RlCheckpointVariant.CheckpointVariantMerged => "CHECKPOINT_VARIANT_MERGED",
                RlCheckpointVariant.CheckpointVariantUnspecified => "CHECKPOINT_VARIANT_UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RlCheckpointVariant? ToEnum(string value)
        {
            return value switch
            {
                "CHECKPOINT_VARIANT_ADAPTER" => RlCheckpointVariant.CheckpointVariantAdapter,
                "CHECKPOINT_VARIANT_MERGED" => RlCheckpointVariant.CheckpointVariantMerged,
                "CHECKPOINT_VARIANT_UNSPECIFIED" => RlCheckpointVariant.CheckpointVariantUnspecified,
                _ => null,
            };
        }
    }
}