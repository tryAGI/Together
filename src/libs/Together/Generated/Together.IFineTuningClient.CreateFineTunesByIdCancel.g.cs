#nullable enable

namespace Together
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// Cancel job<br/>
        /// Cancel a currently running fine-tuning job. Returns a FinetuneResponseTruncated object.
        /// </summary>
        /// <param name="id">
        /// Fine-tune ID to cancel. A string that starts with `ft-`.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// # Docs for v1 can be found by changing the above selector ^<br/>
        /// from together import Together<br/>
        /// import os<br/>
        /// client = Together(<br/>
        ///     api_key=os.environ.get("TOGETHER_API_KEY"),<br/>
        /// )<br/>
        /// response = client.fine_tuning.cancel(id="ft-id")<br/>
        /// print(response)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.FinetuneResponseTruncated> CreateFineTunesByIdCancelAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}