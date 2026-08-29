#nullable enable

namespace Together
{
    public partial interface IVolumeServiceClient
    {
        /// <summary>
        /// Create a remote model upload<br/>
        /// Starts an asynchronous job that imports model files from Hugging Face or a presigned URL into a registered model and creates a model revision when the import completes.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeRemoteUpload> VolumeServiceCreateRemoteModelUploadAsync(
            string projectId,

            global::Together.DeCreateRemoteUploadSpec request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a remote model upload<br/>
        /// Starts an asynchronous job that imports model files from Hugging Face or a presigned URL into a registered model and creates a model revision when the import completes.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeRemoteUpload>> VolumeServiceCreateRemoteModelUploadAsResponseAsync(
            string projectId,

            global::Together.DeCreateRemoteUploadSpec request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a remote model upload<br/>
        /// Starts an asynchronous job that imports model files from Hugging Face or a presigned URL into a registered model and creates a model revision when the import completes.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="modelId">
        /// ID of the registered model that will receive the imported files.
        /// </param>
        /// <param name="remoteUrl">
        /// Hugging Face repository URL or presigned archive URL to import.
        /// </param>
        /// <param name="token">
        /// Optional source credential used to access a private remote location. The value is write-only and is not returned.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeRemoteUpload> VolumeServiceCreateRemoteModelUploadAsync(
            string projectId,
            string modelId,
            string remoteUrl,
            string? token = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}