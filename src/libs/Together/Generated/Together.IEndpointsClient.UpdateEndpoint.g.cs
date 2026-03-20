#nullable enable

namespace Together
{
    public partial interface IEndpointsClient
    {
        /// <summary>
        /// Update endpoint, this can also be used to start or stop a dedicated endpoint<br/>
        /// Updates an existing endpoint's configuration. You can modify the display name, autoscaling settings, or change the endpoint's state (start/stop).
        /// </summary>
        /// <param name="endpointId">
        /// The ID of the endpoint to update<br/>
        /// Example: endpoint-d23901de-ef8f-44bf-b3e7-de9c1ca8f2d7
        /// </param>
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
        /// <param name="endpointId">
        /// The ID of the endpoint to update<br/>
        /// Example: endpoint-d23901de-ef8f-44bf-b3e7-de9c1ca8f2d7
        /// </param>
        /// <param name="displayName">
        /// A human-readable name for the endpoint<br/>
        /// Example: My Llama3 70b endpoint
        /// </param>
        /// <param name="state">
        /// The desired state of the endpoint<br/>
        /// Example: STARTED
        /// </param>
        /// <param name="autoscaling">
        /// New autoscaling configuration for the endpoint
        /// </param>
        /// <param name="inactiveTimeout">
        /// The number of minutes of inactivity after which the endpoint will be automatically stopped. Set to 0 to disable automatic timeout.<br/>
        /// Example: 60
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DedicatedEndpoint> UpdateEndpointAsync(
            string endpointId,
            string? displayName = default,
            global::Together.UpdateEndpointRequestState? state = default,
            global::Together.Autoscaling? autoscaling = default,
            int? inactiveTimeout = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}