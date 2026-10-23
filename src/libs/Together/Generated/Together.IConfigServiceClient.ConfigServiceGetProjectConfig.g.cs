#nullable enable

namespace Together
{
    public partial interface IConfigServiceClient
    {
        /// <summary>
        /// Get a model configuration<br/>
        /// Retrieves a model configuration revision by ID, including its runtime selectors and certifications.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="id">
        /// Config revision identifier.
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
        /// config = client.models.configs.retrieve(<br/>
        ///     "cr_abc123",<br/>
        ///     project_id=project_id,<br/>
        /// )<br/>
        /// print(config.id, config.reference_model)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.DeModelConfig> ConfigServiceGetProjectConfigAsync(
            string projectId,
            string id,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a model configuration<br/>
        /// Retrieves a model configuration revision by ID, including its runtime selectors and certifications.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="id">
        /// Config revision identifier.
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
        /// config = client.models.configs.retrieve(<br/>
        ///     "cr_abc123",<br/>
        ///     project_id=project_id,<br/>
        /// )<br/>
        /// print(config.id, config.reference_model)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeModelConfig>> ConfigServiceGetProjectConfigAsResponseAsync(
            string projectId,
            string id,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}