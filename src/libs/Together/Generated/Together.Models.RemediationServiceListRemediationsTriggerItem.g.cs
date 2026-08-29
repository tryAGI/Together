
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public enum RemediationServiceListRemediationsTriggerItem
    {
        /// <summary>
        ///
        /// </summary>
        RemediationTriggerAutomated,
        /// <summary>
        ///
        /// </summary>
        RemediationTriggerManual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RemediationServiceListRemediationsTriggerItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemediationServiceListRemediationsTriggerItem value)
        {
            return value switch
            {
                RemediationServiceListRemediationsTriggerItem.RemediationTriggerAutomated => "REMEDIATION_TRIGGER_AUTOMATED",
                RemediationServiceListRemediationsTriggerItem.RemediationTriggerManual => "REMEDIATION_TRIGGER_MANUAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemediationServiceListRemediationsTriggerItem? ToEnum(string value)
        {
            return value switch
            {
                "REMEDIATION_TRIGGER_AUTOMATED" => RemediationServiceListRemediationsTriggerItem.RemediationTriggerAutomated,
                "REMEDIATION_TRIGGER_MANUAL" => RemediationServiceListRemediationsTriggerItem.RemediationTriggerManual,
                _ => null,
            };
        }
    }
}