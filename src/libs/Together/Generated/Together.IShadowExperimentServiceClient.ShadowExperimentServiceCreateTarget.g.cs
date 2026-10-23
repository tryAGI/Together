#nullable enable

namespace Together
{
    public partial interface IShadowExperimentServiceClient
    {
        /// <summary>
        /// Create a shadow experiment target<br/>
        /// Adds a deployment under the same endpoint as a target for mirrored requests.
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
        /// target = client.endpoints.shadow_experiments.targets.create(<br/>
        ///     project_id=project_id,<br/>
        ///     endpoint_id="ep_abc123",<br/>
        ///     experiment_id="exp_abc123",<br/>
        ///     name="candidate-2",<br/>
        ///     target_deployment_id="dep_ghi789",<br/>
        /// )<br/>
        /// print(target.id)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.DeShadowExperimentTarget> ShadowExperimentServiceCreateTargetAsync(
            string projectId,
            string endpointId,
            string experimentId,

            global::Together.DeCreateShadowExperimentTargetRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a shadow experiment target<br/>
        /// Adds a deployment under the same endpoint as a target for mirrored requests.
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
        /// target = client.endpoints.shadow_experiments.targets.create(<br/>
        ///     project_id=project_id,<br/>
        ///     endpoint_id="ep_abc123",<br/>
        ///     experiment_id="exp_abc123",<br/>
        ///     name="candidate-2",<br/>
        ///     target_deployment_id="dep_ghi789",<br/>
        /// )<br/>
        /// print(target.id)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeShadowExperimentTarget>> ShadowExperimentServiceCreateTargetAsResponseAsync(
            string projectId,
            string endpointId,
            string experimentId,

            global::Together.DeCreateShadowExperimentTargetRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a shadow experiment target<br/>
        /// Adds a deployment under the same endpoint as a target for mirrored requests.
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
        /// <param name="name">
        /// Human-readable target name, unique within the shadow experiment. At most 256 characters.
        /// </param>
        /// <param name="targetDeploymentId">
        /// Deployment under the parent endpoint that receives mirrored traffic. It must not be a live traffic-split member or the source or target of an active rollout; traffic-split weight 0 warm-up targets are allowed.
        /// </param>
        /// <param name="description">
        /// Optional free-form target description.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeShadowExperimentTarget> ShadowExperimentServiceCreateTargetAsync(
            string projectId,
            string endpointId,
            string experimentId,
            string name,
            string targetDeploymentId,
            string? description = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}