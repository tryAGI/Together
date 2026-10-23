#nullable enable

namespace Together
{
    public partial interface IInstanceTypeServiceClient
    {
        /// <summary>
        /// List inference instance types<br/>
        /// Lists hardware instance types currently available to inference deployments, including GPU resources, pricing, regions, and best-effort capacity headroom.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// instance_types = client.endpoints.hardware.list()<br/>
        /// for instance_type in instance_types.data:<br/>
        ///     print(instance_type.name, instance_type.price_cents_per_hour)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.DeListInferenceInstanceTypesResponse> InstanceTypeServiceListInferenceInstanceTypesAsync(
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List inference instance types<br/>
        /// Lists hardware instance types currently available to inference deployments, including GPU resources, pricing, regions, and best-effort capacity headroom.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// instance_types = client.endpoints.hardware.list()<br/>
        /// for instance_type in instance_types.data:<br/>
        ///     print(instance_type.name, instance_type.price_cents_per_hour)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeListInferenceInstanceTypesResponse>> InstanceTypeServiceListInferenceInstanceTypesAsResponseAsync(
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}