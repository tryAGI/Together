
#nullable enable

namespace Together
{
    /// <summary>
    /// GPU type selected for this resource.<br/>
    /// Example: H100-80GB
    /// </summary>
    public enum RlComputeConfigGpuType
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
    public static class RlComputeConfigGpuTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RlComputeConfigGpuType value)
        {
            return value switch
            {
                RlComputeConfigGpuType.B200Sxm => "B200-SXM",
                RlComputeConfigGpuType.H10080gb => "H100-80GB",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RlComputeConfigGpuType? ToEnum(string value)
        {
            return value switch
            {
                "B200-SXM" => RlComputeConfigGpuType.B200Sxm,
                "H100-80GB" => RlComputeConfigGpuType.H10080gb,
                _ => null,
            };
        }
    }
}