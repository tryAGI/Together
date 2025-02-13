#nullable enable

namespace Together
{
    public partial interface IEndpointsClient
    {
        /// <summary>
        /// List all endpoints, can be filtered by type<br/>
        /// Returns a list of all endpoints associated with your account. You can filter the results by type (dedicated or serverless).
        /// </summary>
        /// <param name="type"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.ListEndpointsResponse> ListEndpointsAsync(
            global::Together.ListEndpointsType? type = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}