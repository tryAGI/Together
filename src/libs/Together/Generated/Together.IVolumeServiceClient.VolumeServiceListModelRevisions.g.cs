#nullable enable

namespace Together
{
    public partial interface IVolumeServiceClient
    {
        /// <summary>
        /// List model revisions<br/>
        /// Lists the immutable file revisions available for a custom model, newest first.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="id">
        /// Model identifier.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// identity = client.whoami()<br/>
        /// if identity.type != "project_api_key":<br/>
        ///     raise RuntimeError("TOGETHER_API_KEY must be a project API key")<br/>
        /// project_id = identity.project.id<br/>
        /// revisions = client.models.list_revisions(<br/>
        ///     "ml_abc123",<br/>
        ///     project_id=project_id,<br/>
        /// )<br/>
        /// print(revisions)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.DeListRevisionsResponse> VolumeServiceListModelRevisionsAsync(
            string projectId,
            string id,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List model revisions<br/>
        /// Lists the immutable file revisions available for a custom model, newest first.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="id">
        /// Model identifier.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// identity = client.whoami()<br/>
        /// if identity.type != "project_api_key":<br/>
        ///     raise RuntimeError("TOGETHER_API_KEY must be a project API key")<br/>
        /// project_id = identity.project.id<br/>
        /// revisions = client.models.list_revisions(<br/>
        ///     "ml_abc123",<br/>
        ///     project_id=project_id,<br/>
        /// )<br/>
        /// print(revisions)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeListRevisionsResponse>> VolumeServiceListModelRevisionsAsResponseAsync(
            string projectId,
            string id,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}