
#nullable enable

namespace Together
{
    /// <summary>
    /// RemediationTrigger specifies how the remediation was triggered.<br/>
    /// - `REMEDIATION_TRIGGER_MANUAL`: A user-initiated remediation (either via web UI or API call).<br/>
    /// - `REMEDIATION_TRIGGER_AUTOMATED`: A system-initiated remediation that requires approval.<br/>
    /// Included only in responses
    /// </summary>
    public enum RemediationTrigger
    {
        /// <summary>
        /// A system-initiated remediation that requires approval.
        /// </summary>
        Automated,
        /// <summary>
        /// A user-initiated remediation (either via web UI or API call).
        /// </summary>
        Manual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RemediationTriggerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemediationTrigger value)
        {
            return value switch
            {
                RemediationTrigger.Automated => "REMEDIATION_TRIGGER_AUTOMATED",
                RemediationTrigger.Manual => "REMEDIATION_TRIGGER_MANUAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemediationTrigger? ToEnum(string value)
        {
            return value switch
            {
                "REMEDIATION_TRIGGER_AUTOMATED" => RemediationTrigger.Automated,
                "REMEDIATION_TRIGGER_MANUAL" => RemediationTrigger.Manual,
                _ => null,
            };
        }
    }
}