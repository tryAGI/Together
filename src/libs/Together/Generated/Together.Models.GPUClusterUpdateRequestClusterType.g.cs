
#nullable enable

namespace Together
{
    /// <summary>
    /// Type of cluster to update.
    /// </summary>
    public enum GPUClusterUpdateRequestClusterType
    {
        /// <summary>
        /// 
        /// </summary>
        Kubernetes,
        /// <summary>
        /// 
        /// </summary>
        Slurm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GPUClusterUpdateRequestClusterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GPUClusterUpdateRequestClusterType value)
        {
            return value switch
            {
                GPUClusterUpdateRequestClusterType.Kubernetes => "KUBERNETES",
                GPUClusterUpdateRequestClusterType.Slurm => "SLURM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GPUClusterUpdateRequestClusterType? ToEnum(string value)
        {
            return value switch
            {
                "KUBERNETES" => GPUClusterUpdateRequestClusterType.Kubernetes,
                "SLURM" => GPUClusterUpdateRequestClusterType.Slurm,
                _ => null,
            };
        }
    }
}