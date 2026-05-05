#nullable enable

namespace Together
{
    public partial interface IBatchesClient
    {
        /// <summary>
        /// Create a batch job<br/>
        /// Create a new batch job with the given input file and endpoint
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// # Docs for v1 can be found by changing the above selector ^<br/>
        /// from together import Together<br/>
        /// import os<br/>
        /// client = Together(<br/>
        ///     api_key=os.environ.get("TOGETHER_API_KEY"),<br/>
        /// )<br/>
        /// batch = client.batches.create(input_file_id="file_id", endpoint="/v1/chat/completions")<br/>
        /// print(batch.job)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.BatchJobWithWarning> CreateBatchesAsync(

            global::Together.CreateBatchRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a batch job<br/>
        /// Create a new batch job with the given input file and endpoint
        /// </summary>
        /// <param name="endpoint">
        /// The endpoint to use for batch processing<br/>
        /// Example: /v1/chat/completions
        /// </param>
        /// <param name="inputFileId">
        /// ID of the uploaded input file containing batch requests<br/>
        /// Example: file-abc123def456ghi789
        /// </param>
        /// <param name="completionWindow">
        /// Time window for batch completion (optional)<br/>
        /// Example: 24h
        /// </param>
        /// <param name="priority">
        /// Priority for batch processing (optional)<br/>
        /// Example: 1
        /// </param>
        /// <param name="modelId">
        /// Model to use for processing batch requests<br/>
        /// Example: Qwen/Qwen3.5-9B
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.BatchJobWithWarning> CreateBatchesAsync(
            string endpoint,
            string inputFileId,
            string? completionWindow = default,
            int? priority = default,
            string? modelId = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}