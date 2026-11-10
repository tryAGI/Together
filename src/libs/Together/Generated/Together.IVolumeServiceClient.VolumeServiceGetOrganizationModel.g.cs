#nullable enable

namespace Together
{
    public partial interface IVolumeServiceClient
    {
        /// <summary>
        /// Get organization model<br/>
        /// Retrieves a custom model shared with every project in the specified organization, regardless of which project owns it. Returns not found if the model belongs to another organization or is not organization-scoped.
        /// </summary>
        /// <param name="organizationId">
        /// Organization identifier.
        /// </param>
        /// <param name="modelId">
        /// Model identifier.
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
        /// # The SDK has no dedicated method for this endpoint yet, so call it with<br/>
        /// # the client's generic GET helper.<br/>
        /// model = client.get(<br/>
        ///     f"/v2/organizations/{organization_id}/models/ml_abc123",<br/>
        ///     cast_to=object,<br/>
        /// )<br/>
        /// print(model)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.DeModel> VolumeServiceGetOrganizationModelAsync(
            string organizationId,
            string modelId,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get organization model<br/>
        /// Retrieves a custom model shared with every project in the specified organization, regardless of which project owns it. Returns not found if the model belongs to another organization or is not organization-scoped.
        /// </summary>
        /// <param name="organizationId">
        /// Organization identifier.
        /// </param>
        /// <param name="modelId">
        /// Model identifier.
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
        /// # The SDK has no dedicated method for this endpoint yet, so call it with<br/>
        /// # the client's generic GET helper.<br/>
        /// model = client.get(<br/>
        ///     f"/v2/organizations/{organization_id}/models/ml_abc123",<br/>
        ///     cast_to=object,<br/>
        /// )<br/>
        /// print(model)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeModel>> VolumeServiceGetOrganizationModelAsResponseAsync(
            string organizationId,
            string modelId,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}