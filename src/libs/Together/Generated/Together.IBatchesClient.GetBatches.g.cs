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
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Together.BatchJob>> GetBatchesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}