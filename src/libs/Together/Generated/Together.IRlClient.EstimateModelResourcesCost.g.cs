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
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// estimate = client.post_training.model_resources.estimate_cost(<br/>
        ///     base_model="Qwen/Qwen3.5-9B",<br/>
        ///     lora_enabled=True,<br/>
        ///     compute_config={"gpu_type": "B200-SXM", "num_generator_replicas": 1},<br/>
        /// )<br/>
        /// print(estimate)
        /// </remarks>
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
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// estimate = client.post_training.model_resources.estimate_cost(<br/>
        ///     base_model="Qwen/Qwen3.5-9B",<br/>
        ///     lora_enabled=True,<br/>
        ///     compute_config={"gpu_type": "B200-SXM", "num_generator_replicas": 1},<br/>
        /// )<br/>
        /// print(estimate)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.RlModelResourcesEstimateCostResponse>> EstimateModelResourcesCostAsResponseAsync(

            global::Together.RlCreateModelResourcesRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Estimate on-demand model resource cost<br/>
        /// Estimates a model resource's on-demand hourly price without creating it.
        /// </summary>
        /// <param name="baseModel">
        /// Base model to provision the resource for, selected from /rl/supported-models<br/>
        /// Example: Qwen/Qwen3.5-4B
        /// </param>
        /// <param name="baseWeightsRef">
        /// Model in this project's model registry whose weights the resource trains in place of the base model's own. It must be a full-weight model.<br/>
        /// Example: together://ml_A1b2C3d4E5f6G7h8I9j0K
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
            string? baseWeightsRef = default,
            global::Together.RlComputeConfigCreateRequest? computeConfig = default,
            bool? loraEnabled = default,
            global::Together.RlOptimizerConfig? optimizerConfig = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}