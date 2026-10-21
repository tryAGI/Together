#nullable enable

namespace Together
{
    public partial interface IVolumeServiceClient
    {
        /// <summary>
        /// Create a model<br/>
        /// Registers a custom model resource in the project. Registration creates the model's metadata; upload or import model files separately before deploying it.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeModel> VolumeServiceCreateModelAsync(
            string projectId,

            global::Together.DeCreateModelRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a model<br/>
        /// Registers a custom model resource in the project. Registration creates the model's metadata; upload or import model files separately before deploying it.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeModel>> VolumeServiceCreateModelAsResponseAsync(
            string projectId,

            global::Together.DeCreateModelRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a model<br/>
        /// Registers a custom model resource in the project. Registration creates the model's metadata; upload or import model files separately before deploying it.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="name">
        /// Name for the custom model. May be bare or qualified as `&lt;project_slug&gt;/&lt;model_name&gt;`; a supplied project slug must match the project in the request path.
        /// </param>
        /// <param name="type">
        /// Volume type to create. Use `model` or `adapter`; plural `models` and `adapters` are also accepted.
        /// </param>
        /// <param name="description">
        /// Human-readable description of the model and its intended use.
        /// </param>
        /// <param name="baseModelId">
        /// ID of the supported base model from which this model was derived.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeModel> VolumeServiceCreateModelAsync(
            string projectId,
            string name,
            string type,
            string baseModelId,
            string? description = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}