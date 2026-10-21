
#nullable enable

namespace Together
{
    /// <summary>
    /// GPU type this configuration provisions.<br/>
    /// Example: H100-80GB
    /// </summary>
    public enum RlSupportedModelComputeConfigGpuType
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
    public static class RlSupportedModelComputeConfigGpuTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RlSupportedModelComputeConfigGpuType value)
        {
            return value switch
            {
                RlSupportedModelComputeConfigGpuType.B200Sxm => "B200-SXM",
                RlSupportedModelComputeConfigGpuType.H10080gb => "H100-80GB",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RlSupportedModelComputeConfigGpuType? ToEnum(string value)
        {
            return value switch
            {
                "B200-SXM" => RlSupportedModelComputeConfigGpuType.B200Sxm,
                "H100-80GB" => RlSupportedModelComputeConfigGpuType.H10080gb,
                _ => null,
            };
        }
    }
}