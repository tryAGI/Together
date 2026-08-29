
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public enum HealthCheckServiceListPassiveHealthCheckAlertsSeverityFilterItem
    {
        /// <summary>
        ///
        /// </summary>
        PhcSeverityCritical,
        /// <summary>
        ///
        /// </summary>
        PhcSeverityInfo,
        /// <summary>
        ///
        /// </summary>
        PhcSeverityWarning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HealthCheckServiceListPassiveHealthCheckAlertsSeverityFilterItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HealthCheckServiceListPassiveHealthCheckAlertsSeverityFilterItem value)
        {
            return value switch
            {
                HealthCheckServiceListPassiveHealthCheckAlertsSeverityFilterItem.PhcSeverityCritical => "PHC_SEVERITY_CRITICAL",
                HealthCheckServiceListPassiveHealthCheckAlertsSeverityFilterItem.PhcSeverityInfo => "PHC_SEVERITY_INFO",
                HealthCheckServiceListPassiveHealthCheckAlertsSeverityFilterItem.PhcSeverityWarning => "PHC_SEVERITY_WARNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HealthCheckServiceListPassiveHealthCheckAlertsSeverityFilterItem? ToEnum(string value)
        {
            return value switch
            {
                "PHC_SEVERITY_CRITICAL" => HealthCheckServiceListPassiveHealthCheckAlertsSeverityFilterItem.PhcSeverityCritical,
                "PHC_SEVERITY_INFO" => HealthCheckServiceListPassiveHealthCheckAlertsSeverityFilterItem.PhcSeverityInfo,
                "PHC_SEVERITY_WARNING" => HealthCheckServiceListPassiveHealthCheckAlertsSeverityFilterItem.PhcSeverityWarning,
                _ => null,
            };
        }
    }
}