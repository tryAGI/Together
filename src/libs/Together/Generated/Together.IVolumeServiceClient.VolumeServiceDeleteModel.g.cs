#nullable enable

namespace Together
{
    public partial interface IVolumeServiceClient
    {
        /// <summary>
        /// Delete a model<br/>
        /// Permanently deletes a custom model resource. The model must not be in use by an active deployment.
        /// </summary>
        /// <param name="projectId">
        /// ID of the project that owns the model.
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
        /// project_id = client.whoami().project_id<br/>
        /// client.beta.models.delete("ml_abc123", project_id=project_id)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.DeDeleteResponse> VolumeServiceDeleteModelAsync(
            string projectId,
            string id,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a model<br/>
        /// Permanently deletes a custom model resource. The model must not be in use by an active deployment.
        /// </summary>
        /// <param name="projectId">
        /// ID of the project that owns the model.
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
        /// project_id = client.whoami().project_id<br/>
        /// client.beta.models.delete("ml_abc123", project_id=project_id)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeDeleteResponse>> VolumeServiceDeleteModelAsResponseAsync(
            string projectId,
            string id,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}