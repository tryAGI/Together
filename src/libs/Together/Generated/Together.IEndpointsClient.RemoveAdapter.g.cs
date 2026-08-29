#nullable enable

namespace Together
{
    public partial interface IEndpointsClient
    {
        /// <summary>
        /// Remove a LoRA adapter from an endpoint<br/>
        /// Removes the routing rule that binds an adapter to an endpoint.<br/>
        /// The adapter must be currently bound to this specific endpoint.
        /// </summary>
        /// <param name="endpointId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// import os<br/>
        /// client = Together(<br/>
        ///     api_key=os.environ.get("TOGETHER_API_KEY"),<br/>
        /// )<br/>
        /// client.endpoints.adapters.remove(<br/>
        ///     "endpoint-abc123",<br/>
        ///     model_id="username/my-endpoint-name:username/my-adapter-model",<br/>
        /// )
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.RemoveAdapterResponse> RemoveAdapterAsync(
            string endpointId,

            global::Together.RemoveAdapterRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove a LoRA adapter from an endpoint<br/>
        /// Removes the routing rule that binds an adapter to an endpoint.<br/>
        /// The adapter must be currently bound to this specific endpoint.
        /// </summary>
        /// <param name="endpointId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// import os<br/>
        /// client = Together(<br/>
        ///     api_key=os.environ.get("TOGETHER_API_KEY"),<br/>
        /// )<br/>
        /// client.endpoints.adapters.remove(<br/>
        ///     "endpoint-abc123",<br/>
        ///     model_id="username/my-endpoint-name:username/my-adapter-model",<br/>
        /// )
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.RemoveAdapterResponse>> RemoveAdapterAsResponseAsync(
            string endpointId,

            global::Together.RemoveAdapterRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove a LoRA adapter from an endpoint<br/>
        /// Removes the routing rule that binds an adapter to an endpoint.<br/>
        /// The adapter must be currently bound to this specific endpoint.
        /// </summary>
        /// <param name="endpointId"></param>
        /// <param name="modelId">
        /// Combined identifier in format "endpoint_name:adapter_model_name".
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RemoveAdapterResponse> RemoveAdapterAsync(
            string endpointId,
            string modelId,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}