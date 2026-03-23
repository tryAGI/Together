
#nullable enable

namespace Together
{
    /// <summary>
    /// The availability status of the hardware configuration
    /// </summary>
    public enum HardwareAvailabilityStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Available,
        /// <summary>
        /// 
        /// </summary>
        Insufficient,
        /// <summary>
        /// 
        /// </summary>
        Unavailable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HardwareAvailabilityStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HardwareAvailabilityStatus value)
        {
            return value switch
            {
                HardwareAvailabilityStatus.Available => "available",
                HardwareAvailabilityStatus.Insufficient => "insufficient",
                HardwareAvailabilityStatus.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HardwareAvailabilityStatus? ToEnum(string value)
        {
            return value switch
            {
                "available" => HardwareAvailabilityStatus.Available,
                "insufficient" => HardwareAvailabilityStatus.Insufficient,
                "unavailable" => HardwareAvailabilityStatus.Unavailable,
                _ => null,
            };
        }
    }
}