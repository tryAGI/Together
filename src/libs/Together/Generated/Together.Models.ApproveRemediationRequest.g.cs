
#nullable enable

namespace Together
{
    /// <summary>
    /// Request body for approving a pending remediation.
    /// </summary>
    public sealed partial class ApproveRemediationRequest
    {
        /// <summary>
        /// Approval comment explaining the decision.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Remediation mode to use after approval. When omitted, the remediation keeps its existing mode.<br/>
        /// - `REMEDIATION_MODE_VM_ONLY`: Deletes the VM and provisions a new one on any available host.<br/>
        /// - `REMEDIATION_MODE_HOST_AWARE`: Cordons the host, deletes the VM, and provisions a new one on a different host.<br/>
        /// - `REMEDIATION_MODE_EVICT_WITHOUT_REPLACEMENT`: Evicts the VM without provisioning a replacement.<br/>
        /// - `REMEDIATION_MODE_REBOOT_VM`: Reboots the VM in place.<br/>
        /// - `REMEDIATION_MODE_HOST_POWER_CYCLE`: Power-cycles the bare-metal host after cordoning it. This mode cannot be set as an approval override; create a host power-cycle remediation directly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.ApproveRemediationRequestModeJsonConverter))]
        public global::Together.ApproveRemediationRequestMode? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApproveRemediationRequest" /> class.
        /// </summary>
        /// <param name="comment">
        /// Approval comment explaining the decision.
        /// </param>
        /// <param name="mode">
        /// Remediation mode to use after approval. When omitted, the remediation keeps its existing mode.<br/>
        /// - `REMEDIATION_MODE_VM_ONLY`: Deletes the VM and provisions a new one on any available host.<br/>
        /// - `REMEDIATION_MODE_HOST_AWARE`: Cordons the host, deletes the VM, and provisions a new one on a different host.<br/>
        /// - `REMEDIATION_MODE_EVICT_WITHOUT_REPLACEMENT`: Evicts the VM without provisioning a replacement.<br/>
        /// - `REMEDIATION_MODE_REBOOT_VM`: Reboots the VM in place.<br/>
        /// - `REMEDIATION_MODE_HOST_POWER_CYCLE`: Power-cycles the bare-metal host after cordoning it. This mode cannot be set as an approval override; create a host power-cycle remediation directly.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApproveRemediationRequest(
            string? comment,
            global::Together.ApproveRemediationRequestMode? mode)
        {
            this.Comment = comment;
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApproveRemediationRequest" /> class.
        /// </summary>
        public ApproveRemediationRequest()
        {
        }

    }
}