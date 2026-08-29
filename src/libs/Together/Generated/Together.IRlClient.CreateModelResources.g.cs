#nullable enable

namespace Together
{
    public partial interface IRlClient
    {
        /// <summary>
        /// Create model resources<br/>
        /// Provisions a standalone model resource that training sessions can attach to.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlModelResources> CreateModelResourcesAsync(

            global::Together.RlCreateModelResourcesRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create model resources<br/>
        /// Provisions a standalone model resource that training sessions can attach to.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.RlModelResources>> CreateModelResourcesAsResponseAsync(

            global::Together.RlCreateModelResourcesRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create model resources<br/>
        /// Provisions a standalone model resource that training sessions can attach to.
        /// </summary>
        /// <param name="baseModel">
        /// Base model to provision the resource for<br/>
        /// Example: Qwen/Qwen3-0.6B
        /// </param>
        /// <param name="computeConfig">
        /// Compute layout to provision.
        /// </param>
        /// <param name="loraEnabled">
        /// Whether the resource hosts LoRA sessions or a single full-weight session<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="optimizerConfig">
        /// Optimizer configuration for this resource.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlModelResources> CreateModelResourcesAsync(
            string baseModel,
            global::Together.RlComputeConfigCreateRequest? computeConfig = default,
            bool? loraEnabled = default,
            global::Together.RlOptimizerConfig? optimizerConfig = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}