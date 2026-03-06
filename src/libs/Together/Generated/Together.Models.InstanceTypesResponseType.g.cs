
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum InstanceTypesResponseType
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
    public static class InstanceTypesResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InstanceTypesResponseType value)
        {
            return value switch
            {
                InstanceTypesResponseType.H100Sxm => "H100_SXM",
                InstanceTypesResponseType.H200Sxm => "H200_SXM",
                InstanceTypesResponseType.Rtx6000Pci => "RTX_6000_PCI",
                InstanceTypesResponseType.L40Pcie => "L40_PCIE",
                InstanceTypesResponseType.B200Sxm => "B200_SXM",
                InstanceTypesResponseType.H100SxmInf => "H100_SXM_INF",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InstanceTypesResponseType? ToEnum(string value)
        {
            return value switch
            {
                "H100_SXM" => InstanceTypesResponseType.H100Sxm,
                "H200_SXM" => InstanceTypesResponseType.H200Sxm,
                "RTX_6000_PCI" => InstanceTypesResponseType.Rtx6000Pci,
                "L40_PCIE" => InstanceTypesResponseType.L40Pcie,
                "B200_SXM" => InstanceTypesResponseType.B200Sxm,
                "H100_SXM_INF" => InstanceTypesResponseType.H100SxmInf,
                _ => null,
            };
        }
    }
}