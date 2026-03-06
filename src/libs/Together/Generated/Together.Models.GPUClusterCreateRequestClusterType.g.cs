
#nullable enable

namespace Together
{
    /// <summary>
    /// Type of cluster to create.
    /// </summary>
    public enum GPUClusterCreateRequestClusterType
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
    public static class GPUClusterCreateRequestClusterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GPUClusterCreateRequestClusterType value)
        {
            return value switch
            {
                GPUClusterCreateRequestClusterType.Kubernetes => "KUBERNETES",
                GPUClusterCreateRequestClusterType.Slurm => "SLURM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GPUClusterCreateRequestClusterType? ToEnum(string value)
        {
            return value switch
            {
                "KUBERNETES" => GPUClusterCreateRequestClusterType.Kubernetes,
                "SLURM" => GPUClusterCreateRequestClusterType.Slurm,
                _ => null,
            };
        }
    }
}