#nullable enable

namespace Together
{
    public partial interface IEndpointsClient
    {
        /// <summary>
        /// Update endpoint, this can also be used to start or stop a dedicated endpoint<br/>
        /// Updates an existing endpoint's configuration. You can modify the display name, autoscaling settings, or change the endpoint's state (start/stop).
        /// </summary>
        /// <param name="endpointId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DedicatedEndpoint> UpdateEndpointAsync(
            string endpointId,
            global::Together.UpdateEndpointRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update endpoint, this can also be used to start or stop a dedicated endpoint<br/>
        /// Updates an existing endpoint's configuration. You can modify the display name, autoscaling settings, or change the endpoint's state (start/stop).
        /// </summary>
        /// <param name="endpointId"></param>
        /// <param name="autoscaling">
        /// Configuration for automatic scaling of replicas based on demand.
        /// </param>
        /// <param name="displayName">
        /// A human-readable name for the endpoint<br/>
        /// Example: My Llama3 70b endpoint
        /// </param>
        /// <param name="state">
        /// The desired state of the endpoint<br/>
        /// Example: STARTED
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DedicatedEndpoint> UpdateEndpointAsync(
            string endpointId,
            global::Together.Autoscaling? autoscaling = default,
            string? displayName = default,
            global::Together.UpdateEndpointRequestState? state = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}