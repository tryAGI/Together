
#nullable enable

namespace Together
{
    /// <summary>
    /// RESERVED billing types allow you to specify the duration of the cluster reservation via the duration_days field.<br/>
    /// ON_DEMAND billing types will give you ownership of the cluster until you delete it.
    /// </summary>
    public enum GPUClusterCreateRequestBillingType
    {
        /// <summary>
        /// 
        /// </summary>
        Reserved,
        /// <summary>
        /// 
        /// </summary>
        OnDemand,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GPUClusterCreateRequestBillingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GPUClusterCreateRequestBillingType value)
        {
            return value switch
            {
                GPUClusterCreateRequestBillingType.Reserved => "RESERVED",
                GPUClusterCreateRequestBillingType.OnDemand => "ON_DEMAND",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GPUClusterCreateRequestBillingType? ToEnum(string value)
        {
            return value switch
            {
                "RESERVED" => GPUClusterCreateRequestBillingType.Reserved,
                "ON_DEMAND" => GPUClusterCreateRequestBillingType.OnDemand,
                _ => null,
            };
        }
    }
}