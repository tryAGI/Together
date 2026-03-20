#nullable enable

namespace Together
{
    public partial interface IEndpointsClient
    {
        /// <summary>
        /// Delete endpoint<br/>
        /// Permanently deletes an endpoint. This action cannot be undone.
        /// </summary>
        /// <param name="endpointId">
        /// The ID of the endpoint to delete<br/>
        /// Example: endpoint-d23901de-ef8f-44bf-b3e7-de9c1ca8f2d7
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// # Docs for v1 can be found by changing the above selector ^<br/>
        /// from together import Together<br/>
        /// import os<br/>
        /// client = Together(<br/>
        ///     api_key=os.environ.get("TOGETHER_API_KEY"),<br/>
        /// )<br/>
        /// endpoint = client.endpoints.delete("endpoint-id")<br/>
        /// print(endpoint)
        /// </remarks>
        global::System.Threading.Tasks.Task DeleteEndpointAsync(
            string endpointId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}