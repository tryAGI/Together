#nullable enable

namespace Together
{
    public partial interface IRlClient
    {
        /// <summary>
        /// Estimate on-demand model resource cost<br/>
        /// Estimates a model resource's on-demand hourly price without creating it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlModelResourcesEstimateCostResponse> EstimateModelResourcesCostAsync(

            global::Together.RlCreateModelResourcesRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Estimate on-demand model resource cost<br/>
        /// Estimates a model resource's on-demand hourly price without creating it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.RlModelResourcesEstimateCostResponse>> EstimateModelResourcesCostAsResponseAsync(

            global::Together.RlCreateModelResourcesRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Estimate on-demand model resource cost<br/>
        /// Estimates a model resource's on-demand hourly price without creating it.
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
        global::System.Threading.Tasks.Task<global::Together.RlModelResourcesEstimateCostResponse> EstimateModelResourcesCostAsync(
            string baseModel,
            global::Together.RlComputeConfigCreateRequest? computeConfig = default,
            bool? loraEnabled = default,
            global::Together.RlOptimizerConfig? optimizerConfig = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}