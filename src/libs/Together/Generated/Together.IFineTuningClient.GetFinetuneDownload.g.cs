#nullable enable

namespace Together
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// Download model<br/>
        /// Receive a compressed fine-tuned model or checkpoint.
        /// </summary>
        /// <param name="ftId">
        /// Fine-tune ID to download. A string that starts with `ft-`.
        /// </param>
        /// <param name="checkpointStep">
        /// Specifies the checkpoint step to download from the list checkpoints response. A final checkpoint step downloads the final model; 0 or omitted downloads the final model by default. Ignores `checkpoint` value if set.
        /// </param>
        /// <param name="checkpoint">
        /// Specifies checkpoint type to download - `merged` vs `adapter`. This field is required if the checkpoint_step is not set.
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
        /// # Using `with_streaming_response` gives you control to do what you want with the response.<br/>
        /// stream = client.fine_tuning.with_streaming_response.content(ft_id="ft-id")<br/>
        /// with stream as response:<br/>
        ///     for line in response.iter_lines():<br/>
        ///         print(line)
        /// </remarks>
        global::System.Threading.Tasks.Task<byte[]> GetFinetuneDownloadAsync(
            string ftId,
            int? checkpointStep = default,
            global::Together.GetFinetuneDownloadCheckpoint? checkpoint = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download model<br/>
        /// Receive a compressed fine-tuned model or checkpoint.
        /// </summary>
        /// <param name="ftId">
        /// Fine-tune ID to download. A string that starts with `ft-`.
        /// </param>
        /// <param name="checkpointStep">
        /// Specifies the checkpoint step to download from the list checkpoints response. A final checkpoint step downloads the final model; 0 or omitted downloads the final model by default. Ignores `checkpoint` value if set.
        /// </param>
        /// <param name="checkpoint">
        /// Specifies checkpoint type to download - `merged` vs `adapter`. This field is required if the checkpoint_step is not set.
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
        /// # Using `with_streaming_response` gives you control to do what you want with the response.<br/>
        /// stream = client.fine_tuning.with_streaming_response.content(ft_id="ft-id")<br/>
        /// with stream as response:<br/>
        ///     for line in response.iter_lines():<br/>
        ///         print(line)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> GetFinetuneDownloadAsStreamAsync(
            string ftId,
            int? checkpointStep = default,
            global::Together.GetFinetuneDownloadCheckpoint? checkpoint = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download model<br/>
        /// Receive a compressed fine-tuned model or checkpoint.
        /// </summary>
        /// <param name="ftId">
        /// Fine-tune ID to download. A string that starts with `ft-`.
        /// </param>
        /// <param name="checkpointStep">
        /// Specifies the checkpoint step to download from the list checkpoints response. A final checkpoint step downloads the final model; 0 or omitted downloads the final model by default. Ignores `checkpoint` value if set.
        /// </param>
        /// <param name="checkpoint">
        /// Specifies checkpoint type to download - `merged` vs `adapter`. This field is required if the checkpoint_step is not set.
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
        /// # Using `with_streaming_response` gives you control to do what you want with the response.<br/>
        /// stream = client.fine_tuning.with_streaming_response.content(ft_id="ft-id")<br/>
        /// with stream as response:<br/>
        ///     for line in response.iter_lines():<br/>
        ///         print(line)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<byte[]>> GetFinetuneDownloadAsResponseAsync(
            string ftId,
            int? checkpointStep = default,
            global::Together.GetFinetuneDownloadCheckpoint? checkpoint = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}