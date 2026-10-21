#nullable enable

namespace Together
{
    public partial interface IRemediationServiceClient
    {
        /// <summary>
        /// Retrieve the status of a specific remdiation on a specific instance in a specific cluster.
        /// </summary>
        /// <param name="clusterId"></param>
        /// <param name="instanceId"></param>
        /// <param name="remediationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// remediation = client.clusters.remediations.retrieve(<br/>
        ///     "&lt;REMEDIATION_ID&gt;",<br/>
        ///     cluster_id="&lt;CLUSTER_ID&gt;",<br/>
        ///     instance_id="&lt;INSTANCE_ID&gt;",<br/>
        /// )<br/>
        /// print(remediation.state)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.Remediation> RemediationServiceGetRemediationAsync(
            string clusterId,
            string instanceId,
            string remediationId,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve the status of a specific remdiation on a specific instance in a specific cluster.
        /// </summary>
        /// <param name="clusterId"></param>
        /// <param name="instanceId"></param>
        /// <param name="remediationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// remediation = client.clusters.remediations.retrieve(<br/>
        ///     "&lt;REMEDIATION_ID&gt;",<br/>
        ///     cluster_id="&lt;CLUSTER_ID&gt;",<br/>
        ///     instance_id="&lt;INSTANCE_ID&gt;",<br/>
        /// )<br/>
        /// print(remediation.state)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.Remediation>> RemediationServiceGetRemediationAsResponseAsync(
            string clusterId,
            string instanceId,
            string remediationId,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}