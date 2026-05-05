
#nullable enable

namespace Together
{
    /// <summary>
    /// GPUType specifies the type of GPU requested (if any) for this deployment
    /// </summary>
    public enum DeploymentResponseItemGpuType
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
    public static class DeploymentResponseItemGpuTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeploymentResponseItemGpuType value)
        {
            return value switch
            {
                DeploymentResponseItemGpuType.B200192gb => "b200-192gb",
                DeploymentResponseItemGpuType.H10040gbMig => "h100-40gb-mig",
                DeploymentResponseItemGpuType.H10080gb => "h100-80gb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeploymentResponseItemGpuType? ToEnum(string value)
        {
            return value switch
            {
                "b200-192gb" => DeploymentResponseItemGpuType.B200192gb,
                "h100-40gb-mig" => DeploymentResponseItemGpuType.H10040gbMig,
                "h100-80gb" => DeploymentResponseItemGpuType.H10080gb,
                _ => null,
            };
        }
    }
}