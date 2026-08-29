
#nullable enable

namespace Together
{
    /// <summary>
    /// Sort order for returned alerts. Omit for newest alerts first.<br/>
    /// Default Value: PHC_ALERT_ORDER_STARTED_AT_DESC
    /// </summary>
    public enum HealthCheckServiceListPassiveHealthCheckAlertsOrderBy
    {
        /// <summary>
        ///
        /// </summary>
        PhcAlertOrderStartedAtAsc,
        /// <summary>
        ///
        /// </summary>
        PhcAlertOrderStartedAtDesc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HealthCheckServiceListPassiveHealthCheckAlertsOrderByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HealthCheckServiceListPassiveHealthCheckAlertsOrderBy value)
        {
            return value switch
            {
                HealthCheckServiceListPassiveHealthCheckAlertsOrderBy.PhcAlertOrderStartedAtAsc => "PHC_ALERT_ORDER_STARTED_AT_ASC",
                HealthCheckServiceListPassiveHealthCheckAlertsOrderBy.PhcAlertOrderStartedAtDesc => "PHC_ALERT_ORDER_STARTED_AT_DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HealthCheckServiceListPassiveHealthCheckAlertsOrderBy? ToEnum(string value)
        {
            return value switch
            {
                "PHC_ALERT_ORDER_STARTED_AT_ASC" => HealthCheckServiceListPassiveHealthCheckAlertsOrderBy.PhcAlertOrderStartedAtAsc,
                "PHC_ALERT_ORDER_STARTED_AT_DESC" => HealthCheckServiceListPassiveHealthCheckAlertsOrderBy.PhcAlertOrderStartedAtDesc,
                _ => null,
            };
        }
    }
}