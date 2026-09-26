#nullable enable

namespace Together
{
    public partial interface IRlClient
    {
        /// <summary>
        /// Sample<br/>
        /// Submits a sample operation that will asynchronously generate text completions with logprobs.
        /// </summary>
        /// <param name="sessionId">
        /// Training session ID
        /// </param>
        /// <param name="idempotencyKey">
        /// Required key that makes retries return the original operation; use a new key for changed request bodies.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlSampleOperation> SampleAsync(
            string sessionId,

            global::Together.RlSampleBody request,
            string? idempotencyKey = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sample<br/>
        /// Submits a sample operation that will asynchronously generate text completions with logprobs.
        /// </summary>
        /// <param name="sessionId">
        /// Training session ID
        /// </param>
        /// <param name="idempotencyKey">
        /// Required key that makes retries return the original operation; use a new key for changed request bodies.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.RlSampleOperation>> SampleAsResponseAsync(
            string sessionId,

            global::Together.RlSampleBody request,
            string? idempotencyKey = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sample<br/>
        /// Submits a sample operation that will asynchronously generate text completions with logprobs.
        /// </summary>
        /// <param name="sessionId">
        /// Training session ID
        /// </param>
        /// <param name="idempotencyKey">
        /// Required key that makes retries return the original operation; use a new key for changed request bodies.
        /// </param>
        /// <param name="modelInputs">
        /// Model inputs to sample from
        /// </param>
        /// <param name="samplingParams">
        /// Optional sampling parameters
        /// </param>
        /// <param name="numSamples">
        /// Number of completions to generate per prompt<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="promptLogprobs">
        /// When true, also compute teacher-forced log-probabilities for the model input tokens and return them in `SampleResult.prompt_logprobs`.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="topkPromptLogprobs">
        /// Number of most likely alternative tokens to return per model input token in `SampleResult.topk_prompt_logprobs`. 0 disables top-k prompt log-probabilities. Maximum 20.<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="returnRoutedExperts">
        /// When true, enable reuse of the expert selections from sampled sequences during training. Only supported for mixture-of-experts models; ignored for other models.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlSampleOperation> SampleAsync(
            string sessionId,
            global::System.Collections.Generic.IList<global::Together.RlModelInput> modelInputs,
            string? idempotencyKey = default,
            global::Together.RlSamplingParams? samplingParams = default,
            int? numSamples = default,
            bool? promptLogprobs = default,
            int? topkPromptLogprobs = default,
            bool? returnRoutedExperts = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}