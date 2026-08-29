
#nullable enable

namespace Together
{
    /// <summary>
    /// Remediation mode to use after approval. When omitted, the remediation keeps its existing mode.<br/>
    /// - `REMEDIATION_MODE_VM_ONLY`: Deletes the VM and provisions a new one on any available host.<br/>
    /// - `REMEDIATION_MODE_HOST_AWARE`: Cordons the host, deletes the VM, and provisions a new one on a different host.<br/>
    /// - `REMEDIATION_MODE_EVICT_WITHOUT_REPLACEMENT`: Evicts the VM without provisioning a replacement.<br/>
    /// - `REMEDIATION_MODE_REBOOT_VM`: Reboots the VM in place.<br/>
    /// - `REMEDIATION_MODE_HOST_POWER_CYCLE`: Power-cycles the bare-metal host after cordoning it. This mode cannot be set as an approval override; create a host power-cycle remediation directly.
    /// </summary>
    public enum ApproveRemediationRequestMode
    {
        /// <summary>
        /// Evicts the VM without provisioning a replacement.
        /// </summary>
        RemediationModeEvictWithoutReplacement,
        /// <summary>
        /// Cordons the host, deletes the VM, and provisions a new one on a different host.
        /// </summary>
        RemediationModeHostAware,
        /// <summary>
        /// Power-cycles the bare-metal host after cordoning it. This mode cannot be set as an approval override; create a host power-cycle remediation directly.
        /// </summary>
        RemediationModeHostPowerCycle,
        /// <summary>
        /// Reboots the VM in place.
        /// </summary>
        RemediationModeRebootVm,
        /// <summary>
        /// Deletes the VM and provisions a new one on any available host.
        /// </summary>
        RemediationModeVmOnly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApproveRemediationRequestModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApproveRemediationRequestMode value)
        {
            return value switch
            {
                ApproveRemediationRequestMode.RemediationModeEvictWithoutReplacement => "REMEDIATION_MODE_EVICT_WITHOUT_REPLACEMENT",
                ApproveRemediationRequestMode.RemediationModeHostAware => "REMEDIATION_MODE_HOST_AWARE",
                ApproveRemediationRequestMode.RemediationModeHostPowerCycle => "REMEDIATION_MODE_HOST_POWER_CYCLE",
                ApproveRemediationRequestMode.RemediationModeRebootVm => "REMEDIATION_MODE_REBOOT_VM",
                ApproveRemediationRequestMode.RemediationModeVmOnly => "REMEDIATION_MODE_VM_ONLY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApproveRemediationRequestMode? ToEnum(string value)
        {
            return value switch
            {
                "REMEDIATION_MODE_EVICT_WITHOUT_REPLACEMENT" => ApproveRemediationRequestMode.RemediationModeEvictWithoutReplacement,
                "REMEDIATION_MODE_HOST_AWARE" => ApproveRemediationRequestMode.RemediationModeHostAware,
                "REMEDIATION_MODE_HOST_POWER_CYCLE" => ApproveRemediationRequestMode.RemediationModeHostPowerCycle,
                "REMEDIATION_MODE_REBOOT_VM" => ApproveRemediationRequestMode.RemediationModeRebootVm,
                "REMEDIATION_MODE_VM_ONLY" => ApproveRemediationRequestMode.RemediationModeVmOnly,
                _ => null,
            };
        }
    }
}