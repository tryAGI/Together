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

        /// <remarks>
        /// from together import Together<br/>
        /// import os<br/>
        /// client = Together(<br/>
        ///     api_key=os.environ.get("TOGETHER_API_KEY"),<br/>
        /// )<br/>
        /// response = client.beta.clusters.list()<br/>
        /// print(response.clusters)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.GPUClusters> GPUClusterServiceListAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}