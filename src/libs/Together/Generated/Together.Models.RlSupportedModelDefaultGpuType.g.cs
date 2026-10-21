
#nullable enable

namespace Together
{
    /// <summary>
    /// GPU type used when model-resource creation omits gpu_type.<br/>
    /// Example: H100-80GB
    /// </summary>
    public enum RlSupportedModelDefaultGpuType
    {
        /// <summary>
        ///
        /// </summary>
        B200Sxm,
        /// <summary>
        ///
        /// </summary>
        H10080gb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RlSupportedModelDefaultGpuTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RlSupportedModelDefaultGpuType value)
        {
            return value switch
            {
                RlSupportedModelDefaultGpuType.B200Sxm => "B200-SXM",
                RlSupportedModelDefaultGpuType.H10080gb => "H100-80GB",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RlSupportedModelDefaultGpuType? ToEnum(string value)
        {
            return value switch
            {
                "B200-SXM" => RlSupportedModelDefaultGpuType.B200Sxm,
                "H100-80GB" => RlSupportedModelDefaultGpuType.H10080gb,
                _ => null,
            };
        }
    }
}