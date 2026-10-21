#nullable enable

namespace Together
{
    public partial interface IRolloutServiceClient
    {
        /// <summary>
        /// Resume a rollout<br/>
        /// Resumes a pausing, paused, or system-paused rollout from its current step and traffic split.
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
        /// project_id = client.whoami().project_id<br/>
        /// rollout = client.beta.endpoints.rollouts.resume(<br/>
        ///     "rol_abc123",<br/>
        ///     project_id=project_id,<br/>
        ///     endpoint_id="ep_abc123",<br/>
        /// )<br/>
        /// print(rollout.id, rollout.state)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.DeRollout> RolloutServiceResumeRolloutAsync(
            string projectId,
            string endpointId,
            string id,

            global::Together.DeResumeRolloutRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resume a rollout<br/>
        /// Resumes a pausing, paused, or system-paused rollout from its current step and traffic split.
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
        /// project_id = client.whoami().project_id<br/>
        /// rollout = client.beta.endpoints.rollouts.resume(<br/>
        ///     "rol_abc123",<br/>
        ///     project_id=project_id,<br/>
        ///     endpoint_id="ep_abc123",<br/>
        /// )<br/>
        /// print(rollout.id, rollout.state)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeRollout>> RolloutServiceResumeRolloutAsResponseAsync(
            string projectId,
            string endpointId,
            string id,

            global::Together.DeResumeRolloutRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resume a rollout<br/>
        /// Resumes a pausing, paused, or system-paused rollout from its current step and traffic split.
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
        global::System.Threading.Tasks.Task<global::Together.DeRollout> RolloutServiceResumeRolloutAsync(
            string projectId,
            string endpointId,
            string id,
            string? etag = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}