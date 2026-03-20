#nullable enable

namespace Together
{
    public partial interface IFineTuningClient
    {

        /// <summary>
        /// List job<br/>
        /// List the metadata for a single fine-tuning job.
        /// </summary>
        /// <param name="id">
        /// The ID of the job to retrieve
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
        /// fine_tune = client.fine_tuning.retrieve(id="ft-id")<br/>
        /// print(fine_tune)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.FinetuneResponse> GetFineTunesByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}