
#nullable enable

namespace Together
{
    /// <summary>
    /// Role of the weights: full model, speculative draft model, or LoRA adapter.
    /// </summary>
    public enum DeModelWeightsType
    {
        /// <summary>
        ///
        /// </summary>
        WeightsTypeAdapter,
        /// <summary>
        ///
        /// </summary>
        WeightsTypeDefault,
        /// <summary>
        ///
        /// </summary>
        WeightsTypeSpeculator,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeModelWeightsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeModelWeightsType value)
        {
            return value switch
            {
                DeModelWeightsType.WeightsTypeAdapter => "WEIGHTS_TYPE_ADAPTER",
                DeModelWeightsType.WeightsTypeDefault => "WEIGHTS_TYPE_DEFAULT",
                DeModelWeightsType.WeightsTypeSpeculator => "WEIGHTS_TYPE_SPECULATOR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeModelWeightsType? ToEnum(string value)
        {
            return value switch
            {
                "WEIGHTS_TYPE_ADAPTER" => DeModelWeightsType.WeightsTypeAdapter,
                "WEIGHTS_TYPE_DEFAULT" => DeModelWeightsType.WeightsTypeDefault,
                "WEIGHTS_TYPE_SPECULATOR" => DeModelWeightsType.WeightsTypeSpeculator,
                _ => null,
            };
        }
    }
}