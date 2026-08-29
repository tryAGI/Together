
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BillingUsageReport
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"list"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "list";

        /// <summary>
        /// ID of the organization the report belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// Billing month (YYYY-MM).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_period")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BillingPeriod { get; set; }

        /// <summary>
        /// Start of the earliest time window with usage in the month (UTC, ISO 8601); null when the month has no usage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("earliest_window_start")]
        public global::System.DateTime? EarliestWindowStart { get; set; }

        /// <summary>
        /// Exclusive end of the latest time window with usage in the month (UTC, ISO 8601); null when the month has no usage. Describes the whole month, not the current page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_window_end")]
        public global::System.DateTime? LatestWindowEnd { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"USD"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        public string Currency { get; set; } = "USD";

        /// <summary>
        /// Time windows containing usage line items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.BillingUsageWindow> Data { get; set; }

        /// <summary>
        /// Opaque cursor for the next page; null when this is the last page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingUsageReport" /> class.
        /// </summary>
        /// <param name="organizationId">
        /// ID of the organization the report belongs to.
        /// </param>
        /// <param name="billingPeriod">
        /// Billing month (YYYY-MM).
        /// </param>
        /// <param name="data">
        /// Time windows containing usage line items.
        /// </param>
        /// <param name="earliestWindowStart">
        /// Start of the earliest time window with usage in the month (UTC, ISO 8601); null when the month has no usage.
        /// </param>
        /// <param name="latestWindowEnd">
        /// Exclusive end of the latest time window with usage in the month (UTC, ISO 8601); null when the month has no usage. Describes the whole month, not the current page.
        /// </param>
        /// <param name="nextCursor">
        /// Opaque cursor for the next page; null when this is the last page.
        /// </param>
        /// <param name="object"></param>
        /// <param name="currency"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingUsageReport(
            string organizationId,
            string billingPeriod,
            global::System.Collections.Generic.IList<global::Together.BillingUsageWindow> data,
            global::System.DateTime? earliestWindowStart,
            global::System.DateTime? latestWindowEnd,
            string? nextCursor,
            string @object = "list",
            string currency = "USD")
        {
            this.Object = @object;
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.BillingPeriod = billingPeriod ?? throw new global::System.ArgumentNullException(nameof(billingPeriod));
            this.EarliestWindowStart = earliestWindowStart;
            this.LatestWindowEnd = latestWindowEnd;
            this.Currency = currency;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingUsageReport" /> class.
        /// </summary>
        public BillingUsageReport()
        {
        }

    }
}