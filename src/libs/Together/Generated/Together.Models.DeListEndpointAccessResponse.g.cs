
#nullable enable

namespace Together
{
    /// <summary>
    /// Principals currently allowed to send inference requests to an endpoint.
    /// </summary>
    public sealed partial class DeListEndpointAccessResponse
    {
        /// <summary>
        /// All principals currently granted access on the endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entries")]
        public global::System.Collections.Generic.IList<global::Together.DeAccessEntry>? Entries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeListEndpointAccessResponse" /> class.
        /// </summary>
        /// <param name="entries">
        /// All principals currently granted access on the endpoint.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeListEndpointAccessResponse(
            global::System.Collections.Generic.IList<global::Together.DeAccessEntry>? entries)
        {
            this.Entries = entries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeListEndpointAccessResponse" /> class.
        /// </summary>
        public DeListEndpointAccessResponse()
        {
        }

    }
}