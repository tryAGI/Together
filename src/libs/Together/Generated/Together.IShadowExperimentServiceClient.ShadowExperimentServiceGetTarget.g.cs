#nullable enable

namespace Together
{
    public partial interface IShadowExperimentServiceClient
    {
        /// <summary>
        /// Get a shadow experiment target<br/>
        /// Retrieves one target configured to receive mirrored requests from a shadow experiment.
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
        /// target = client.endpoints.shadow_experiments.targets.retrieve(<br/>
        ///     "tgt_abc123",<br/>
        ///     project_id=project_id,<br/>
        ///     endpoint_id="ep_abc123",<br/>
        ///     experiment_id="exp_abc123",<br/>
        /// )<br/>
        /// print(target.name, target.target_deployment_id)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.DeShadowExperimentTarget> ShadowExperimentServiceGetTargetAsync(
            string projectId,
            string endpointId,
            string experimentId,
            string id,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a shadow experiment target<br/>
        /// Retrieves one target configured to receive mirrored requests from a shadow experiment.
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
        /// target = client.endpoints.shadow_experiments.targets.retrieve(<br/>
        ///     "tgt_abc123",<br/>
        ///     project_id=project_id,<br/>
        ///     endpoint_id="ep_abc123",<br/>
        ///     experiment_id="exp_abc123",<br/>
        /// )<br/>
        /// print(target.name, target.target_deployment_id)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeShadowExperimentTarget>> ShadowExperimentServiceGetTargetAsResponseAsync(
            string projectId,
            string endpointId,
            string experimentId,
            string id,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}