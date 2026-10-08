#nullable enable

namespace Together
{
    public partial interface IShapingClient
    {
        /// <summary>
        /// Estimate FP4 preparation cost<br/>
        /// Reports the price and expected wall-clock time for preparing the named adapter without creating a job. The request body is the same as POST /shaping/prepare-for-fp4-inference, so a caller can price exactly the job it is about to submit.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.QuantizationEstimate> EstimateQuantizationJobAsync(

            global::Together.QuantizationRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Estimate FP4 preparation cost<br/>
        /// Reports the price and expected wall-clock time for preparing the named adapter without creating a job. The request body is the same as POST /shaping/prepare-for-fp4-inference, so a caller can price exactly the job it is about to submit.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.QuantizationEstimate>> EstimateQuantizationJobAsResponseAsync(

            global::Together.QuantizationRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Estimate FP4 preparation cost<br/>
        /// Reports the price and expected wall-clock time for preparing the named adapter without creating a job. The request body is the same as POST /shaping/prepare-for-fp4-inference, so a caller can price exactly the job it is about to submit.
        /// </summary>
        /// <param name="inputs">
        /// Adapter inputs to prepare.<br/>
        /// Example: {"adapter_object_id":"ml_CeG3fF6pyEViU8dE8pk7R","adapter_revision_id":"rv_CeG3faPBj2ABwbAaHPTmx","calibration_file_id":"file-5f1b0c7a-2d19-4a3e-9c60-8ab41c2f7d35"}
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