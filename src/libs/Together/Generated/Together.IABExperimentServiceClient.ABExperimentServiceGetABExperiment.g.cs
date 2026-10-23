#nullable enable

namespace Together
{
    public partial interface IABExperimentServiceClient
    {
        /// <summary>
        /// Get an A/B experiment<br/>
        /// Retrieves an A/B experiment and its participating deployments, roles, and traffic percentages.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="endpointId">
        /// Endpoint identifier.
        /// </param>
        /// <param name="id">
        /// A/B experiment identifier.
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
        /// experiment = client.endpoints.ab_experiments.retrieve(<br/>
        ///     "abx_abc123",<br/>
        ///     project_id=project_id,<br/>
        ///     endpoint_id="ep_abc123",<br/>
        /// )<br/>
        /// print(experiment.name, experiment.members)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.DeABExperiment> ABExperimentServiceGetABExperimentAsync(
            string projectId,
            string endpointId,
            string id,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get an A/B experiment<br/>
        /// Retrieves an A/B experiment and its participating deployments, roles, and traffic percentages.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="endpointId">
        /// Endpoint identifier.
        /// </param>
        /// <param name="id">
        /// A/B experiment identifier.
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
        /// experiment = client.endpoints.ab_experiments.retrieve(<br/>
        ///     "abx_abc123",<br/>
        ///     project_id=project_id,<br/>
        ///     endpoint_id="ep_abc123",<br/>
        /// )<br/>
        /// print(experiment.name, experiment.members)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeABExperiment>> ABExperimentServiceGetABExperimentAsResponseAsync(
            string projectId,
            string endpointId,
            string id,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}