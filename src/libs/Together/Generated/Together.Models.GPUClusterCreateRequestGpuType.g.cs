
#nullable enable

namespace Together
{
    /// <summary>
    /// Type of GPU to use in the cluster
    /// </summary>
    public enum GPUClusterCreateRequestGpuType
    {
        /// <summary>
        /// 
        /// </summary>
        B200Sxm,
        /// <summary>
        /// 
        /// </summary>
        H100Sxm,
        /// <summary>
        /// 
        /// </summary>
        H100SxmInf,
        /// <summary>
        /// 
        /// </summary>
        H200Sxm,
        /// <summary>
        /// 
        /// </summary>
        L40Pcie,
        /// <summary>
        /// 
        /// </summary>
        Rtx6000Pci,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GPUClusterCreateRequestGpuTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GPUClusterCreateRequestGpuType value)
        {
            return value switch
            {
                GPUClusterCreateRequestGpuType.B200Sxm => "B200_SXM",
                GPUClusterCreateRequestGpuType.H100Sxm => "H100_SXM",
                GPUClusterCreateRequestGpuType.H100SxmInf => "H100_SXM_INF",
                GPUClusterCreateRequestGpuType.H200Sxm => "H200_SXM",
                GPUClusterCreateRequestGpuType.L40Pcie => "L40_PCIE",
                GPUClusterCreateRequestGpuType.Rtx6000Pci => "RTX_6000_PCI",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GPUClusterCreateRequestGpuType? ToEnum(string value)
        {
            return value switch
            {
                "B200_SXM" => GPUClusterCreateRequestGpuType.B200Sxm,
                "H100_SXM" => GPUClusterCreateRequestGpuType.H100Sxm,
                "H100_SXM_INF" => GPUClusterCreateRequestGpuType.H100SxmInf,
                "H200_SXM" => GPUClusterCreateRequestGpuType.H200Sxm,
                "L40_PCIE" => GPUClusterCreateRequestGpuType.L40Pcie,
                "RTX_6000_PCI" => GPUClusterCreateRequestGpuType.Rtx6000Pci,
                _ => null,
            };
        }
    }
}