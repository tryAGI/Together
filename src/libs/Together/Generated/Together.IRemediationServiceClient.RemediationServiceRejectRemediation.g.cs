#nullable enable

namespace Together
{
    public partial interface IRemediationServiceClient
    {
        /// <summary>
        /// Rejects a pending remediation.<br/>
        /// Only remediations with state PENDING_APPROVAL can be rejected.<br/>
        /// On REJECT: state changes to CANCELLED.<br/>
        /// The reviewed_by, review_time, and review_comment fields are populated<br/>
        /// on the remediation after rejection.
        /// </summary>
        /// <param name="clusterId"></param>
        /// <param name="instanceId"></param>
        /// <param name="remediationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.Remediation> RemediationServiceRejectRemediationAsync(
            string clusterId,
            string instanceId,
            string remediationId,

            global::Together.CommentBody request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rejects a pending remediation.<br/>
        /// Only remediations with state PENDING_APPROVAL can be rejected.<br/>
        /// On REJECT: state changes to CANCELLED.<br/>
        /// The reviewed_by, review_time, and review_comment fields are populated<br/>
        /// on the remediation after rejection.
        /// </summary>
        /// <param name="clusterId"></param>
        /// <param name="instanceId"></param>
        /// <param name="remediationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.Remediation>> RemediationServiceRejectRemediationAsResponseAsync(
            string clusterId,
            string instanceId,
            string remediationId,

            global::Together.CommentBody request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rejects a pending remediation.<br/>
        /// Only remediations with state PENDING_APPROVAL can be rejected.<br/>
        /// On REJECT: state changes to CANCELLED.<br/>
        /// The reviewed_by, review_time, and review_comment fields are populated<br/>
        /// on the remediation after rejection.
        /// </summary>
        /// <param name="clusterId"></param>
        /// <param name="instanceId"></param>
        /// <param name="remediationId"></param>
        /// <param name="comment">
        /// Comment explaining the action.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.Remediation> RemediationServiceRejectRemediationAsync(
            string clusterId,
            string instanceId,
            string remediationId,
            string? comment = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}