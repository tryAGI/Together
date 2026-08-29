#nullable enable

namespace Together
{
    public partial interface ISupportedModelsServiceClient
    {
        /// <summary>
        /// List supported models<br/>
        /// Lists Together-hosted base models that can be deployed for dedicated inference, together with their capabilities and certified deployment profiles.
        /// </summary>
        /// <param name="modality">
        /// Filter models by input modality.
        /// </param>
        /// <param name="product">
        /// Filter models by product surface.
        /// </param>
        /// <param name="search">
        /// Case-insensitive search across model IDs, names, and descriptions.
        /// </param>
        /// <param name="limit">
        /// Maximum number of models to return.
        /// </param>
        /// <param name="after">
        /// Cursor from a previous supported-model list response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.DeListSupportedModelsResponse> SupportedModelsServiceListSupportedModelsAsync(
            global::Together.SupportedModelsServiceListSupportedModelsModality? modality = default,
            global::Together.SupportedModelsServiceListSupportedModelsProduct? product = default,
            string? search = default,
            int? limit = default,
            string? after = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List supported models<br/>
        /// Lists Together-hosted base models that can be deployed for dedicated inference, together with their capabilities and certified deployment profiles.
        /// </summary>
        /// <param name="modality">
        /// Filter models by input modality.
        /// </param>
        /// <param name="product">
        /// Filter models by product surface.
        /// </param>
        /// <param name="search">
        /// Case-insensitive search across model IDs, names, and descriptions.
        /// </param>
        /// <param name="limit">
        /// Maximum number of models to return.
        /// </param>
        /// <param name="after">
        /// Cursor from a previous supported-model list response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.DeListSupportedModelsResponse>> SupportedModelsServiceListSupportedModelsAsResponseAsync(
            global::Together.SupportedModelsServiceListSupportedModelsModality? modality = default,
            global::Together.SupportedModelsServiceListSupportedModelsProduct? product = default,
            string? search = default,
            int? limit = default,
            string? after = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}