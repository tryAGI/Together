
#nullable enable

namespace Together
{
    /// <summary>
    /// Filter endpoints by usage type
    /// </summary>
    public enum ListEndpointsUsageType
    {
        /// <summary>
        /// 
        /// </summary>
        OnDemand,
        /// <summary>
        /// 
        /// </summary>
        Reserved,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListEndpointsUsageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListEndpointsUsageType value)
        {
            return value switch
            {
                ListEndpointsUsageType.OnDemand => "on-demand",
                ListEndpointsUsageType.Reserved => "reserved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListEndpointsUsageType? ToEnum(string value)
        {
            return value switch
            {
                "on-demand" => ListEndpointsUsageType.OnDemand,
                "reserved" => ListEndpointsUsageType.Reserved,
                _ => null,
            };
        }
    }
}