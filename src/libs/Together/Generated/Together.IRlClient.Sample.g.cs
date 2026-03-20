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

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlSampleOperation> SampleAsync(
            string sessionId,

            global::Together.RlSampleBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Sample<br/>
        /// Submits a sample operation that will asynchronously generate text completions with logprobs.
        /// </summary>
        /// <param name="sessionId">
        /// Training session ID
        /// </param>
        /// <param name="prompt">
        /// Input prompt as tokenized chunks
        /// </param>
        /// <param name="samplingParams">
        /// Optional sampling parameters
        /// </param>
        /// <param name="numSamples">
        /// Number of completions to generate for this prompt<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.RlSampleOperation> SampleAsync(
            string sessionId,
            global::Together.RlModelInput prompt,
            global::Together.RlSamplingParams? samplingParams = default,
            long? numSamples = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}