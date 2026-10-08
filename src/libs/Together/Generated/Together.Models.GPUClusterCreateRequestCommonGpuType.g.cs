
#nullable enable

namespace Together
{
    /// <summary>
    /// Type of GPU to use in the cluster
    /// </summary>
    public enum GPUClusterCreateRequestCommonGpuType
    {
        /// <summary>
        ///
        /// </summary>
        B200Sxm,
        /// <summary>
        ///
        /// </summary>
        B300Sxm,
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
    public static class GPUClusterCreateRequestCommonGpuTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GPUClusterCreateRequestCommonGpuType value)
        {
            return value switch
            {
                GPUClusterCreateRequestCommonGpuType.B200Sxm => "B200_SXM",
                GPUClusterCreateRequestCommonGpuType.B300Sxm => "B300_SXM",
                GPUClusterCreateRequestCommonGpuType.H100Sxm => "H100_SXM",
                GPUClusterCreateRequestCommonGpuType.H100SxmInf => "H100_SXM_INF",
                GPUClusterCreateRequestCommonGpuType.H200Sxm => "H200_SXM",
                GPUClusterCreateRequestCommonGpuType.L40Pcie => "L40_PCIE",
                GPUClusterCreateRequestCommonGpuType.Rtx6000Pci => "RTX_6000_PCI",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GPUClusterCreateRequestCommonGpuType? ToEnum(string value)
        {
            return value switch
            {
                "B200_SXM" => GPUClusterCreateRequestCommonGpuType.B200Sxm,
                "B300_SXM" => GPUClusterCreateRequestCommonGpuType.B300Sxm,
                "H100_SXM" => GPUClusterCreateRequestCommonGpuType.H100Sxm,
                "H100_SXM_INF" => GPUClusterCreateRequestCommonGpuType.H100SxmInf,
                "H200_SXM" => GPUClusterCreateRequestCommonGpuType.H200Sxm,
                "L40_PCIE" => GPUClusterCreateRequestCommonGpuType.L40Pcie,
                "RTX_6000_PCI" => GPUClusterCreateRequestCommonGpuType.Rtx6000Pci,
                _ => null,
            };
        }
    }
}