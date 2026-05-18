
#nullable enable

namespace Together
{
    /// <summary>
    /// ListRemediationsResponse is the response for ListRemediations.
    /// </summary>
    public sealed partial class ListRemediationsResponse
    {
        /// <summary>
        /// The list of remediations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remediations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.Remediation> Remediations { get; set; }

        /// <summary>
        /// Token for the next page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NextPageToken { get; set; }

        /// <summary>
        /// Indicates if there are more results available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_next")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasNext { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListRemediationsResponse" /> class.
        /// </summary>
        /// <param name="remediations">
        /// The list of remediations.
        /// </param>
        /// <param name="nextPageToken">
        /// Token for the next page.
        /// </param>
        /// <param name="hasNext">
        /// Indicates if there are more results available.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListRemediationsResponse(
            global::System.Collections.Generic.IList<global::Together.Remediation> remediations,
            string nextPageToken,
            bool hasNext)
        {
            this.Remediations = remediations ?? throw new global::System.ArgumentNullException(nameof(remediations));
            this.NextPageToken = nextPageToken ?? throw new global::System.ArgumentNullException(nameof(nextPageToken));
            this.HasNext = hasNext;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListRemediationsResponse" /> class.
        /// </summary>
        public ListRemediationsResponse()
        {
        }

    }
}