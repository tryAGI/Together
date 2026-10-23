#nullable enable

namespace Together
{
    public partial interface IRolloutServiceClient
    {
        /// <summary>
        /// Promote a rollout<br/>
        /// Completes a running or paused rollout immediately by sending all live traffic to the target deployment.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="endpointId">
        /// Endpoint identifier.
        /// </param>
        /// <param name="id">
        /// Rollout identifier.
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
        /// rollout = client.endpoints.rollouts.promote(<br/>
        ///     "rol_abc123",<br/>
        ///     project_id=project_id,<br/>
        ///     endpoint_id="ep_abc123",<br/>
        /// )<br/>
        /// print(rollout.id, rollout.state)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.DeRollout> RolloutServicePromoteRolloutAsync(
            string projectId,
            string endpointId,
            string id,

            global::Together.DePromoteRolloutRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Promote a rollout<br/>
        /// Completes a running or paused rollout immediately by sending all live traffic to the target deployment.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="endpointId">
        /// Endpoint identifier.
        /// </param>
        /// <param name="id">
        /// Rollout identifier.
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
        /// rollout = client.endpoints.rollouts.promote(<br/>
        ///     "rol_abc123",<br/>
        ///     project_id=project_id,<br/>
        ///     endpoint_id="ep_abc123",<br/>
        /// )<br/>
        /// print(rollout.id, rollout.state)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeRollout>> RolloutServicePromoteRolloutAsResponseAsync(
            string projectId,
            string endpointId,
            string id,

            global::Together.DePromoteRolloutRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Promote a rollout<br/>
        /// Completes a running or paused rollout immediately by sending all live traffic to the target deployment.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="endpointId">
        /// Endpoint identifier.
        /// </param>
        /// <param name="id">
        /// Rollout identifier.
        /// </param>
        /// <param name="etag">
        /// Optional etag for optimistic concurrency.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeRollout> RolloutServicePromoteRolloutAsync(
            string projectId,
            string endpointId,
            string id,
            string? etag = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}