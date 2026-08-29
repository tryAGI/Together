
#nullable enable

namespace Together
{
    /// <summary>
    /// Request counts, rate, and status-code distribution over a time range.
    /// </summary>
    public sealed partial class DeRequestMetrics
    {
        /// <summary>
        /// Total requests received during the time range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalRequests")]
        public string? TotalRequests { get; set; }

        /// <summary>
        /// Requests completed successfully during the time range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successfulRequests")]
        public string? SuccessfulRequests { get; set; }

        /// <summary>
        /// Requests that failed during the time range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failedRequests")]
        public string? FailedRequests { get; set; }

        /// <summary>
        /// Average requests per second over the time range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestsPerSecond")]
        public double? RequestsPerSecond { get; set; }

        /// <summary>
        /// Request counts keyed by HTTP status code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestsByStatusCode")]
        public global::System.Collections.Generic.Dictionary<string, string>? RequestsByStatusCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeRequestMetrics" /> class.
        /// </summary>
        /// <param name="totalRequests">
        /// Total requests received during the time range.
        /// </param>
        /// <param name="successfulRequests">
        /// Requests completed successfully during the time range.
        /// </param>
        /// <param name="failedRequests">
        /// Requests that failed during the time range.
        /// </param>
        /// <param name="requestsPerSecond">
        /// Average requests per second over the time range.
        /// </param>
        /// <param name="requestsByStatusCode">
        /// Request counts keyed by HTTP status code.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeRequestMetrics(
            string? totalRequests,
            string? successfulRequests,
            string? failedRequests,
            double? requestsPerSecond,
            global::System.Collections.Generic.Dictionary<string, string>? requestsByStatusCode)
        {
            this.TotalRequests = totalRequests;
            this.SuccessfulRequests = successfulRequests;
            this.FailedRequests = failedRequests;
            this.RequestsPerSecond = requestsPerSecond;
            this.RequestsByStatusCode = requestsByStatusCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeRequestMetrics" /> class.
        /// </summary>
        public DeRequestMetrics()
        {
        }

    }
}