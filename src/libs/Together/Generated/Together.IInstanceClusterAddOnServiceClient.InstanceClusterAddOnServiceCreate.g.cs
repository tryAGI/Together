#nullable enable

namespace Together
{
    public partial interface IInstanceClusterAddOnServiceClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="clusterId">
        /// The ID of the cluster to create the add-on on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AddOnInfo> InstanceClusterAddOnServiceCreateAsync(
            string clusterId,

            global::Together.ClusterAddOnCreateRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="clusterId">
        /// The ID of the cluster to create the add-on on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.AddOnInfo>> InstanceClusterAddOnServiceCreateAsResponseAsync(
            string clusterId,

            global::Together.ClusterAddOnCreateRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="clusterId">
        /// The ID of the cluster to create the add-on on.
        /// </param>
        /// <param name="name"></param>
        /// <param name="addOnType"></param>
        /// <param name="config"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AddOnInfo> InstanceClusterAddOnServiceCreateAsync(
            string clusterId,
            string name,
            string addOnType,
            global::Together.AddOnConfig? config = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}