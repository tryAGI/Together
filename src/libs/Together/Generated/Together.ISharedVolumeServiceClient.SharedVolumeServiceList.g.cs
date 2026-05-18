#nullable enable

namespace Together
{
    public partial interface ISharedVolumeServiceClient
    {
        /// <summary>
        /// List all shared volumes<br/>
        /// List all shared volumes.
        /// </summary>
        /// <param name="projectId">
        /// Optional UMS project ID to filter volumes by. When set, only volumes<br/>
        ///  belonging to this project are returned. The caller must be a member of<br/>
        ///  the project; otherwise the result set will be empty.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// volumes = client.beta.clusters.storage.list()<br/>
        /// print(volumes)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.GPUClustersSharedVolumes> SharedVolumeServiceListAsync(
            string? projectId = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List all shared volumes<br/>
        /// List all shared volumes.
        /// </summary>
        /// <param name="projectId">
        /// Optional UMS project ID to filter volumes by. When set, only volumes<br/>
        ///  belonging to this project are returned. The caller must be a member of<br/>
        ///  the project; otherwise the result set will be empty.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// volumes = client.beta.clusters.storage.list()<br/>
        /// print(volumes)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.GPUClustersSharedVolumes>> SharedVolumeServiceListAsResponseAsync(
            string? projectId = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}