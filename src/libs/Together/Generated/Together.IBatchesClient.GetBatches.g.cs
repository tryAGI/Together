#nullable enable

namespace Together
{
    public partial interface IBatchesClient
    {
        /// <summary>
        /// List batch jobs<br/>
        /// List all batch jobs for the authenticated user
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
        /// batches = client.batches.list()<br/>
        /// for batch in batches:<br/>
        ///     print(batch.id)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Together.BatchJob>> GetBatchesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}