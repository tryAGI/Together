#nullable enable

namespace Together
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// Download tokenized dataset<br/>
        /// Get a presigned URL for the tokenized dataset archive generated for a fine-tune job.
        /// </summary>
        /// <param name="id">
        /// The ID of the fine-tune job whose tokenized dataset should be downloaded.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// import os<br/>
        /// client = Together(<br/>
        ///     api_key=os.environ.get("TOGETHER_API_KEY"),<br/>
        /// )<br/>
        /// tokenized_dataset = client.fine_tuning.retrieve_tokenized_dataset(<br/>
        ///     id="ft-id",<br/>
        /// )<br/>
        /// print(tokenized_dataset.url)<br/>
        /// print(tokenized_dataset.filename)<br/>
        /// print(tokenized_dataset.size)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.FineTuneTokenizedDatasetRetrieveResponse> GetFineTunesByIdDownloadTokenizedDatasetAsync(
            string id,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download tokenized dataset<br/>
        /// Get a presigned URL for the tokenized dataset archive generated for a fine-tune job.
        /// </summary>
        /// <param name="id">
        /// The ID of the fine-tune job whose tokenized dataset should be downloaded.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// import os<br/>
        /// client = Together(<br/>
        ///     api_key=os.environ.get("TOGETHER_API_KEY"),<br/>
        /// )<br/>
        /// tokenized_dataset = client.fine_tuning.retrieve_tokenized_dataset(<br/>
        ///     id="ft-id",<br/>
        /// )<br/>
        /// print(tokenized_dataset.url)<br/>
        /// print(tokenized_dataset.filename)<br/>
        /// print(tokenized_dataset.size)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.FineTuneTokenizedDatasetRetrieveResponse>> GetFineTunesByIdDownloadTokenizedDatasetAsResponseAsync(
            string id,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}