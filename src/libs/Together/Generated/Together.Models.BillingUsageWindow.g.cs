
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BillingUsageWindow
    {
        /// <summary>
        /// Day this window covers (UTC, YYYY-MM-DD). Present for both granularities.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Date { get; set; }

        /// <summary>
        /// Window start (UTC, ISO 8601). Start of the day (daily) or hour (hourly).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartTime { get; set; }

        /// <summary>
        /// Window end (UTC, ISO 8601), exclusive. Start of the next day (daily) or hour (hourly).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndTime { get; set; }

        /// <summary>
        /// Usage line items in this time window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line_items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.BillingUsageLineItem> LineItems { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingUsageWindow" /> class.
        /// </summary>
        /// <param name="date">
        /// Day this window covers (UTC, YYYY-MM-DD). Present for both granularities.
        /// </param>
        /// <param name="startTime">
        /// Window start (UTC, ISO 8601). Start of the day (daily) or hour (hourly).
        /// </param>
        /// <param name="endTime">
        /// Window end (UTC, ISO 8601), exclusive. Start of the next day (daily) or hour (hourly).
        /// </param>
        /// <param name="lineItems">
        /// Usage line items in this time window.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingUsageWindow(
            string date,
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            global::System.Collections.Generic.IList<global::Together.BillingUsageLineItem> lineItems)
        {
            this.Date = date ?? throw new global::System.ArgumentNullException(nameof(date));
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.LineItems = lineItems ?? throw new global::System.ArgumentNullException(nameof(lineItems));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingUsageWindow" /> class.
        /// </summary>
        public BillingUsageWindow()
        {
        }

    }
}