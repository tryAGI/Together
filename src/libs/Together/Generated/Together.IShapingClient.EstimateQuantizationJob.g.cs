#nullable enable

namespace Together
{
    public partial interface IShapingClient
    {
        /// <summary>
        /// Estimate FP4 preparation cost<br/>
        /// Reports the price and expected wall-clock time for preparing the model named by `model_object_id` or the deprecated `adapter_object_id` without creating a job. The request body is the same as POST /shaping/prepare-for-fp4-inference, so a caller can price exactly the job it is about to submit.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// estimate = client.post_training.prepare_for_fp4_inference.estimate_cost(<br/>
        ///     inputs={<br/>
        ///         "adapter_object_id": "ml_abc123",<br/>
        ///         "adapter_revision_id": "rv_abc123",<br/>
        ///     },<br/>
        /// )<br/>
        /// print(estimate.price_usd, estimate.time_hours, estimate.allowed_to_proceed)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.QuantizationEstimate> EstimateQuantizationJobAsync(

            global::Together.QuantizationRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Estimate FP4 preparation cost<br/>
        /// Reports the price and expected wall-clock time for preparing the model named by `model_object_id` or the deprecated `adapter_object_id` without creating a job. The request body is the same as POST /shaping/prepare-for-fp4-inference, so a caller can price exactly the job it is about to submit.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// estimate = client.post_training.prepare_for_fp4_inference.estimate_cost(<br/>
        ///     inputs={<br/>
        ///         "adapter_object_id": "ml_abc123",<br/>
        ///         "adapter_revision_id": "rv_abc123",<br/>
        ///     },<br/>
        /// )<br/>
        /// print(estimate.price_usd, estimate.time_hours, estimate.allowed_to_proceed)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.QuantizationEstimate>> EstimateQuantizationJobAsResponseAsync(

            global::Together.QuantizationRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Estimate FP4 preparation cost<br/>
        /// Reports the price and expected wall-clock time for preparing the model named by `model_object_id` or the deprecated `adapter_object_id` without creating a job. The request body is the same as POST /shaping/prepare-for-fp4-inference, so a caller can price exactly the job it is about to submit.
        /// </summary>
        /// <param name="inputs">
        /// Inputs naming the fine-tuned model to prepare.<br/>
        /// Example: {"model_object_id":"ml_CeG3fF6pyEViU8dE8pk7R","model_revision_id":"rv_CeG3faPBj2ABwbAaHPTmx","calibration_file_id":"file-5f1b0c7a-2d19-4a3e-9c60-8ab41c2f7d35"}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.QuantizationEstimate> EstimateQuantizationJobAsync(
            global::Together.QuantizationPipelineInputs inputs,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}