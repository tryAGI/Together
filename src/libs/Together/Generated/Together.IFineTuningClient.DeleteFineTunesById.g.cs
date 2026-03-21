#nullable enable

namespace Together
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// Delete a fine-tune job<br/>
        /// Delete a fine-tuning job.
        /// </summary>
        /// <param name="id">
        /// The ID of the fine-tune job to delete
        /// </param>
        /// <param name="force">
        /// Deprecated and unused parameter.<br/>
        /// Default Value: false
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
        /// response = client.fine_tuning.delete(id="ft-id")<br/>
        /// print(response)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.FinetuneDeleteResponse> DeleteFineTunesByIdAsync(
            string id,
            bool? force = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}