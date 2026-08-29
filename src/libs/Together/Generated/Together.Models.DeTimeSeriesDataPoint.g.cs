
#nullable enable

namespace Together
{
    /// <summary>
    /// Timestamped bucket containing one or more named metric values.
    /// </summary>
    public sealed partial class DeTimeSeriesDataPoint
    {
        /// <summary>
        /// Start time of the metric bucket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public global::System.DateTime? Timestamp { get; set; }

        /// <summary>
        /// Metric names mapped to their numeric values for this bucket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        public global::System.Collections.Generic.Dictionary<string, double>? Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeTimeSeriesDataPoint" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// Start time of the metric bucket.
        /// </param>
        /// <param name="values">
        /// Metric names mapped to their numeric values for this bucket.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeTimeSeriesDataPoint(
            global::System.DateTime? timestamp,
            global::System.Collections.Generic.Dictionary<string, double>? values)
        {
            this.Timestamp = timestamp;
            this.Values = values;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeTimeSeriesDataPoint" /> class.
        /// </summary>
        public DeTimeSeriesDataPoint()
        {
        }

    }
}