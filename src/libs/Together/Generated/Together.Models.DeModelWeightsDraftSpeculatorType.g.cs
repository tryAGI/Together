
#nullable enable

namespace Together
{
    /// <summary>
    /// Draft-model speculator family for draft speculative decoding.
    /// </summary>
    public enum DeModelWeightsDraftSpeculatorType
    {
        /// <summary>
        ///
        /// </summary>
        DraftSpeculatorTypeEagle,
        /// <summary>
        ///
        /// </summary>
        DraftSpeculatorTypePhoenix,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeModelWeightsDraftSpeculatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeModelWeightsDraftSpeculatorType value)
        {
            return value switch
            {
                DeModelWeightsDraftSpeculatorType.DraftSpeculatorTypeEagle => "DRAFT_SPECULATOR_TYPE_EAGLE",
                DeModelWeightsDraftSpeculatorType.DraftSpeculatorTypePhoenix => "DRAFT_SPECULATOR_TYPE_PHOENIX",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeModelWeightsDraftSpeculatorType? ToEnum(string value)
        {
            return value switch
            {
                "DRAFT_SPECULATOR_TYPE_EAGLE" => DeModelWeightsDraftSpeculatorType.DraftSpeculatorTypeEagle,
                "DRAFT_SPECULATOR_TYPE_PHOENIX" => DeModelWeightsDraftSpeculatorType.DraftSpeculatorTypePhoenix,
                _ => null,
            };
        }
    }
}