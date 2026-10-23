#nullable enable

namespace Together
{
    public partial interface IVolumeServiceClient
    {
        /// <summary>
        /// List organization models<br/>
        /// Lists custom models shared with every project in the specified organization. Project-private and public models are not included.
        /// </summary>
        /// <param name="organizationId">
        /// Organization identifier.
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
        /// identity = client.whoami()<br/>
        /// if identity.type == "user_jwt":<br/>
        ///     raise RuntimeError("Use a credential scoped to an organization")<br/>
        /// organization_id = identity.organization.id<br/>
        /// for model in client.models.list_org_scoped(organization_id):<br/>
        ///     print(model.id, model.name)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.DeListModelsResponse> VolumeServiceListOrganizationModelsAsync(
            string organizationId,
            int? limit = default,
            string? after = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List organization models<br/>
        /// Lists custom models shared with every project in the specified organization. Project-private and public models are not included.
        /// </summary>
        /// <param name="organizationId">
        /// Organization identifier.
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
        /// identity = client.whoami()<br/>
        /// if identity.type == "user_jwt":<br/>
        ///     raise RuntimeError("Use a credential scoped to an organization")<br/>
        /// organization_id = identity.organization.id<br/>
        /// for model in client.models.list_org_scoped(organization_id):<br/>
        ///     print(model.id, model.name)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeListModelsResponse>> VolumeServiceListOrganizationModelsAsResponseAsync(
            string organizationId,
            int? limit = default,
            string? after = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}