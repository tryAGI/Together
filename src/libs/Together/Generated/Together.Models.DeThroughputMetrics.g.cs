
#nullable enable

namespace Together
{
    /// <summary>
    /// Token, request, and batching throughput over a time range.
    /// </summary>
    public sealed partial class DeThroughputMetrics
    {
        /// <summary>
        /// Average generated tokens per second.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokensPerSecond")]
        public double? TokensPerSecond { get; set; }

        /// <summary>
        /// Average completed requests per second.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestsPerSecond")]
        public double? RequestsPerSecond { get; set; }

        /// <summary>
        /// Average number of requests processed in each runtime batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avgBatchSize")]
        public double? AvgBatchSize { get; set; }

        /// <summary>
        /// Average number of batches queued or in flight in the serving engine.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avgBatchDepth")]
        public double? AvgBatchDepth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeThroughputMetrics" /> class.
        /// </summary>
        /// <param name="tokensPerSecond">
        /// Average generated tokens per second.
        /// </param>
        /// <param name="requestsPerSecond">
        /// Average completed requests per second.
        /// </param>
        /// <param name="avgBatchSize">
        /// Average number of requests processed in each runtime batch.
        /// </param>
        /// <param name="avgBatchDepth">
        /// Average number of batches queued or in flight in the serving engine.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeThroughputMetrics(
            double? tokensPerSecond,
            double? requestsPerSecond,
            double? avgBatchSize,
            double? avgBatchDepth)
        {
            this.TokensPerSecond = tokensPerSecond;
            this.RequestsPerSecond = requestsPerSecond;
            this.AvgBatchSize = avgBatchSize;
            this.AvgBatchDepth = avgBatchDepth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeThroughputMetrics" /> class.
        /// </summary>
        public DeThroughputMetrics()
        {
        }

    }
}