
#nullable enable

namespace Together
{
    /// <summary>
    /// GPU type to provision. Omit to use the model's default GPU type.<br/>
    /// Example: B200-SXM
    /// </summary>
    public enum RlComputeConfigCreateRequestGpuType
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
    public static class RlComputeConfigCreateRequestGpuTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RlComputeConfigCreateRequestGpuType value)
        {
            return value switch
            {
                RlComputeConfigCreateRequestGpuType.B200Sxm => "B200-SXM",
                RlComputeConfigCreateRequestGpuType.H10080gb => "H100-80GB",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RlComputeConfigCreateRequestGpuType? ToEnum(string value)
        {
            return value switch
            {
                "B200-SXM" => RlComputeConfigCreateRequestGpuType.B200Sxm,
                "H100-80GB" => RlComputeConfigCreateRequestGpuType.H10080gb,
                _ => null,
            };
        }
    }
}