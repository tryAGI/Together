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
        /// The ID of the add-on to retrieve.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AddOnInfo> InstanceClusterAddOnServiceGetAsync(
            string clusterId,
            string addonId,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="clusterId">
        /// The ID of the cluster that owns the add-on.
        /// </param>
        /// <param name="addonId">
        /// The ID of the add-on to retrieve.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.AddOnInfo>> InstanceClusterAddOnServiceGetAsResponseAsync(
            string clusterId,
            string addonId,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}