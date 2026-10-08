#nullable enable

namespace Together
{
    public partial interface IShapingClient
    {
        /// <summary>
        /// Get shaping job<br/>
        /// Retrieve a shaping job owned by the caller's project.
        /// </summary>
        /// <param name="id">
        /// Shaping job ID beginning with `shp-quant-`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.QuantizationJob> GetShapingJobAsync(
            string id,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get shaping job<br/>
        /// Retrieve a shaping job owned by the caller's project.
        /// </summary>
        /// <param name="id">
        /// Shaping job ID beginning with `shp-quant-`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.QuantizationJob>> GetShapingJobAsResponseAsync(
            string id,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}