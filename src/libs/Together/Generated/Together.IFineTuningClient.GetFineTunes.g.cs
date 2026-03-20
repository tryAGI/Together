#nullable enable

namespace Together
{
    public partial interface IFineTuningClient
    {

        /// <summary>
        /// List all jobs<br/>
        /// List the metadata for all fine-tuning jobs. Returns a list of FinetuneResponseTruncated objects.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>

        /// <remarks>
        /// # Docs for v1 can be found by changing the above selector ^<br/>
        /// from together import Together<br/>
        /// import os<br/>
        /// client = Together(<br/>
        ///     api_key=os.environ.get("TOGETHER_API_KEY"),<br/>
        /// )<br/>
        /// response = client.fine_tuning.list()<br/>
        /// for fine_tune in response.data:<br/>
        ///     print(f"ID: {fine_tune.id}, Status: {fine_tune.status}")
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.FinetuneTruncatedList> GetFineTunesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}