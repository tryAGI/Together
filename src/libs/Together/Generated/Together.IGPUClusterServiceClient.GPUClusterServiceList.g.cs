#nullable enable

namespace Together
{
    public partial interface IGPUClusterServiceClient
    {
        /// <summary>
        /// List all GPU clusters<br/>
        /// List all GPU clusters.
        /// </summary>
        /// <param name="projectId">
        /// Optional UMS project ID to filter clusters by. When set, only clusters<br/>
        ///  belonging to this project are returned. The caller must be a member of<br/>
        ///  the project; otherwise the result set will be empty.
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
        /// response = client.beta.clusters.list()<br/>
        /// print(response.clusters)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.GPUClusters> GPUClusterServiceListAsync(
            string? projectId = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List all GPU clusters<br/>
        /// List all GPU clusters.
        /// </summary>
        /// <param name="projectId">
        /// Optional UMS project ID to filter clusters by. When set, only clusters<br/>
        ///  belonging to this project are returned. The caller must be a member of<br/>
        ///  the project; otherwise the result set will be empty.
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
        /// response = client.beta.clusters.list()<br/>
        /// print(response.clusters)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.GPUClusters>> GPUClusterServiceListAsResponseAsync(
            string? projectId = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}