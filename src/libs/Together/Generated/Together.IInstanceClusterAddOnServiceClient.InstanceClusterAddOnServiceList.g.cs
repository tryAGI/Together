#nullable enable

namespace Together
{
    public partial interface IInstanceClusterAddOnServiceClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="clusterId">
        /// The ID of the cluster whose add-ons to list.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.ClusterAddOnsListResponse> InstanceClusterAddOnServiceListAsync(
            string clusterId,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="clusterId">
        /// The ID of the cluster whose add-ons to list.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.ClusterAddOnsListResponse>> InstanceClusterAddOnServiceListAsResponseAsync(
            string clusterId,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}