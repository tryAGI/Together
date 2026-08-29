
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public enum RemediationServiceListRemediationsStateItem
    {
        /// <summary>
        ///
        /// </summary>
        AutoResolved,
        /// <summary>
        ///
        /// </summary>
        Cancelled,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Pending,
        /// <summary>
        ///
        /// </summary>
        PendingApproval,
        /// <summary>
        ///
        /// </summary>
        Quarantined,
        /// <summary>
        ///
        /// </summary>
        Quarantining,
        /// <summary>
        ///
        /// </summary>
        Running,
        /// <summary>
        ///
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RemediationServiceListRemediationsStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemediationServiceListRemediationsStateItem value)
        {
            return value switch
            {
                RemediationServiceListRemediationsStateItem.AutoResolved => "AUTO_RESOLVED",
                RemediationServiceListRemediationsStateItem.Cancelled => "CANCELLED",
                RemediationServiceListRemediationsStateItem.Failed => "FAILED",
                RemediationServiceListRemediationsStateItem.Pending => "PENDING",
                RemediationServiceListRemediationsStateItem.PendingApproval => "PENDING_APPROVAL",
                RemediationServiceListRemediationsStateItem.Quarantined => "QUARANTINED",
                RemediationServiceListRemediationsStateItem.Quarantining => "QUARANTINING",
                RemediationServiceListRemediationsStateItem.Running => "RUNNING",
                RemediationServiceListRemediationsStateItem.Succeeded => "SUCCEEDED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemediationServiceListRemediationsStateItem? ToEnum(string value)
        {
            return value switch
            {
                "AUTO_RESOLVED" => RemediationServiceListRemediationsStateItem.AutoResolved,
                "CANCELLED" => RemediationServiceListRemediationsStateItem.Cancelled,
                "FAILED" => RemediationServiceListRemediationsStateItem.Failed,
                "PENDING" => RemediationServiceListRemediationsStateItem.Pending,
                "PENDING_APPROVAL" => RemediationServiceListRemediationsStateItem.PendingApproval,
                "QUARANTINED" => RemediationServiceListRemediationsStateItem.Quarantined,
                "QUARANTINING" => RemediationServiceListRemediationsStateItem.Quarantining,
                "RUNNING" => RemediationServiceListRemediationsStateItem.Running,
                "SUCCEEDED" => RemediationServiceListRemediationsStateItem.Succeeded,
                _ => null,
            };
        }
    }
}