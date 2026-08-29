
#nullable enable

namespace Together
{
    /// <summary>
    /// Billing type for the cluster (RESERVED, ON_DEMAND, or SCHEDULED_CAPACITY).
    /// </summary>
    public enum GPUClusterInfoBillingType
    {
        /// <summary>
        ///
        /// </summary>
        OnDemand,
        /// <summary>
        ///
        /// </summary>
        Reserved,
        /// <summary>
        ///
        /// </summary>
        ScheduledCapacity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GPUClusterInfoBillingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GPUClusterInfoBillingType value)
        {
            return value switch
            {
                GPUClusterInfoBillingType.OnDemand => "ON_DEMAND",
                GPUClusterInfoBillingType.Reserved => "RESERVED",
                GPUClusterInfoBillingType.ScheduledCapacity => "SCHEDULED_CAPACITY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GPUClusterInfoBillingType? ToEnum(string value)
        {
            return value switch
            {
                "ON_DEMAND" => GPUClusterInfoBillingType.OnDemand,
                "RESERVED" => GPUClusterInfoBillingType.Reserved,
                "SCHEDULED_CAPACITY" => GPUClusterInfoBillingType.ScheduledCapacity,
                _ => null,
            };
        }
    }
}