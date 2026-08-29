
#nullable enable

namespace Together
{
    /// <summary>
    /// Remediation mode specifies how the remediation should be performed.<br/>
    /// - `REMEDIATION_MODE_VM_ONLY`: Deletes the VM and provisions a new one on any available host.<br/>
    /// - `REMEDIATION_MODE_HOST_AWARE`: Cordons the host, deletes the VM, and provisions a new one on a different host.<br/>
    /// - `REMEDIATION_MODE_EVICT_WITHOUT_REPLACEMENT`: Evicts the VM without provisioning a replacement.<br/>
    /// - `REMEDIATION_MODE_REBOOT_VM`: Reboots the VM in place.<br/>
    /// - `REMEDIATION_MODE_HOST_POWER_CYCLE`: Cordons and power-cycles the bare-metal host while preserving host and node identity.
    /// </summary>
    public enum RemediationMode
    {
        /// <summary>
        /// Evicts the VM without provisioning a replacement.
        /// </summary>
        EvictWithoutReplacement,
        /// <summary>
        /// Cordons the host, deletes the VM, and provisions a new one on a different host.
        /// </summary>
        HostAware,
        /// <summary>
        /// Cordons and power-cycles the bare-metal host while preserving host and node identity.
        /// </summary>
        HostPowerCycle,
        /// <summary>
        /// Reboots the VM in place.
        /// </summary>
        RebootVm,
        /// <summary>
        /// Deletes the VM and provisions a new one on any available host.
        /// </summary>
        VmOnly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RemediationModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemediationMode value)
        {
            return value switch
            {
                RemediationMode.EvictWithoutReplacement => "REMEDIATION_MODE_EVICT_WITHOUT_REPLACEMENT",
                RemediationMode.HostAware => "REMEDIATION_MODE_HOST_AWARE",
                RemediationMode.HostPowerCycle => "REMEDIATION_MODE_HOST_POWER_CYCLE",
                RemediationMode.RebootVm => "REMEDIATION_MODE_REBOOT_VM",
                RemediationMode.VmOnly => "REMEDIATION_MODE_VM_ONLY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemediationMode? ToEnum(string value)
        {
            return value switch
            {
                "REMEDIATION_MODE_EVICT_WITHOUT_REPLACEMENT" => RemediationMode.EvictWithoutReplacement,
                "REMEDIATION_MODE_HOST_AWARE" => RemediationMode.HostAware,
                "REMEDIATION_MODE_HOST_POWER_CYCLE" => RemediationMode.HostPowerCycle,
                "REMEDIATION_MODE_REBOOT_VM" => RemediationMode.RebootVm,
                "REMEDIATION_MODE_VM_ONLY" => RemediationMode.VmOnly,
                _ => null,
            };
        }
    }
}