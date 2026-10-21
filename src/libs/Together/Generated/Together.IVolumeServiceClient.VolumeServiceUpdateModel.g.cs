#nullable enable

namespace Together
{
    public partial interface IVolumeServiceClient
    {
        /// <summary>
        /// Update a model<br/>
        /// Updates mutable model metadata such as its inference name, description, base model, or visibility.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="id">
        /// Model identifier.
        /// </param>
        /// <param name="updateMask">
        /// Fields to update. If omitted, all mutable fields are overwritten.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeModel> VolumeServiceUpdateModelAsync(
            string projectId,
            string id,

            global::Together.DeUpdateModelRequest request,
            string? updateMask = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a model<br/>
        /// Updates mutable model metadata such as its inference name, description, base model, or visibility.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="id">
        /// Model identifier.
        /// </param>
        /// <param name="updateMask">
        /// Fields to update. If omitted, all mutable fields are overwritten.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeModel>> VolumeServiceUpdateModelAsResponseAsync(
            string projectId,
            string id,

            global::Together.DeUpdateModelRequest request,
            string? updateMask = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a model<br/>
        /// Updates mutable model metadata such as its inference name, description, base model, or visibility.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="id">
        /// Model identifier.
        /// </param>
        /// <param name="updateMask">
        /// Fields to update. If omitted, all mutable fields are overwritten.
        /// </param>
        /// <param name="name">
        /// Updated inference-addressable model name.
        /// </param>
        /// <param name="description">
        /// Updated user-facing model description.
        /// </param>
        /// <param name="visibility">
        /// Who can discover the model. `VISIBILITY_PRIVATE` restricts it to the project; `VISIBILITY_INTERNAL` shares it with the organization.<br/>
        /// Default Value: VISIBILITY_PRIVATE
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeModel> VolumeServiceUpdateModelAsync(
            string projectId,
            string id,
            string? updateMask = default,
            string? name = default,
            string? description = default,
            global::Together.DeUpdateModelRequestVisibility? visibility = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}