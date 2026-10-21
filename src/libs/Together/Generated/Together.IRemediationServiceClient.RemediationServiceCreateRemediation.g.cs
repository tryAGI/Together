#nullable enable

namespace Together
{
    public partial interface IRemediationServiceClient
    {
        /// <summary>
        /// Creates a new remediation for an instance.<br/>
        /// Remediations created via the API goes directly to PENDING state.<br/>
        /// Our system may trigger automated remediations that require approval. These remediations are created with PENDING_APPROVAL state.<br/>
        /// The user must call /approve to start the actual remediation process.<br/>
        /// These operations can also be rejected by calling /reject.
        /// </summary>
        /// <param name="clusterId"></param>
        /// <param name="instanceId"></param>
        /// <param name="remediationId">
        /// Client-specified ID for idempotency.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.Remediation> RemediationServiceCreateRemediationAsync(
            string clusterId,
            string instanceId,

            global::Together.Remediation request,
            string? remediationId = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new remediation for an instance.<br/>
        /// Remediations created via the API goes directly to PENDING state.<br/>
        /// Our system may trigger automated remediations that require approval. These remediations are created with PENDING_APPROVAL state.<br/>
        /// The user must call /approve to start the actual remediation process.<br/>
        /// These operations can also be rejected by calling /reject.
        /// </summary>
        /// <param name="clusterId"></param>
        /// <param name="instanceId"></param>
        /// <param name="remediationId">
        /// Client-specified ID for idempotency.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.Remediation>> RemediationServiceCreateRemediationAsResponseAsync(
            string clusterId,
            string instanceId,

            global::Together.Remediation request,
            string? remediationId = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new remediation for an instance.<br/>
        /// Remediations created via the API goes directly to PENDING state.<br/>
        /// Our system may trigger automated remediations that require approval. These remediations are created with PENDING_APPROVAL state.<br/>
        /// The user must call /approve to start the actual remediation process.<br/>
        /// These operations can also be rejected by calling /reject.
        /// </summary>
        /// <param name="clusterId"></param>
        /// <param name="instanceId"></param>
        /// <param name="remediationId">
        /// Client-specified ID for idempotency.
        /// </param>
        /// <param name="mode">
        /// Remediation mode specifies how the remediation should be performed.<br/>
        /// - `REMEDIATION_MODE_VM_ONLY`: Deletes the VM and provisions a new one on any available host.<br/>
        /// - `REMEDIATION_MODE_HOST_AWARE`: Cordons the host, deletes the VM, and provisions a new one on a different host.<br/>
        /// - `REMEDIATION_MODE_EVICT_WITHOUT_REPLACEMENT`: Evicts the VM without provisioning a replacement.<br/>
        /// - `REMEDIATION_MODE_REBOOT_VM`: Reboots the VM in place.<br/>
        /// - `REMEDIATION_MODE_HOST_POWER_CYCLE`: Cordons and power-cycles the bare-metal host while preserving host and node identity.
        /// </param>
        /// <param name="reason">
        /// User-provided reason for the remediation.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.Remediation> RemediationServiceCreateRemediationAsync(
            string clusterId,
            string instanceId,
            global::Together.RemediationMode mode,
            string? remediationId = default,
            string? reason = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}