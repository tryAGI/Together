#nullable enable

namespace Together
{
    public partial interface IVolumeServiceClient
    {
        /// <summary>
        /// Get a model volume revision<br/>
        /// Retrieves metadata for one immutable revision of a custom model's files.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="id">
        /// Model identifier.
        /// </param>
        /// <param name="revisionId">
        /// Revision identifier.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// project_id = client.whoami().project_id<br/>
        /// # The SDK has no dedicated method for this endpoint yet, so call it with<br/>
        /// # the client's generic GET helper.<br/>
        /// url = (<br/>
        ///     f"https://api.together.ai/v2/projects/{project_id}"<br/>
        ///     "/models/ml_abc123/revisions/rv_abc123"<br/>
        /// )<br/>
        /// revision = client.get(url, cast_to=object)<br/>
        /// print(revision)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.DeListRevisionsResponseRevision> VolumeServiceGetRevisionByModelTypeAsync(
            string projectId,
            string id,
            string revisionId,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a model volume revision<br/>
        /// Retrieves metadata for one immutable revision of a custom model's files.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="id">
        /// Model identifier.
        /// </param>
        /// <param name="revisionId">
        /// Revision identifier.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// project_id = client.whoami().project_id<br/>
        /// # The SDK has no dedicated method for this endpoint yet, so call it with<br/>
        /// # the client's generic GET helper.<br/>
        /// url = (<br/>
        ///     f"https://api.together.ai/v2/projects/{project_id}"<br/>
        ///     "/models/ml_abc123/revisions/rv_abc123"<br/>
        /// )<br/>
        /// revision = client.get(url, cast_to=object)<br/>
        /// print(revision)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeListRevisionsResponseRevision>> VolumeServiceGetRevisionByModelTypeAsResponseAsync(
            string projectId,
            string id,
            string revisionId,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}