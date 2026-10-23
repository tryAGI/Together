#nullable enable

namespace Together
{
    public partial interface IShadowExperimentServiceClient
    {
        /// <summary>
        /// Create a shadow experiment<br/>
        /// Creates an experiment that mirrors a sampled portion of endpoint traffic to one or more target deployments without returning their responses to clients. Add a description with the update operation after creation.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="endpointId">
        /// Endpoint identifier.
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
        /// # Mirror 10% of the endpoint's requests to the candidate deployment.<br/>
        /// experiment = client.endpoints.shadow_experiments.create(<br/>
        ///     "ep_abc123",<br/>
        ///     project_id=project_id,<br/>
        ///     name="candidate-shadow",<br/>
        ///     source={"endpoint": {"sampling": {"uniform": {"rate": 0.1}}}},<br/>
        ///     targets=[<br/>
        ///         {"name": "candidate", "target_deployment_id": "dep_def456"},<br/>
        ///     ],<br/>
        /// )<br/>
        /// print(experiment.id)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.DeShadowExperiment> ShadowExperimentServiceCreateShadowExperimentAsync(
            string projectId,
            string endpointId,

            global::Together.DeCreateShadowExperimentRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a shadow experiment<br/>
        /// Creates an experiment that mirrors a sampled portion of endpoint traffic to one or more target deployments without returning their responses to clients. Add a description with the update operation after creation.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="endpointId">
        /// Endpoint identifier.
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
        /// # Mirror 10% of the endpoint's requests to the candidate deployment.<br/>
        /// experiment = client.endpoints.shadow_experiments.create(<br/>
        ///     "ep_abc123",<br/>
        ///     project_id=project_id,<br/>
        ///     name="candidate-shadow",<br/>
        ///     source={"endpoint": {"sampling": {"uniform": {"rate": 0.1}}}},<br/>
        ///     targets=[<br/>
        ///         {"name": "candidate", "target_deployment_id": "dep_def456"},<br/>
        ///     ],<br/>
        /// )<br/>
        /// print(experiment.id)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeShadowExperiment>> ShadowExperimentServiceCreateShadowExperimentAsResponseAsync(
            string projectId,
            string endpointId,

            global::Together.DeCreateShadowExperimentRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a shadow experiment<br/>
        /// Creates an experiment that mirrors a sampled portion of endpoint traffic to one or more target deployments without returning their responses to clients. Add a description with the update operation after creation.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="endpointId">
        /// Endpoint identifier.
        /// </param>
        /// <param name="name">
        /// Human-readable shadow experiment name, unique within the endpoint. At most 256 characters.
        /// </param>
        /// <param name="source">
        /// Endpoint source and sampling configuration for the experiment.
        /// </param>
        /// <param name="targets">
        /// Optional initial target deployments. At most 100 targets; manage later changes through the target APIs.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeShadowExperiment> ShadowExperimentServiceCreateShadowExperimentAsync(
            string projectId,
            string endpointId,
            string name,
            global::Together.DeShadowExperimentSource source,
            global::System.Collections.Generic.IList<global::Together.DeCreateShadowExperimentTargetRequest>? targets = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}