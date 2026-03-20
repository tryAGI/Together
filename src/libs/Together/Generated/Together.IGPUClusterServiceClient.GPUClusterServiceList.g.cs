#nullable enable

namespace Together
{
    public partial interface IGPUClusterServiceClient
    {
        /// <summary>
        /// List all GPU clusters.<br/>
        /// List all GPU clusters.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.GPUClusters> GPUClusterServiceListAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}