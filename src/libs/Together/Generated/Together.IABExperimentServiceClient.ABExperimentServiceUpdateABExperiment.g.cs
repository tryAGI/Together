#nullable enable

namespace Together
{
    public partial interface IABExperimentServiceClient
    {
        /// <summary>
        /// Update an A/B experiment<br/>
        /// Updates an experiment's description or member traffic percentages. Use the experiment etag for optimistic concurrency.
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
        /// <param name="updateMask">
        /// Fields to update. If omitted, all mutable fields are overwritten.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeABExperiment> ABExperimentServiceUpdateABExperimentAsync(
            string projectId,
            string endpointId,
            string id,

            global::Together.DeUpdateABExperimentRequest request,
            string? updateMask = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an A/B experiment<br/>
        /// Updates an experiment's description or member traffic percentages. Use the experiment etag for optimistic concurrency.
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
        /// <param name="updateMask">
        /// Fields to update. If omitted, all mutable fields are overwritten.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeABExperiment>> ABExperimentServiceUpdateABExperimentAsResponseAsync(
            string projectId,
            string endpointId,
            string id,

            global::Together.DeUpdateABExperimentRequest request,
            string? updateMask = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an A/B experiment<br/>
        /// Updates an experiment's description or member traffic percentages. Use the experiment etag for optimistic concurrency.
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
        /// <param name="updateMask">
        /// Fields to update. If omitted, all mutable fields are overwritten.
        /// </param>
        /// <param name="description">
        /// Updated free-form description.
        /// </param>
        /// <param name="members">
        /// Complete replacement member set. Requires two to 20 deployments, exactly one control, and percentages that add up to 100.
        /// </param>
        /// <param name="etag">
        /// Opaque version tag from a prior read for optimistic concurrency.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeABExperiment> ABExperimentServiceUpdateABExperimentAsync(
            string projectId,
            string endpointId,
            string id,
            string? updateMask = default,
            string? description = default,
            global::System.Collections.Generic.IList<global::Together.DeABExperimentMember>? members = default,
            string? etag = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}