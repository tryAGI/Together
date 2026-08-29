#nullable enable

namespace Together
{
    public partial interface IEndpointsClient
    {
        /// <summary>
        /// Add a LoRA adapter to an endpoint<br/>
        /// Adds a LoRA adapter model to a dedicated endpoint. After this call,<br/>
        /// inference requests to the adapter model name will be routed to the<br/>
        /// specified endpoint. The endpoint must have LoRA enabled, and the<br/>
        /// adapter's base model must be compatible with the endpoint's model.<br/>
        /// The endpoint name prefix in model_id must match the resolved endpoint.
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
        /// result = client.endpoints.adapters.add(<br/>
        ///     "endpoint-abc123",<br/>
        ///     model_id="username/my-endpoint-name:username/my-adapter-model",<br/>
        /// )<br/>
        /// print(result.api_model_id)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AddAdapterResponse> AddAdapterAsync(
            string endpointId,

            global::Together.AddAdapterRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a LoRA adapter to an endpoint<br/>
        /// Adds a LoRA adapter model to a dedicated endpoint. After this call,<br/>
        /// inference requests to the adapter model name will be routed to the<br/>
        /// specified endpoint. The endpoint must have LoRA enabled, and the<br/>
        /// adapter's base model must be compatible with the endpoint's model.<br/>
        /// The endpoint name prefix in model_id must match the resolved endpoint.
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
        /// result = client.endpoints.adapters.add(<br/>
        ///     "endpoint-abc123",<br/>
        ///     model_id="username/my-endpoint-name:username/my-adapter-model",<br/>
        /// )<br/>
        /// print(result.api_model_id)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.AddAdapterResponse>> AddAdapterAsResponseAsync(
            string endpointId,

            global::Together.AddAdapterRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a LoRA adapter to an endpoint<br/>
        /// Adds a LoRA adapter model to a dedicated endpoint. After this call,<br/>
        /// inference requests to the adapter model name will be routed to the<br/>
        /// specified endpoint. The endpoint must have LoRA enabled, and the<br/>
        /// adapter's base model must be compatible with the endpoint's model.<br/>
        /// The endpoint name prefix in model_id must match the resolved endpoint.
        /// </summary>
        /// <param name="endpointId"></param>
        /// <param name="modelId">
        /// Combined identifier in format "endpoint_name:adapter_model_name".<br/>
        /// Example: username/Meta-Llama-3.1-8B-Instruct-def456:username/my-adapter-abc123
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AddAdapterResponse> AddAdapterAsync(
            string endpointId,
            string modelId,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}