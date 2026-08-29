
#nullable enable

namespace Together
{
    /// <summary>
    /// Response returned when listing passive health check alerts.
    /// </summary>
    public sealed partial class ListPassiveHealthCheckAlertsResponse
    {
        /// <summary>
        /// Alerts on the current page, ordered by the request sort order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alerts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.PassiveHealthCheckAlert> Alerts { get; set; }

        /// <summary>
        /// Opaque token for the next page. Empty means there are no more pages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NextPageToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPassiveHealthCheckAlertsResponse" /> class.
        /// </summary>
        /// <param name="alerts">
        /// Alerts on the current page, ordered by the request sort order.
        /// </param>
        /// <param name="nextPageToken">
        /// Opaque token for the next page. Empty means there are no more pages.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListPassiveHealthCheckAlertsResponse(
            global::System.Collections.Generic.IList<global::Together.PassiveHealthCheckAlert> alerts,
            string nextPageToken)
        {
            this.Alerts = alerts ?? throw new global::System.ArgumentNullException(nameof(alerts));
            this.NextPageToken = nextPageToken ?? throw new global::System.ArgumentNullException(nameof(nextPageToken));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPassiveHealthCheckAlertsResponse" /> class.
        /// </summary>
        public ListPassiveHealthCheckAlertsResponse()
        {
        }

    }
}