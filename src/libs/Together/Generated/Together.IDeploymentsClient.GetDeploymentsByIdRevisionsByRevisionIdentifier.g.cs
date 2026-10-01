#nullable enable

namespace Together
{
    public partial interface IDeploymentsClient
    {
        /// <summary>
        /// Get the full configuration of a specific revision<br/>
        /// Returns the deployment configuration defined by the specified revision.<br/>
        /// Only the 50 most recent revisions per deployment retain their configuration; older revisions return 404 even while they still appear in the revision history.<br/>
        /// The deployment's currently active revision is always available, regardless of age.
        /// </summary>
        /// <param name="id">
        /// Deployment ID or name.
        /// </param>
        /// <param name="revisionIdentifier">
        /// Revision number or revision ID.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RevisionDetailResponse> GetDeploymentsByIdRevisionsByRevisionIdentifierAsync(
            string id,
            string revisionIdentifier,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the full configuration of a specific revision<br/>
        /// Returns the deployment configuration defined by the specified revision.<br/>
        /// Only the 50 most recent revisions per deployment retain their configuration; older revisions return 404 even while they still appear in the revision history.<br/>
        /// The deployment's currently active revision is always available, regardless of age.
        /// </summary>
        /// <param name="id">
        /// Deployment ID or name.
        /// </param>
        /// <param name="revisionIdentifier">
        /// Revision number or revision ID.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.RevisionDetailResponse>> GetDeploymentsByIdRevisionsByRevisionIdentifierAsResponseAsync(
            string id,
            string revisionIdentifier,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}