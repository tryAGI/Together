#nullable enable

namespace Together
{
    public partial interface IRemediationServiceClient
    {
        /// <summary>
        /// Cancels a pending remediation.<br/>
        /// Only remediations in PENDING_APPROVAL or PENDING state can be cancelled.
        /// </summary>
        /// <param name="clusterId">
        /// The cluster ID.
        /// </param>
        /// <param name="instanceId">
        /// The instance ID.
        /// </param>
        /// <param name="remediationId">
        /// The remediation ID.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// remediation = client.clusters.remediations.cancel(<br/>
        ///     "&lt;REMEDIATION_ID&gt;",<br/>
        ///     cluster_id="&lt;CLUSTER_ID&gt;",<br/>
        ///     instance_id="&lt;INSTANCE_ID&gt;",<br/>
        /// )<br/>
        /// print(remediation.state)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.Remediation> RemediationServiceCancelRemediationAsync(
            string clusterId,
            string instanceId,
            string remediationId,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancels a pending remediation.<br/>
        /// Only remediations in PENDING_APPROVAL or PENDING state can be cancelled.
        /// </summary>
        /// <param name="clusterId">
        /// The cluster ID.
        /// </param>
        /// <param name="instanceId">
        /// The instance ID.
        /// </param>
        /// <param name="remediationId">
        /// The remediation ID.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// remediation = client.clusters.remediations.cancel(<br/>
        ///     "&lt;REMEDIATION_ID&gt;",<br/>
        ///     cluster_id="&lt;CLUSTER_ID&gt;",<br/>
        ///     instance_id="&lt;INSTANCE_ID&gt;",<br/>
        /// )<br/>
        /// print(remediation.state)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.Remediation>> RemediationServiceCancelRemediationAsResponseAsync(
            string clusterId,
            string instanceId,
            string remediationId,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}