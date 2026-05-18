
#nullable enable

namespace Together
{
    /// <summary>
    /// Filter by remediation mode. Returns only remediations matching the specified mode.
    /// </summary>
    public enum RemediationServiceListRemediationsMode
    {
        /// <summary>
        /// 
        /// </summary>
        RemediationModeEvictWithoutReplacement,
        /// <summary>
        /// 
        /// </summary>
        RemediationModeHostAware,
        /// <summary>
        /// 
        /// </summary>
        RemediationModeRebootVm,
        /// <summary>
        /// 
        /// </summary>
        RemediationModeVmOnly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RemediationServiceListRemediationsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemediationServiceListRemediationsMode value)
        {
            return value switch
            {
                RemediationServiceListRemediationsMode.RemediationModeEvictWithoutReplacement => "REMEDIATION_MODE_EVICT_WITHOUT_REPLACEMENT",
                RemediationServiceListRemediationsMode.RemediationModeHostAware => "REMEDIATION_MODE_HOST_AWARE",
                RemediationServiceListRemediationsMode.RemediationModeRebootVm => "REMEDIATION_MODE_REBOOT_VM",
                RemediationServiceListRemediationsMode.RemediationModeVmOnly => "REMEDIATION_MODE_VM_ONLY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemediationServiceListRemediationsMode? ToEnum(string value)
        {
            return value switch
            {
                "REMEDIATION_MODE_EVICT_WITHOUT_REPLACEMENT" => RemediationServiceListRemediationsMode.RemediationModeEvictWithoutReplacement,
                "REMEDIATION_MODE_HOST_AWARE" => RemediationServiceListRemediationsMode.RemediationModeHostAware,
                "REMEDIATION_MODE_REBOOT_VM" => RemediationServiceListRemediationsMode.RemediationModeRebootVm,
                "REMEDIATION_MODE_VM_ONLY" => RemediationServiceListRemediationsMode.RemediationModeVmOnly,
                _ => null,
            };
        }
    }
}