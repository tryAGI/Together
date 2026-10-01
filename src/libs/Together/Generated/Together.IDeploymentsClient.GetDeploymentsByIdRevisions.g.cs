#nullable enable

namespace Together
{
    public partial interface IDeploymentsClient
    {
        /// <summary>
        /// List revision history events of a deployment<br/>
        /// Returns the revision history of the deployment, in descending order. Defaults to the most recent events.<br/>
        /// Only the 200 most recent events are retained per deployment; paginating past that returns an empty list.
        /// </summary>
        /// <param name="id">
        /// Deployment ID or name.
        /// </param>
        /// <param name="limit">
        /// Maximum number of events to return (default 10, max 100).
        /// </param>
        /// <param name="before">
        /// Return only events with event_number strictly less than this value for pagination.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RevisionEventListResponse> GetDeploymentsByIdRevisionsAsync(
            string id,
            int? limit = default,
            int? before = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List revision history events of a deployment<br/>
        /// Returns the revision history of the deployment, in descending order. Defaults to the most recent events.<br/>
        /// Only the 200 most recent events are retained per deployment; paginating past that returns an empty list.
        /// </summary>
        /// <param name="id">
        /// Deployment ID or name.
        /// </param>
        /// <param name="limit">
        /// Maximum number of events to return (default 10, max 100).
        /// </param>
        /// <param name="before">
        /// Return only events with event_number strictly less than this value for pagination.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.RevisionEventListResponse>> GetDeploymentsByIdRevisionsAsResponseAsync(
            string id,
            int? limit = default,
            int? before = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}