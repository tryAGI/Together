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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.BatchJobWithWarning> CreateBatchesAsync(
            global::Together.CreateBatchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a batch job<br/>
        /// Create a new batch job with the given input file and endpoint
        /// </summary>
        /// <param name="completionWindow">
        /// Time window for batch completion (optional)<br/>
        /// Example: 24h
        /// </param>
        /// <param name="endpoint">
        /// The endpoint to use for batch processing<br/>
        /// Example: /v1/chat/completions
        /// </param>
        /// <param name="inputFileId">
        /// ID of the uploaded input file containing batch requests<br/>
        /// Example: file-abc123def456ghi789
        /// </param>
        /// <param name="modelId">
        /// Model to use for processing batch requests<br/>
        /// Example: meta-llama/Meta-Llama-3.1-8B-Instruct-Turbo
        /// </param>
        /// <param name="priority">
        /// Priority for batch processing (optional)<br/>
        /// Example: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.BatchJobWithWarning> CreateBatchesAsync(
            string endpoint,
            string inputFileId,
            string? completionWindow = default,
            string? modelId = default,
            int? priority = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}