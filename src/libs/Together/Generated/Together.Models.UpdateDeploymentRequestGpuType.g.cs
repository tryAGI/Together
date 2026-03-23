
#nullable enable

namespace Together
{
    /// <summary>
    /// GPUType specifies the GPU hardware to use (e.g., "h100-80gb")
    /// </summary>
    public enum UpdateDeploymentRequestGpuType
    {
        /// <summary>
        /// 
        /// </summary>
        H10080gb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateDeploymentRequestGpuTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDeploymentRequestGpuType value)
        {
            return value switch
            {
                UpdateDeploymentRequestGpuType.H10080gb => "h100-80gb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDeploymentRequestGpuType? ToEnum(string value)
        {
            return value switch
            {
                "h100-80gb" => UpdateDeploymentRequestGpuType.H10080gb,
                _ => null,
            };
        }
    }
}