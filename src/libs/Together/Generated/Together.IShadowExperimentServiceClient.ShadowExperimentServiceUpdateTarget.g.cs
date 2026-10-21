#nullable enable

namespace Together
{
    public partial interface IShadowExperimentServiceClient
    {
        /// <summary>
        /// Update a shadow experiment target<br/>
        /// Updates a shadow target's name, deployment, or description. `updateMask` is required and must select at least one mutable field.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="endpointId">
        /// Endpoint identifier.
        /// </param>
        /// <param name="experimentId">
        /// Shadow experiment identifier.
        /// </param>
        /// <param name="id">
        /// Shadow experiment target identifier.
        /// </param>
        /// <param name="updateMask">
        /// Comma-separated fields to update. Supported fields are `name`, `targetDeploymentId`, and `description`.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeShadowExperimentTarget> ShadowExperimentServiceUpdateTargetAsync(
            string projectId,
            string endpointId,
            string experimentId,
            string id,
            string updateMask,

            global::Together.DeUpdateShadowExperimentTargetRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a shadow experiment target<br/>
        /// Updates a shadow target's name, deployment, or description. `updateMask` is required and must select at least one mutable field.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="endpointId">
        /// Endpoint identifier.
        /// </param>
        /// <param name="experimentId">
        /// Shadow experiment identifier.
        /// </param>
        /// <param name="id">
        /// Shadow experiment target identifier.
        /// </param>
        /// <param name="updateMask">
        /// Comma-separated fields to update. Supported fields are `name`, `targetDeploymentId`, and `description`.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeShadowExperimentTarget>> ShadowExperimentServiceUpdateTargetAsResponseAsync(
            string projectId,
            string endpointId,
            string experimentId,
            string id,
            string updateMask,

            global::Together.DeUpdateShadowExperimentTargetRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a shadow experiment target<br/>
        /// Updates a shadow target's name, deployment, or description. `updateMask` is required and must select at least one mutable field.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="endpointId">
        /// Endpoint identifier.
        /// </param>
        /// <param name="experimentId">
        /// Shadow experiment identifier.
        /// </param>
        /// <param name="id">
        /// Shadow experiment target identifier.
        /// </param>
        /// <param name="updateMask">
        /// Comma-separated fields to update. Supported fields are `name`, `targetDeploymentId`, and `description`.
        /// </param>
        /// <param name="name">
        /// Updated human-readable target name.
        /// </param>
        /// <param name="targetDeploymentId">
        /// Replacement deployment under the parent endpoint. It must not be a live traffic-split member or the source or target of an active rollout; traffic-split weight 0 warm-up targets are allowed.
        /// </param>
        /// <param name="description">
        /// Updated free-form target description.
        /// </param>
        /// <param name="etag">
        /// Opaque version tag from a prior read for optimistic concurrency.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeShadowExperimentTarget> ShadowExperimentServiceUpdateTargetAsync(
            string projectId,
            string endpointId,
            string experimentId,
            string id,
            string updateMask,
            string? name = default,
            string? targetDeploymentId = default,
            string? description = default,
            string? etag = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}