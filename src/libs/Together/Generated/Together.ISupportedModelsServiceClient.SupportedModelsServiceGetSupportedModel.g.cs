#nullable enable

namespace Together
{
    public partial interface ISupportedModelsServiceClient
    {
        /// <summary>
        /// Get a supported model<br/>
        /// Retrieves a Together-hosted base model and the certified model, configuration, hardware, and performance profiles available for deployment.
        /// </summary>
        /// <param name="id">
        /// Supported model identifier.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeSupportedModel> SupportedModelsServiceGetSupportedModelAsync(
            string id,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a supported model<br/>
        /// Retrieves a Together-hosted base model and the certified model, configuration, hardware, and performance profiles available for deployment.
        /// </summary>
        /// <param name="id">
        /// Supported model identifier.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeSupportedModel>> SupportedModelsServiceGetSupportedModelAsResponseAsync(
            string id,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}