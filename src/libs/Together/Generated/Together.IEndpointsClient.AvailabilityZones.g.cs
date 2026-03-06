#nullable enable

namespace Together
{
    public partial interface IEndpointsClient
    {
        /// <summary>
        /// List all available availability zones.<br/>
        /// List all available availability zones.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.ListAvailibilityZonesResponse> AvailabilityZonesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}