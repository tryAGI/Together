#nullable enable

namespace Together
{
    public partial interface IRemediationServiceClient
    {
        /// <summary>
        /// Approves a pending remediation.<br/>
        /// Only remediations with state PENDING_APPROVAL can be approved.<br/>
        /// On APPROVE: state changes to PENDING and the remediation process begins.<br/>
        /// The reviewed_by, review_time, and review_comment fields are populated<br/>
        /// on the remediation after approval.
        /// </summary>
        /// <param name="clusterId"></param>
        /// <param name="instanceId"></param>
        /// <param name="remediationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.Remediation> RemediationServiceApproveRemediationAsync(
            string clusterId,
            string instanceId,
            string remediationId,

            global::Together.ApproveRemediationRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Approves a pending remediation.<br/>
        /// Only remediations with state PENDING_APPROVAL can be approved.<br/>
        /// On APPROVE: state changes to PENDING and the remediation process begins.<br/>
        /// The reviewed_by, review_time, and review_comment fields are populated<br/>
        /// on the remediation after approval.
        /// </summary>
        /// <param name="clusterId"></param>
        /// <param name="instanceId"></param>
        /// <param name="remediationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.Remediation>> RemediationServiceApproveRemediationAsResponseAsync(
            string clusterId,
            string instanceId,
            string remediationId,

            global::Together.ApproveRemediationRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Approves a pending remediation.<br/>
        /// Only remediations with state PENDING_APPROVAL can be approved.<br/>
        /// On APPROVE: state changes to PENDING and the remediation process begins.<br/>
        /// The reviewed_by, review_time, and review_comment fields are populated<br/>
        /// on the remediation after approval.
        /// </summary>
        /// <param name="clusterId"></param>
        /// <param name="instanceId"></param>
        /// <param name="remediationId"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.Remediation> RemediationServiceApproveRemediationAsync(
            string clusterId,
            string instanceId,
            string remediationId,
            string? comment = default,
            global::Together.ApproveRemediationRequestMode? mode = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}