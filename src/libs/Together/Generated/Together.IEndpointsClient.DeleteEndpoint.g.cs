#nullable enable

namespace Together
{
    public partial interface IEndpointsClient
    {
        /// <summary>
        /// Delete endpoint<br/>
        /// Permanently deletes an endpoint. This action cannot be undone.
        /// </summary>
        /// <param name="endpointId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteEndpointAsync(
            string endpointId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}