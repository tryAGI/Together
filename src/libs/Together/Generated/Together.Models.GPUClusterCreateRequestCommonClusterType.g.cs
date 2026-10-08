
#nullable enable

namespace Together
{
    /// <summary>
    /// Type of cluster to create.
    /// </summary>
    public enum GPUClusterCreateRequestCommonClusterType
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
    public static class GPUClusterCreateRequestCommonClusterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GPUClusterCreateRequestCommonClusterType value)
        {
            return value switch
            {
                GPUClusterCreateRequestCommonClusterType.Kubernetes => "KUBERNETES",
                GPUClusterCreateRequestCommonClusterType.Slurm => "SLURM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GPUClusterCreateRequestCommonClusterType? ToEnum(string value)
        {
            return value switch
            {
                "KUBERNETES" => GPUClusterCreateRequestCommonClusterType.Kubernetes,
                "SLURM" => GPUClusterCreateRequestCommonClusterType.Slurm,
                _ => null,
            };
        }
    }
}