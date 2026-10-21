#nullable enable

namespace Together
{
    public partial interface IABExperimentServiceClient
    {
        /// <summary>
        /// Delete an A/B experiment<br/>
        /// Deletes an A/B experiment and removes its managed traffic split. The deployments themselves are not deleted.
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
        /// <param name="etag">
        /// Etag for optimistic concurrency. If set, the delete is rejected if the current etag does not match.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// project_id = client.whoami().project_id<br/>
        /// client.beta.endpoints.ab_experiments.delete(<br/>
        ///     "abx_abc123",<br/>
        ///     project_id=project_id,<br/>
        ///     endpoint_id="ep_abc123",<br/>
        /// )
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.DeDeleteResponse> ABExperimentServiceDeleteABExperimentAsync(
            string projectId,
            string endpointId,
            string id,
            string? etag = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an A/B experiment<br/>
        /// Deletes an A/B experiment and removes its managed traffic split. The deployments themselves are not deleted.
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
        /// <param name="etag">
        /// Etag for optimistic concurrency. If set, the delete is rejected if the current etag does not match.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// project_id = client.whoami().project_id<br/>
        /// client.beta.endpoints.ab_experiments.delete(<br/>
        ///     "abx_abc123",<br/>
        ///     project_id=project_id,<br/>
        ///     endpoint_id="ep_abc123",<br/>
        /// )
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeDeleteResponse>> ABExperimentServiceDeleteABExperimentAsResponseAsync(
            string projectId,
            string endpointId,
            string id,
            string? etag = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}