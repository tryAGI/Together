#nullable enable

namespace Together
{
    public partial interface IFineTuningClient
    {

        /// <summary>
        /// List job events<br/>
        /// List the events for a single fine-tuning job.
        /// </summary>
        /// <param name="id">
        /// The ID of the fine-tune job to list events for
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
        /// response = client.fine_tuning.list_events(id="ft-id")<br/>
        /// for event in response.data:<br/>
        ///     print(event)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.FinetuneListEvents> GetFineTunesByIdEventsAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}