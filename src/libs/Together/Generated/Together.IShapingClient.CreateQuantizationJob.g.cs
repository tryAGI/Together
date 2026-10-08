#nullable enable

namespace Together
{
    public partial interface IShapingClient
    {
        /// <summary>
        /// Prepare a fine-tuned model for FP4 inference<br/>
        /// Merges a fine-tuned adapter into its base model and prepares the result for FP4 inference. The adapter is resolved when the request is made, so a request naming a model that does not exist in the project, is not an adapter, was not produced by fine-tuning, has no base model to merge into, or uses an unsupported base model is rejected with 400 rather than accepted and failed later. The run is priced before it is created, and a project that cannot cover it is answered 402.
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
        /// Merges a fine-tuned adapter into its base model and prepares the result for FP4 inference. The adapter is resolved when the request is made, so a request naming a model that does not exist in the project, is not an adapter, was not produced by fine-tuning, has no base model to merge into, or uses an unsupported base model is rejected with 400 rather than accepted and failed later. The run is priced before it is created, and a project that cannot cover it is answered 402.
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
        /// Merges a fine-tuned adapter into its base model and prepares the result for FP4 inference. The adapter is resolved when the request is made, so a request naming a model that does not exist in the project, is not an adapter, was not produced by fine-tuning, has no base model to merge into, or uses an unsupported base model is rejected with 400 rather than accepted and failed later. The run is priced before it is created, and a project that cannot cover it is answered 402.
        /// </summary>
        /// <param name="inputs">
        /// Adapter inputs to prepare.<br/>
        /// Example: {"adapter_object_id":"ml_CeG3fF6pyEViU8dE8pk7R","adapter_revision_id":"rv_CeG3faPBj2ABwbAaHPTmx","calibration_file_id":"file-5f1b0c7a-2d19-4a3e-9c60-8ab41c2f7d35"}
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