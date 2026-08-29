
#nullable enable

namespace Together
{
    /// <summary>
    /// Inference engine used to serve the model.
    /// </summary>
    public enum DeConfigEngineType
    {
        /// <summary>
        ///
        /// </summary>
        EngineTypePulsar,
        /// <summary>
        ///
        /// </summary>
        EngineTypeSglang,
        /// <summary>
        ///
        /// </summary>
        EngineTypeSmg,
        /// <summary>
        ///
        /// </summary>
        EngineTypeTgl,
        /// <summary>
        ///
        /// </summary>
        EngineTypeTrtllm,
        /// <summary>
        ///
        /// </summary>
        EngineTypeVllm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeConfigEngineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeConfigEngineType value)
        {
            return value switch
            {
                DeConfigEngineType.EngineTypePulsar => "ENGINE_TYPE_PULSAR",
                DeConfigEngineType.EngineTypeSglang => "ENGINE_TYPE_SGLANG",
                DeConfigEngineType.EngineTypeSmg => "ENGINE_TYPE_SMG",
                DeConfigEngineType.EngineTypeTgl => "ENGINE_TYPE_TGL",
                DeConfigEngineType.EngineTypeTrtllm => "ENGINE_TYPE_TRTLLM",
                DeConfigEngineType.EngineTypeVllm => "ENGINE_TYPE_VLLM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeConfigEngineType? ToEnum(string value)
        {
            return value switch
            {
                "ENGINE_TYPE_PULSAR" => DeConfigEngineType.EngineTypePulsar,
                "ENGINE_TYPE_SGLANG" => DeConfigEngineType.EngineTypeSglang,
                "ENGINE_TYPE_SMG" => DeConfigEngineType.EngineTypeSmg,
                "ENGINE_TYPE_TGL" => DeConfigEngineType.EngineTypeTgl,
                "ENGINE_TYPE_TRTLLM" => DeConfigEngineType.EngineTypeTrtllm,
                "ENGINE_TYPE_VLLM" => DeConfigEngineType.EngineTypeVllm,
                _ => null,
            };
        }
    }
}