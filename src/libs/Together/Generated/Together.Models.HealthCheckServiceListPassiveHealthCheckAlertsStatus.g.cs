
#nullable enable

namespace Together
{
    /// <summary>
    /// Lifecycle filter. Omit to return firing alerts.
    /// </summary>
    public enum HealthCheckServiceListPassiveHealthCheckAlertsStatus
    {
        /// <summary>
        ///
        /// </summary>
        PhcAlertStatusAll,
        /// <summary>
        ///
        /// </summary>
        PhcAlertStatusFiring,
        /// <summary>
        ///
        /// </summary>
        PhcAlertStatusResolved,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HealthCheckServiceListPassiveHealthCheckAlertsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HealthCheckServiceListPassiveHealthCheckAlertsStatus value)
        {
            return value switch
            {
                HealthCheckServiceListPassiveHealthCheckAlertsStatus.PhcAlertStatusAll => "PHC_ALERT_STATUS_ALL",
                HealthCheckServiceListPassiveHealthCheckAlertsStatus.PhcAlertStatusFiring => "PHC_ALERT_STATUS_FIRING",
                HealthCheckServiceListPassiveHealthCheckAlertsStatus.PhcAlertStatusResolved => "PHC_ALERT_STATUS_RESOLVED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HealthCheckServiceListPassiveHealthCheckAlertsStatus? ToEnum(string value)
        {
            return value switch
            {
                "PHC_ALERT_STATUS_ALL" => HealthCheckServiceListPassiveHealthCheckAlertsStatus.PhcAlertStatusAll,
                "PHC_ALERT_STATUS_FIRING" => HealthCheckServiceListPassiveHealthCheckAlertsStatus.PhcAlertStatusFiring,
                "PHC_ALERT_STATUS_RESOLVED" => HealthCheckServiceListPassiveHealthCheckAlertsStatus.PhcAlertStatusResolved,
                _ => null,
            };
        }
    }
}