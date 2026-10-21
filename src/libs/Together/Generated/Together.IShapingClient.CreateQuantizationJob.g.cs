#nullable enable

namespace Together
{
    public partial interface IShapingClient
    {
        /// <summary>
        /// Prepare a fine-tuned model for FP4 inference<br/>
        /// Prepares a fine-tuned model for FP4 inference: an adapter is merged into its base model and the result quantized to FP4; a full model is quantized as it is. The model is resolved when the request is made, so a request naming a model that does not exist in the project, was not produced by fine-tuning, has no base model, or uses an unsupported base model is rejected with 400 rather than accepted and failed later. The request names the model by `model_object_id` (the deprecated `adapter_object_id` is still accepted). The run is priced before it is created, and a project that cannot cover it is answered 402.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.QuantizationJob> CreateQuantizationJobAsync(

            global::Together.QuantizationRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Prepare a fine-tuned model for FP4 inference<br/>
        /// Prepares a fine-tuned model for FP4 inference: an adapter is merged into its base model and the result quantized to FP4; a full model is quantized as it is. The model is resolved when the request is made, so a request naming a model that does not exist in the project, was not produced by fine-tuning, has no base model, or uses an unsupported base model is rejected with 400 rather than accepted and failed later. The request names the model by `model_object_id` (the deprecated `adapter_object_id` is still accepted). The run is priced before it is created, and a project that cannot cover it is answered 402.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.QuantizationJob>> CreateQuantizationJobAsResponseAsync(

            global::Together.QuantizationRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Prepare a fine-tuned model for FP4 inference<br/>
        /// Prepares a fine-tuned model for FP4 inference: an adapter is merged into its base model and the result quantized to FP4; a full model is quantized as it is. The model is resolved when the request is made, so a request naming a model that does not exist in the project, was not produced by fine-tuning, has no base model, or uses an unsupported base model is rejected with 400 rather than accepted and failed later. The request names the model by `model_object_id` (the deprecated `adapter_object_id` is still accepted). The run is priced before it is created, and a project that cannot cover it is answered 402.
        /// </summary>
        /// <param name="inputs">
        /// Inputs naming the fine-tuned model to prepare.<br/>
        /// Example: {"model_object_id":"ml_CeG3fF6pyEViU8dE8pk7R","model_revision_id":"rv_CeG3faPBj2ABwbAaHPTmx","calibration_file_id":"file-5f1b0c7a-2d19-4a3e-9c60-8ab41c2f7d35"}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.QuantizationJob> CreateQuantizationJobAsync(
            global::Together.QuantizationPipelineInputs inputs,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}