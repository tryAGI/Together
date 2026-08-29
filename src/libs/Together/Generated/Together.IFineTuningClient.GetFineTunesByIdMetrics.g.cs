#nullable enable

namespace Together
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// Get metrics<br/>
        /// Retrieves recorded training metrics for a fine-tuning job in chronological order. All query parameters are optional: omit them to retrieve all metrics.
        /// </summary>
        /// <param name="id">
        /// Fine-tune job ID. A string that starts with `ft-`.
        /// </param>
        /// <param name="globalStepFrom"></param>
        /// <param name="globalStepTo"></param>
        /// <param name="loggedAtFrom"></param>
        /// <param name="loggedAtTo"></param>
        /// <param name="resolution"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// curl -X GET "https://api.together.ai/v1/fine-tunes/ft-id/metrics?global_step_from=0&amp;global_step_to=500" \<br/>
        ///      -H "Authorization: Bearer $TOGETHER_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.GetFineTunesMetricsResponse> GetFineTunesByIdMetricsAsync(
            string id,
            int? globalStepFrom = default,
            int? globalStepTo = default,
            global::System.DateTime? loggedAtFrom = default,
            global::System.DateTime? loggedAtTo = default,
            int? resolution = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get metrics<br/>
        /// Retrieves recorded training metrics for a fine-tuning job in chronological order. All query parameters are optional: omit them to retrieve all metrics.
        /// </summary>
        /// <param name="id">
        /// Fine-tune job ID. A string that starts with `ft-`.
        /// </param>
        /// <param name="globalStepFrom"></param>
        /// <param name="globalStepTo"></param>
        /// <param name="loggedAtFrom"></param>
        /// <param name="loggedAtTo"></param>
        /// <param name="resolution"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// curl -X GET "https://api.together.ai/v1/fine-tunes/ft-id/metrics?global_step_from=0&amp;global_step_to=500" \<br/>
        ///      -H "Authorization: Bearer $TOGETHER_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.GetFineTunesMetricsResponse>> GetFineTunesByIdMetricsAsResponseAsync(
            string id,
            int? globalStepFrom = default,
            int? globalStepTo = default,
            global::System.DateTime? loggedAtFrom = default,
            global::System.DateTime? loggedAtTo = default,
            int? resolution = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}