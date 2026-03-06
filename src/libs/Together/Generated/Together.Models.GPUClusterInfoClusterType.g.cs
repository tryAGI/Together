
#nullable enable

namespace Together
{
    /// <summary>
    /// Type of cluster.
    /// </summary>
    public enum GPUClusterInfoClusterType
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
    public static class GPUClusterInfoClusterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GPUClusterInfoClusterType value)
        {
            return value switch
            {
                GPUClusterInfoClusterType.Kubernetes => "KUBERNETES",
                GPUClusterInfoClusterType.Slurm => "SLURM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GPUClusterInfoClusterType? ToEnum(string value)
        {
            return value switch
            {
                "KUBERNETES" => GPUClusterInfoClusterType.Kubernetes,
                "SLURM" => GPUClusterInfoClusterType.Slurm,
                _ => null,
            };
        }
    }
}