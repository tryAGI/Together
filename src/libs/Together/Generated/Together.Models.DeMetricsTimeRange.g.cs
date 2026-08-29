
#nullable enable

namespace Together
{
    /// <summary>
    /// Closed-open time range used by metrics and analytics responses.
    /// </summary>
    public sealed partial class DeMetricsTimeRange
    {
        /// <summary>
        /// Inclusive start of the time range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTime")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Exclusive end of the time range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endTime")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeMetricsTimeRange" /> class.
        /// </summary>
        /// <param name="startTime">
        /// Inclusive start of the time range.
        /// </param>
        /// <param name="endTime">
        /// Exclusive end of the time range.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeMetricsTimeRange(
            global::System.DateTime? startTime,
            global::System.DateTime? endTime)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeMetricsTimeRange" /> class.
        /// </summary>
        public DeMetricsTimeRange()
        {
        }

    }
}