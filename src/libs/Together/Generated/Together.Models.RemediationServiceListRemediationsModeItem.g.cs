
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public enum RemediationServiceListRemediationsModeItem
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
        RemediationModeHostPowerCycle,
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
    public static class RemediationServiceListRemediationsModeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemediationServiceListRemediationsModeItem value)
        {
            return value switch
            {
                RemediationServiceListRemediationsModeItem.RemediationModeEvictWithoutReplacement => "REMEDIATION_MODE_EVICT_WITHOUT_REPLACEMENT",
                RemediationServiceListRemediationsModeItem.RemediationModeHostAware => "REMEDIATION_MODE_HOST_AWARE",
                RemediationServiceListRemediationsModeItem.RemediationModeHostPowerCycle => "REMEDIATION_MODE_HOST_POWER_CYCLE",
                RemediationServiceListRemediationsModeItem.RemediationModeRebootVm => "REMEDIATION_MODE_REBOOT_VM",
                RemediationServiceListRemediationsModeItem.RemediationModeVmOnly => "REMEDIATION_MODE_VM_ONLY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemediationServiceListRemediationsModeItem? ToEnum(string value)
        {
            return value switch
            {
                "REMEDIATION_MODE_EVICT_WITHOUT_REPLACEMENT" => RemediationServiceListRemediationsModeItem.RemediationModeEvictWithoutReplacement,
                "REMEDIATION_MODE_HOST_AWARE" => RemediationServiceListRemediationsModeItem.RemediationModeHostAware,
                "REMEDIATION_MODE_HOST_POWER_CYCLE" => RemediationServiceListRemediationsModeItem.RemediationModeHostPowerCycle,
                "REMEDIATION_MODE_REBOOT_VM" => RemediationServiceListRemediationsModeItem.RemediationModeRebootVm,
                "REMEDIATION_MODE_VM_ONLY" => RemediationServiceListRemediationsModeItem.RemediationModeVmOnly,
                _ => null,
            };
        }
    }
}