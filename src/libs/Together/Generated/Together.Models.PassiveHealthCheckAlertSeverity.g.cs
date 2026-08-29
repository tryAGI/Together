
#nullable enable

namespace Together
{
    /// <summary>
    /// Canonical severity tier for the alert.<br/>
    /// Included only in responses
    /// </summary>
    public enum PassiveHealthCheckAlertSeverity
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
    public static class PassiveHealthCheckAlertSeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PassiveHealthCheckAlertSeverity value)
        {
            return value switch
            {
                PassiveHealthCheckAlertSeverity.PhcSeverityCritical => "PHC_SEVERITY_CRITICAL",
                PassiveHealthCheckAlertSeverity.PhcSeverityInfo => "PHC_SEVERITY_INFO",
                PassiveHealthCheckAlertSeverity.PhcSeverityWarning => "PHC_SEVERITY_WARNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PassiveHealthCheckAlertSeverity? ToEnum(string value)
        {
            return value switch
            {
                "PHC_SEVERITY_CRITICAL" => PassiveHealthCheckAlertSeverity.PhcSeverityCritical,
                "PHC_SEVERITY_INFO" => PassiveHealthCheckAlertSeverity.PhcSeverityInfo,
                "PHC_SEVERITY_WARNING" => PassiveHealthCheckAlertSeverity.PhcSeverityWarning,
                _ => null,
            };
        }
    }
}