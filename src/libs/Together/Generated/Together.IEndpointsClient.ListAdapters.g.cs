#nullable enable

namespace Together
{
    public partial interface IEndpointsClient
    {
        /// <summary>
        /// List adapters on an endpoint<br/>
        /// Returns all LoRA adapters bound to the specified dedicated endpoint.
        /// </summary>
        /// <param name="endpointId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// import os<br/>
        /// client = Together(<br/>
        ///     api_key=os.environ.get("TOGETHER_API_KEY"),<br/>
        /// )<br/>
        /// adapters = client.endpoints.adapters.list("endpoint-abc123")<br/>
        /// for adapter in adapters.data or []:<br/>
        ///     print(adapter.api_model_id, adapter.adapter_name, adapter.endpoint_name)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.ListAdaptersResponse> ListAdaptersAsync(
            string endpointId,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List adapters on an endpoint<br/>
        /// Returns all LoRA adapters bound to the specified dedicated endpoint.
        /// </summary>
        /// <param name="endpointId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// import os<br/>
        /// client = Together(<br/>
        ///     api_key=os.environ.get("TOGETHER_API_KEY"),<br/>
        /// )<br/>
        /// adapters = client.endpoints.adapters.list("endpoint-abc123")<br/>
        /// for adapter in adapters.data or []:<br/>
        ///     print(adapter.api_model_id, adapter.adapter_name, adapter.endpoint_name)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.ListAdaptersResponse>> ListAdaptersAsResponseAsync(
            string endpointId,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}