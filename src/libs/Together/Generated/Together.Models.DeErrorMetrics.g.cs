
#nullable enable

namespace Together
{
    /// <summary>
    /// Error rate and aggregate counts by error type. Individual error samples are not included.
    /// </summary>
    public sealed partial class DeErrorMetrics
    {
        /// <summary>
        /// Percentage in [0, 100].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorRate")]
        public double? ErrorRate { get; set; }

        /// <summary>
        /// Counts of errors keyed by error type (e.g. HTTP status code or error kind).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorsByType")]
        public global::System.Collections.Generic.Dictionary<string, string>? ErrorsByType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeErrorMetrics" /> class.
        /// </summary>
        /// <param name="errorRate">
        /// Percentage in [0, 100].
        /// </param>
        /// <param name="errorsByType">
        /// Counts of errors keyed by error type (e.g. HTTP status code or error kind).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeErrorMetrics(
            double? errorRate,
            global::System.Collections.Generic.Dictionary<string, string>? errorsByType)
        {
            this.ErrorRate = errorRate;
            this.ErrorsByType = errorsByType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeErrorMetrics" /> class.
        /// </summary>
        public DeErrorMetrics()
        {
        }

    }
}