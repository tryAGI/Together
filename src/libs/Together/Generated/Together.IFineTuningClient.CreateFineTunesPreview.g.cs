#nullable enable

namespace Together
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// Preview tokenized data<br/>
        /// Preview how sampled rows from a fine-tuning training file will be tokenized before packing.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.FineTunePreviewResponse> CreateFineTunesPreviewAsync(

            global::Together.FineTunePreviewRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Preview tokenized data<br/>
        /// Preview how sampled rows from a fine-tuning training file will be tokenized before packing.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.FineTunePreviewResponse>> CreateFineTunesPreviewAsResponseAsync(

            global::Together.FineTunePreviewRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Preview tokenized data<br/>
        /// Preview how sampled rows from a fine-tuning training file will be tokenized before packing.
        /// </summary>
        /// <param name="model">
        /// Name of the base model whose tokenizer and chat template will be used.
        /// </param>
        /// <param name="trainingFile">
        /// File-ID of the uploaded JSONL training file to sample for preview.
        /// </param>
        /// <param name="trainingMethod">
        /// Fine-tuning method to preview. Only supervised fine-tuning is currently supported.<br/>
        /// Default Value: sft
        /// </param>
        /// <param name="trainOnInputs">
        /// Whether prompt or user-message tokens should contribute to training loss in the preview.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="topK">
        /// Maximum number of rows from the start of the training file to tokenize.<br/>
        /// Default Value: 5
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.FineTunePreviewResponse> CreateFineTunesPreviewAsync(
            string model,
            string trainingFile,
            global::Together.FineTunePreviewRequestTrainingMethod? trainingMethod = default,
            bool? trainOnInputs = default,
            int? topK = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}