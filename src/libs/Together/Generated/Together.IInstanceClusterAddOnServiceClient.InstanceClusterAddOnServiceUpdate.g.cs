#nullable enable

namespace Together
{
    public partial interface IInstanceClusterAddOnServiceClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="clusterId">
        /// The ID of the cluster that owns the add-on.
        /// </param>
        /// <param name="addonId">
        /// The ID of the add-on to update.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AddOnInfo> InstanceClusterAddOnServiceUpdateAsync(
            string clusterId,
            string addonId,

            global::Together.ClusterAddOnUpdateRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="clusterId">
        /// The ID of the cluster that owns the add-on.
        /// </param>
        /// <param name="addonId">
        /// The ID of the add-on to update.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.AddOnInfo>> InstanceClusterAddOnServiceUpdateAsResponseAsync(
            string clusterId,
            string addonId,

            global::Together.ClusterAddOnUpdateRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="clusterId">
        /// The ID of the cluster that owns the add-on.
        /// </param>
        /// <param name="addonId">
        /// The ID of the add-on to update.
        /// </param>
        /// <param name="config">
        /// Configuration for a cluster add-on.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AddOnInfo> InstanceClusterAddOnServiceUpdateAsync(
            string clusterId,
            string addonId,
            global::Together.AddOnConfig? config = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}