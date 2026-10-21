#nullable enable

namespace Together
{
    public partial interface IRemediationServiceClient
    {
        /// <summary>
        /// List remediations<br/>
        /// Lists remediations for an instance or cluster.
        /// </summary>
        /// <param name="clusterId"></param>
        /// <param name="instanceId">
        /// To list remediations on a specific node, pass the node's instance ID.<br/>
        /// To list remediations for all nodes in a cluster, pass `-` as a wildcard for the instance ID.
        /// </param>
        /// <param name="pageSize">
        /// Maximum results to return.
        /// </param>
        /// <param name="pageToken">
        /// Pagination token from previous request.
        /// </param>
        /// <param name="state">
        /// Filter by state(s). Returns remediations matching any of the specified states.<br/>
        /// - `PENDING_APPROVAL`: Awaiting approval before processing can begin.<br/>
        /// - `PENDING`: Approved and queued for processing.<br/>
        /// - `RUNNING`: Actively being processed.<br/>
        /// - `SUCCEEDED`: Successfully completed.<br/>
        /// - `FAILED`: Failed with an error.<br/>
        /// - `CANCELLED`: Cancelled by user or system.<br/>
        /// - `AUTO_RESOLVED`: The underlying issue was automatically resolved before processing.<br/>
        /// - `QUARANTINING`: Cordoning or preparing the host before remediation.<br/>
        /// - `QUARANTINED`: Host has been cordoned or isolated for remediation.
        /// </param>
        /// <param name="orderBy">
        /// Order by expression.
        /// </param>
        /// <param name="trigger">
        /// Filter by trigger type(s). Returns remediations matching any of the specified triggers.
        /// </param>
        /// <param name="mode">
        /// Filter by remediation mode(s). Returns remediations matching any of the specified modes.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.ListRemediationsResponse> RemediationServiceListRemediationsAsync(
            string clusterId,
            string instanceId,
            int? pageSize = default,
            string? pageToken = default,
            global::System.Collections.Generic.IList<global::Together.RemediationServiceListRemediationsStateItem>? state = default,
            string? orderBy = default,
            global::System.Collections.Generic.IList<global::Together.RemediationServiceListRemediationsTriggerItem>? trigger = default,
            global::System.Collections.Generic.IList<global::Together.RemediationServiceListRemediationsModeItem>? mode = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List remediations<br/>
        /// Lists remediations for an instance or cluster.
        /// </summary>
        /// <param name="clusterId"></param>
        /// <param name="instanceId">
        /// To list remediations on a specific node, pass the node's instance ID.<br/>
        /// To list remediations for all nodes in a cluster, pass `-` as a wildcard for the instance ID.
        /// </param>
        /// <param name="pageSize">
        /// Maximum results to return.
        /// </param>
        /// <param name="pageToken">
        /// Pagination token from previous request.
        /// </param>
        /// <param name="state">
        /// Filter by state(s). Returns remediations matching any of the specified states.<br/>
        /// - `PENDING_APPROVAL`: Awaiting approval before processing can begin.<br/>
        /// - `PENDING`: Approved and queued for processing.<br/>
        /// - `RUNNING`: Actively being processed.<br/>
        /// - `SUCCEEDED`: Successfully completed.<br/>
        /// - `FAILED`: Failed with an error.<br/>
        /// - `CANCELLED`: Cancelled by user or system.<br/>
        /// - `AUTO_RESOLVED`: The underlying issue was automatically resolved before processing.<br/>
        /// - `QUARANTINING`: Cordoning or preparing the host before remediation.<br/>
        /// - `QUARANTINED`: Host has been cordoned or isolated for remediation.
        /// </param>
        /// <param name="orderBy">
        /// Order by expression.
        /// </param>
        /// <param name="trigger">
        /// Filter by trigger type(s). Returns remediations matching any of the specified triggers.
        /// </param>
        /// <param name="mode">
        /// Filter by remediation mode(s). Returns remediations matching any of the specified modes.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.ListRemediationsResponse>> RemediationServiceListRemediationsAsResponseAsync(
            string clusterId,
            string instanceId,
            int? pageSize = default,
            string? pageToken = default,
            global::System.Collections.Generic.IList<global::Together.RemediationServiceListRemediationsStateItem>? state = default,
            string? orderBy = default,
            global::System.Collections.Generic.IList<global::Together.RemediationServiceListRemediationsTriggerItem>? trigger = default,
            global::System.Collections.Generic.IList<global::Together.RemediationServiceListRemediationsModeItem>? mode = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}