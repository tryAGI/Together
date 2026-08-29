
#nullable enable

namespace Together
{
    /// <summary>
    /// Aggregate and per-request token usage over a time range.
    /// </summary>
    public sealed partial class DeTokenMetrics
    {
        /// <summary>
        /// Total input tokens processed during the time range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalInputTokens")]
        public string? TotalInputTokens { get; set; }

        /// <summary>
        /// Total output tokens generated during the time range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalOutputTokens")]
        public string? TotalOutputTokens { get; set; }

        /// <summary>
        /// Average input tokens per request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avgInputTokens")]
        public double? AvgInputTokens { get; set; }

        /// <summary>
        /// Average output tokens per request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avgOutputTokens")]
        public double? AvgOutputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeTokenMetrics" /> class.
        /// </summary>
        /// <param name="totalInputTokens">
        /// Total input tokens processed during the time range.
        /// </param>
        /// <param name="totalOutputTokens">
        /// Total output tokens generated during the time range.
        /// </param>
        /// <param name="avgInputTokens">
        /// Average input tokens per request.
        /// </param>
        /// <param name="avgOutputTokens">
        /// Average output tokens per request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeTokenMetrics(
            string? totalInputTokens,
            string? totalOutputTokens,
            double? avgInputTokens,
            double? avgOutputTokens)
        {
            this.TotalInputTokens = totalInputTokens;
            this.TotalOutputTokens = totalOutputTokens;
            this.AvgInputTokens = avgInputTokens;
            this.AvgOutputTokens = avgOutputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeTokenMetrics" /> class.
        /// </summary>
        public DeTokenMetrics()
        {
        }

    }
}