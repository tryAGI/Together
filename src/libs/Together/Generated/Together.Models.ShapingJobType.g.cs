
#nullable enable

namespace Together
{
    /// <summary>
    /// Kind of shaping job.
    /// </summary>
    public enum ShapingJobType
    {
        /// <summary>
        ///
        /// </summary>
        Quantization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ShapingJobTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShapingJobType value)
        {
            return value switch
            {
                ShapingJobType.Quantization => "quantization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShapingJobType? ToEnum(string value)
        {
            return value switch
            {
                "quantization" => ShapingJobType.Quantization,
                _ => null,
            };
        }
    }
}