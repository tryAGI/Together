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
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// identity = client.whoami()<br/>
        /// if identity.type != "project_api_key":<br/>
        ///     raise RuntimeError("TOGETHER_API_KEY must be a project API key")<br/>
        /// project_id = identity.project.id<br/>
        /// job = client.models.remote_uploads.create(<br/>
        ///     project_id=project_id,<br/>
        ///     model_id="ml_abc123",<br/>
        ///     remote_url="https://huggingface.co/your-org/your-adapter",<br/>
        /// )<br/>
        /// print(job)
        /// </remarks>
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
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// identity = client.whoami()<br/>
        /// if identity.type != "project_api_key":<br/>
        ///     raise RuntimeError("TOGETHER_API_KEY must be a project API key")<br/>
        /// project_id = identity.project.id<br/>
        /// job = client.models.remote_uploads.create(<br/>
        ///     project_id=project_id,<br/>
        ///     model_id="ml_abc123",<br/>
        ///     remote_url="https://huggingface.co/your-org/your-adapter",<br/>
        /// )<br/>
        /// print(job)
        /// </remarks>
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