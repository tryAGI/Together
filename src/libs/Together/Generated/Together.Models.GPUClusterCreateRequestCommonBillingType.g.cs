
#nullable enable

namespace Together
{
    /// <summary>
    /// RESERVED billing types allow you to specify the duration of the cluster reservation via the duration_days field.<br/>
    /// ON_DEMAND billing types will give you ownership of the cluster until you delete it.<br/>
    /// SCHEDULED_CAPACITY billing types allow you to reserve capacity for a scheduled time window. You must specify the reservation_start_time and reservation_end_time with this request.
    /// </summary>
    public enum GPUClusterCreateRequestCommonBillingType
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
    public static class GPUClusterCreateRequestCommonBillingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GPUClusterCreateRequestCommonBillingType value)
        {
            return value switch
            {
                GPUClusterCreateRequestCommonBillingType.OnDemand => "ON_DEMAND",
                GPUClusterCreateRequestCommonBillingType.Reserved => "RESERVED",
                GPUClusterCreateRequestCommonBillingType.ScheduledCapacity => "SCHEDULED_CAPACITY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GPUClusterCreateRequestCommonBillingType? ToEnum(string value)
        {
            return value switch
            {
                "ON_DEMAND" => GPUClusterCreateRequestCommonBillingType.OnDemand,
                "RESERVED" => GPUClusterCreateRequestCommonBillingType.Reserved,
                "SCHEDULED_CAPACITY" => GPUClusterCreateRequestCommonBillingType.ScheduledCapacity,
                _ => null,
            };
        }
    }
}