#nullable enable

namespace Together
{
    public partial interface IEndpointsClient
    {
        /// <summary>
        /// Get endpoint by ID<br/>
        /// Retrieves details about a specific endpoint, including its current state, configuration, and scaling settings.
        /// </summary>
        /// <param name="endpointId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DedicatedEndpoint> GetEndpointAsync(
            string endpointId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}