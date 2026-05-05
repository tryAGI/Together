#nullable enable

namespace Together
{
    public partial interface IEndpointsClient
    {
        /// <summary>
        /// List all endpoints, can be filtered by type<br/>
        /// Returns a list of all endpoints associated with your account. You can filter the results by type (dedicated or serverless).
        /// </summary>
        /// <param name="type">
        /// Filter endpoints by type
        /// </param>
        /// <param name="usageType">
        /// Filter endpoints by usage type
        /// </param>
        /// <param name="mine">
        /// If true, return only endpoints owned by the caller
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// # Docs for v1 can be found by changing the above selector ^<br/>
        /// from together import Together<br/>
        /// import os<br/>
        /// client = Together(<br/>
        ///     api_key=os.environ.get("TOGETHER_API_KEY"),<br/>
        /// )<br/>
        /// response = client.endpoints.list()<br/>
        /// for endpoint in response.data:<br/>
        ///     print(endpoint.id)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.ListEndpointsResponse> ListEndpointsAsync(
            global::Together.ListEndpointsType? type = default,
            global::Together.ListEndpointsUsageType? usageType = default,
            bool? mine = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}