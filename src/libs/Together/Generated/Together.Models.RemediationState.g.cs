
#nullable enable

namespace Together
{
    /// <summary>
    /// RemediationState represents the lifecycle state of a remediation.<br/>
    /// - `PENDING_APPROVAL`: Awaiting approval before processing can begin.<br/>
    /// - `PENDING`: Approved and queued for processing.<br/>
    /// - `RUNNING`: Actively being processed.<br/>
    /// - `SUCCEEDED`: Successfully completed.<br/>
    /// - `FAILED`: Failed with an error.<br/>
    /// - `CANCELLED`: Cancelled by user or system.<br/>
    /// - `AUTO_RESOLVED`: The underlying issue was automatically resolved before processing.<br/>
    /// - `QUARANTINING`: Cordoning or preparing the host before remediation.<br/>
    /// - `QUARANTINED`: Host has been cordoned or isolated for remediation.<br/>
    /// Included only in responses
    /// </summary>
    public enum RemediationState
    {
        /// <summary>
        /// The underlying issue was automatically resolved before processing.
        /// </summary>
        AutoResolved,
        /// <summary>
        /// Cancelled by user or system.
        /// </summary>
        Cancelled,
        /// <summary>
        /// Failed with an error.
        /// </summary>
        Failed,
        /// <summary>
        /// Awaiting approval before processing can begin.
        /// </summary>
        Pending,
        /// <summary>
        /// Awaiting approval before processing can begin.
        /// </summary>
        PendingApproval,
        /// <summary>
        /// Host has been cordoned or isolated for remediation.
        /// </summary>
        Quarantined,
        /// <summary>
        /// Cordoning or preparing the host before remediation.
        /// </summary>
        Quarantining,
        /// <summary>
        /// Actively being processed.
        /// </summary>
        Running,
        /// <summary>
        /// Successfully completed.
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RemediationStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemediationState value)
        {
            return value switch
            {
                RemediationState.AutoResolved => "AUTO_RESOLVED",
                RemediationState.Cancelled => "CANCELLED",
                RemediationState.Failed => "FAILED",
                RemediationState.Pending => "PENDING",
                RemediationState.PendingApproval => "PENDING_APPROVAL",
                RemediationState.Quarantined => "QUARANTINED",
                RemediationState.Quarantining => "QUARANTINING",
                RemediationState.Running => "RUNNING",
                RemediationState.Succeeded => "SUCCEEDED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemediationState? ToEnum(string value)
        {
            return value switch
            {
                "AUTO_RESOLVED" => RemediationState.AutoResolved,
                "CANCELLED" => RemediationState.Cancelled,
                "FAILED" => RemediationState.Failed,
                "PENDING" => RemediationState.Pending,
                "PENDING_APPROVAL" => RemediationState.PendingApproval,
                "QUARANTINED" => RemediationState.Quarantined,
                "QUARANTINING" => RemediationState.Quarantining,
                "RUNNING" => RemediationState.Running,
                "SUCCEEDED" => RemediationState.Succeeded,
                _ => null,
            };
        }
    }
}