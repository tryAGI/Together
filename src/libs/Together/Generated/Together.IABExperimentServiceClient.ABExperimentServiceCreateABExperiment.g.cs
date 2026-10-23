#nullable enable

namespace Together
{
    public partial interface IABExperimentServiceClient
    {
        /// <summary>
        /// Create an A/B experiment<br/>
        /// Creates a managed control/variant split across two to 20 deployments under the same endpoint. Exactly one member is the control, member percentages must add up to 100, and the split applies only to traffic that the endpoint would otherwise send to the control.
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
        /// experiment = client.endpoints.ab_experiments.create(<br/>
        ///     "ep_abc123",<br/>
        ///     project_id=project_id,<br/>
        ///     name="new-config-test",<br/>
        ///     members=[<br/>
        ///         {<br/>
        ///             "deployment_id": "dep_abc123",<br/>
        ///             "role": "AB_EXPERIMENT_MEMBER_ROLE_CONTROL",<br/>
        ///             "percent": 90,<br/>
        ///         },<br/>
        ///         {<br/>
        ///             "deployment_id": "dep_def456",<br/>
        ///             "role": "AB_EXPERIMENT_MEMBER_ROLE_VARIANT",<br/>
        ///             "percent": 10,<br/>
        ///         },<br/>
        ///     ],<br/>
        /// )<br/>
        /// print(experiment.id)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.DeABExperiment> ABExperimentServiceCreateABExperimentAsync(
            string projectId,
            string endpointId,

            global::Together.DeCreateABExperimentRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an A/B experiment<br/>
        /// Creates a managed control/variant split across two to 20 deployments under the same endpoint. Exactly one member is the control, member percentages must add up to 100, and the split applies only to traffic that the endpoint would otherwise send to the control.
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
        /// experiment = client.endpoints.ab_experiments.create(<br/>
        ///     "ep_abc123",<br/>
        ///     project_id=project_id,<br/>
        ///     name="new-config-test",<br/>
        ///     members=[<br/>
        ///         {<br/>
        ///             "deployment_id": "dep_abc123",<br/>
        ///             "role": "AB_EXPERIMENT_MEMBER_ROLE_CONTROL",<br/>
        ///             "percent": 90,<br/>
        ///         },<br/>
        ///         {<br/>
        ///             "deployment_id": "dep_def456",<br/>
        ///             "role": "AB_EXPERIMENT_MEMBER_ROLE_VARIANT",<br/>
        ///             "percent": 10,<br/>
        ///         },<br/>
        ///     ],<br/>
        /// )<br/>
        /// print(experiment.id)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeABExperiment>> ABExperimentServiceCreateABExperimentAsResponseAsync(
            string projectId,
            string endpointId,

            global::Together.DeCreateABExperimentRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an A/B experiment<br/>
        /// Creates a managed control/variant split across two to 20 deployments under the same endpoint. Exactly one member is the control, member percentages must add up to 100, and the split applies only to traffic that the endpoint would otherwise send to the control.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="endpointId">
        /// Endpoint identifier.
        /// </param>
        /// <param name="name">
        /// Human-readable A/B experiment name, unique within the endpoint.
        /// </param>
        /// <param name="description">
        /// Optional free-form description.
        /// </param>
        /// <param name="members">
        /// Two to 20 participating deployments with exactly one control. Integer traffic percentages across all members must add up to 100.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeABExperiment> ABExperimentServiceCreateABExperimentAsync(
            string projectId,
            string endpointId,
            string name,
            global::System.Collections.Generic.IList<global::Together.DeABExperimentMember> members,
            string? description = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}