#nullable enable

namespace Together
{
    public partial interface IEndpointsClient
    {
        /// <summary>
        /// Get endpoint by ID<br/>
        /// Retrieves details about a specific endpoint, including its current state, configuration, and scaling settings.
        /// </summary>
        /// <param name="endpointId">
        /// The ID of the endpoint to retrieve<br/>
        /// Example: endpoint-d23901de-ef8f-44bf-b3e7-de9c1ca8f2d7
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DedicatedEndpoint> GetEndpointAsync(
            string endpointId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}