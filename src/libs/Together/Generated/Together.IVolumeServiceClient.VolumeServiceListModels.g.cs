#nullable enable

namespace Together
{
    public partial interface IVolumeServiceClient
    {
        /// <summary>
        /// List project models<br/>
        /// Lists custom model resources owned by the specified project. Use the organization endpoint to list models shared across projects or the supported-model catalog to discover Together-hosted base models.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="visibility">
        /// Model visibility. Private means it is scoped to the project. Internal means it is scoped to the organization.
        /// </param>
        /// <param name="organizationId">
        /// Organization whose shared models should be included. Defaults to the authenticated project's organization.
        /// </param>
        /// <param name="limit">
        /// Maximum number of models to return.
        /// </param>
        /// <param name="after">
        /// Cursor from a previous model list response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeListModelsResponse> VolumeServiceListModelsAsync(
            string projectId,
            global::Together.VolumeServiceListModelsVisibility? visibility = default,
            string? organizationId = default,
            int? limit = default,
            string? after = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List project models<br/>
        /// Lists custom model resources owned by the specified project. Use the organization endpoint to list models shared across projects or the supported-model catalog to discover Together-hosted base models.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="visibility">
        /// Model visibility. Private means it is scoped to the project. Internal means it is scoped to the organization.
        /// </param>
        /// <param name="organizationId">
        /// Organization whose shared models should be included. Defaults to the authenticated project's organization.
        /// </param>
        /// <param name="limit">
        /// Maximum number of models to return.
        /// </param>
        /// <param name="after">
        /// Cursor from a previous model list response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeListModelsResponse>> VolumeServiceListModelsAsResponseAsync(
            string projectId,
            global::Together.VolumeServiceListModelsVisibility? visibility = default,
            string? organizationId = default,
            int? limit = default,
            string? after = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}