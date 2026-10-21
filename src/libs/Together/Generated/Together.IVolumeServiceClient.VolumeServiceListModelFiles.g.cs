#nullable enable

namespace Together
{
    public partial interface IVolumeServiceClient
    {
        /// <summary>
        /// List model files<br/>
        /// Lists files in the latest or specified revision of a model, including paths, sizes, and content hashes.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="id">
        /// Model identifier.
        /// </param>
        /// <param name="revisionId">
        /// Revision identifier to read from.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// project_id = client.whoami().project_id<br/>
        /// files = client.beta.models.list_files("ml_abc123", project_id=project_id)<br/>
        /// print(files)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.DeListFilesResponse> VolumeServiceListModelFilesAsync(
            string projectId,
            string id,
            string? revisionId = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List model files<br/>
        /// Lists files in the latest or specified revision of a model, including paths, sizes, and content hashes.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="id">
        /// Model identifier.
        /// </param>
        /// <param name="revisionId">
        /// Revision identifier to read from.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// project_id = client.whoami().project_id<br/>
        /// files = client.beta.models.list_files("ml_abc123", project_id=project_id)<br/>
        /// print(files)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeListFilesResponse>> VolumeServiceListModelFilesAsResponseAsync(
            string projectId,
            string id,
            string? revisionId = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}