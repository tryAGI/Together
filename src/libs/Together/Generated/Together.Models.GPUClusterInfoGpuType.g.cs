
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum GPUClusterInfoGpuType
    {
        /// <summary>
        /// 
        /// </summary>
        H100Sxm,
        /// <summary>
        /// 
        /// </summary>
        H200Sxm,
        /// <summary>
        /// 
        /// </summary>
        Rtx6000Pci,
        /// <summary>
        /// 
        /// </summary>
        L40Pcie,
        /// <summary>
        /// 
        /// </summary>
        B200Sxm,
        /// <summary>
        /// 
        /// </summary>
        H100SxmInf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GPUClusterInfoGpuTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GPUClusterInfoGpuType value)
        {
            return value switch
            {
                GPUClusterInfoGpuType.H100Sxm => "H100_SXM",
                GPUClusterInfoGpuType.H200Sxm => "H200_SXM",
                GPUClusterInfoGpuType.Rtx6000Pci => "RTX_6000_PCI",
                GPUClusterInfoGpuType.L40Pcie => "L40_PCIE",
                GPUClusterInfoGpuType.B200Sxm => "B200_SXM",
                GPUClusterInfoGpuType.H100SxmInf => "H100_SXM_INF",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GPUClusterInfoGpuType? ToEnum(string value)
        {
            return value switch
            {
                "H100_SXM" => GPUClusterInfoGpuType.H100Sxm,
                "H200_SXM" => GPUClusterInfoGpuType.H200Sxm,
                "RTX_6000_PCI" => GPUClusterInfoGpuType.Rtx6000Pci,
                "L40_PCIE" => GPUClusterInfoGpuType.L40Pcie,
                "B200_SXM" => GPUClusterInfoGpuType.B200Sxm,
                "H100_SXM_INF" => GPUClusterInfoGpuType.H100SxmInf,
                _ => null,
            };
        }
    }
}