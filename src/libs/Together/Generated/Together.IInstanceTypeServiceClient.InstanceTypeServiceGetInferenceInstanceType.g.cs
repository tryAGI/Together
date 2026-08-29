#nullable enable

namespace Together
{
    public partial interface IInstanceTypeServiceClient
    {
        /// <summary>
        /// Get an inference instance type<br/>
        /// Retrieves the GPU resources, pricing, regional availability, and best-effort capacity headroom for one inference instance type.
        /// </summary>
        /// <param name="id">
        /// Resource identifier.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeInferenceInstanceType> InstanceTypeServiceGetInferenceInstanceTypeAsync(
            string id,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get an inference instance type<br/>
        /// Retrieves the GPU resources, pricing, regional availability, and best-effort capacity headroom for one inference instance type.
        /// </summary>
        /// <param name="id">
        /// Resource identifier.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeInferenceInstanceType>> InstanceTypeServiceGetInferenceInstanceTypeAsResponseAsync(
            string id,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}