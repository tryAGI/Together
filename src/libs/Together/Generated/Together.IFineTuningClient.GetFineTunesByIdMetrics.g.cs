#nullable enable

namespace Together
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// Get metrics<br/>
        /// Retrieves recorded training metrics for a fine-tuning job in chronological order. All filter fields are optional — omit the body or send `{}` to retrieve all metrics.
        /// </summary>
        /// <param name="id">
        /// Fine-tune job ID. A string that starts with `ft-`.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// curl -X GET "https://api.together.ai/v1/fine-tunes/ft-id/metrics" \<br/>
        ///      -H "Authorization: Bearer $TOGETHER_API_KEY" \<br/>
        ///      -H "Content-Type: application/json" \<br/>
        ///      -d '{<br/>
        ///        "global_step_from": 0,<br/>
        ///        "global_step_to": 500<br/>
        ///      }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.GetFineTunesMetricsResponse> GetFineTunesByIdMetricsAsync(
            string id,

            global::Together.GetFineTunesMetricsRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get metrics<br/>
        /// Retrieves recorded training metrics for a fine-tuning job in chronological order. All filter fields are optional — omit the body or send `{}` to retrieve all metrics.
        /// </summary>
        /// <param name="id">
        /// Fine-tune job ID. A string that starts with `ft-`.
        /// </param>
        /// <param name="globalStepFrom">
        /// Return only metrics with global_step &gt;= this value.<br/>
        /// Example: 0
        /// </param>
        /// <param name="globalStepTo">
        /// Return only metrics with global_step &lt;= this value.<br/>
        /// Example: 500
        /// </param>
        /// <param name="loggedAtFrom">
        /// Return only metrics logged at or after this ISO-8601 timestamp.<br/>
        /// Example: 2024-01-01T00:00:00Z
        /// </param>
        /// <param name="loggedAtTo">
        /// Return only metrics logged at or before this ISO-8601 timestamp.<br/>
        /// Example: 2024-01-01T12:00:00Z
        /// </param>
        /// <param name="resolution">
        /// Number of (uniformly sampled) train metrics to return.<br/>
        /// Example: 100
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.GetFineTunesMetricsResponse> GetFineTunesByIdMetricsAsync(
            string id,
            long? globalStepFrom = default,
            long? globalStepTo = default,
            global::System.DateTime? loggedAtFrom = default,
            global::System.DateTime? loggedAtTo = default,
            long? resolution = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}