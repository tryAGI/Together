
#nullable enable

namespace Together
{
    /// <summary>
    /// GPUType specifies the GPU hardware to use (e.g., "h100-80gb").
    /// </summary>
    public enum CreateDeploymentRequestGpuType
    {
        /// <summary>
        /// 
        /// </summary>
        B200192gb,
        /// <summary>
        /// 
        /// </summary>
        H10040gbMig,
        /// <summary>
        /// 
        /// </summary>
        H10080gb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentRequestGpuTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentRequestGpuType value)
        {
            return value switch
            {
                CreateDeploymentRequestGpuType.B200192gb => "b200-192gb",
                CreateDeploymentRequestGpuType.H10040gbMig => "h100-40gb-mig",
                CreateDeploymentRequestGpuType.H10080gb => "h100-80gb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentRequestGpuType? ToEnum(string value)
        {
            return value switch
            {
                "b200-192gb" => CreateDeploymentRequestGpuType.B200192gb,
                "h100-40gb-mig" => CreateDeploymentRequestGpuType.H10040gbMig,
                "h100-80gb" => CreateDeploymentRequestGpuType.H10080gb,
                _ => null,
            };
        }
    }
}