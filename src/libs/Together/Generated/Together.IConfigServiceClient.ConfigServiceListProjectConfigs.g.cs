#nullable enable

namespace Together
{
    public partial interface IConfigServiceClient
    {
        /// <summary>
        /// List model configurations<br/>
        /// Lists production-ready configuration revisions compatible with a reference model. Specify the model with `referenceModel` or the deprecated `referenceModelId`; if both are supplied, they must identify the same model. Results include public configurations and configurations owned by the specified project.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="referenceModelId">
        /// Deprecated. Use `referenceModel`. Reference model identifier filter; if both are set, they must agree.
        /// </param>
        /// <param name="referenceModel">
        /// Model resource-name filter using `projects/{projectId}/models/{modelId}`; alternative to `referenceModelId`. If both are set, they must agree.
        /// </param>
        /// <param name="limit">
        /// Maximum number of results to return.
        /// </param>
        /// <param name="after">
        /// Cursor from a previous list response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// project_id = client.whoami().project_id<br/>
        /// # Configurations are listed per model. A supported model's base_model is<br/>
        /// # the resource name to pass as reference_model.<br/>
        /// model = client.beta.models.retrieve_supported("arch_abc123")<br/>
        /// configs = client.beta.models.configs.list(<br/>
        ///     project_id=project_id,<br/>
        ///     reference_model=model.base_model,<br/>
        /// )<br/>
        /// for config in configs:<br/>
        ///     print(config.id, config.reference_model)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.DeListProjectConfigsResponse> ConfigServiceListProjectConfigsAsync(
            string projectId,
            string? referenceModelId = default,
            string? referenceModel = default,
            int? limit = default,
            string? after = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List model configurations<br/>
        /// Lists production-ready configuration revisions compatible with a reference model. Specify the model with `referenceModel` or the deprecated `referenceModelId`; if both are supplied, they must identify the same model. Results include public configurations and configurations owned by the specified project.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="referenceModelId">
        /// Deprecated. Use `referenceModel`. Reference model identifier filter; if both are set, they must agree.
        /// </param>
        /// <param name="referenceModel">
        /// Model resource-name filter using `projects/{projectId}/models/{modelId}`; alternative to `referenceModelId`. If both are set, they must agree.
        /// </param>
        /// <param name="limit">
        /// Maximum number of results to return.
        /// </param>
        /// <param name="after">
        /// Cursor from a previous list response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// project_id = client.whoami().project_id<br/>
        /// # Configurations are listed per model. A supported model's base_model is<br/>
        /// # the resource name to pass as reference_model.<br/>
        /// model = client.beta.models.retrieve_supported("arch_abc123")<br/>
        /// configs = client.beta.models.configs.list(<br/>
        ///     project_id=project_id,<br/>
        ///     reference_model=model.base_model,<br/>
        /// )<br/>
        /// for config in configs:<br/>
        ///     print(config.id, config.reference_model)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeListProjectConfigsResponse>> ConfigServiceListProjectConfigsAsResponseAsync(
            string projectId,
            string? referenceModelId = default,
            string? referenceModel = default,
            int? limit = default,
            string? after = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}