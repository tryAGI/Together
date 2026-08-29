
#nullable enable

namespace Together
{
    /// <summary>
    /// Time window size for rows. 'hour' returns ~24x more rows than 'day'.<br/>
    /// Default Value: day
    /// </summary>
    public enum GetBillingUsageGranularity
    {
        /// <summary>
        ///
        /// </summary>
        Day,
        /// <summary>
        ///
        /// </summary>
        Hour,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetBillingUsageGranularityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetBillingUsageGranularity value)
        {
            return value switch
            {
                GetBillingUsageGranularity.Day => "day",
                GetBillingUsageGranularity.Hour => "hour",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetBillingUsageGranularity? ToEnum(string value)
        {
            return value switch
            {
                "day" => GetBillingUsageGranularity.Day,
                "hour" => GetBillingUsageGranularity.Hour,
                _ => null,
            };
        }
    }
}