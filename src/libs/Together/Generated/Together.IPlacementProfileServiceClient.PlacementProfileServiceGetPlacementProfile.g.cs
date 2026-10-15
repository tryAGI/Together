#nullable enable

namespace Together
{
    public partial interface IPlacementProfileServiceClient
    {
        /// <summary>
        /// Get a placement profile<br/>
        /// Retrieves a reusable placement profile and its ordered region preferences.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="id">
        /// Placement profile identifier.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// project_id = client.whoami().project_id<br/>
        /// profile = client.beta.endpoints.placement_profiles.retrieve(<br/>
        ///     "pp_abc123",<br/>
        ///     project_id=project_id,<br/>
        /// )<br/>
        /// print(profile.name)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.DePlacementProfile> PlacementProfileServiceGetPlacementProfileAsync(
            string projectId,
            string id,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a placement profile<br/>
        /// Retrieves a reusable placement profile and its ordered region preferences.
        /// </summary>
        /// <param name="projectId">
        /// Project identifier.
        /// </param>
        /// <param name="id">
        /// Placement profile identifier.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// project_id = client.whoami().project_id<br/>
        /// profile = client.beta.endpoints.placement_profiles.retrieve(<br/>
        ///     "pp_abc123",<br/>
        ///     project_id=project_id,<br/>
        /// )<br/>
        /// print(profile.name)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DePlacementProfile>> PlacementProfileServiceGetPlacementProfileAsResponseAsync(
            string projectId,
            string id,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}