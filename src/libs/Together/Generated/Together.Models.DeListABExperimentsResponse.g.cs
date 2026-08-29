
#nullable enable

namespace Together
{
    /// <summary>
    /// Managed A/B traffic experiments under an endpoint.
    /// </summary>
    public sealed partial class DeListABExperimentsResponse
    {
        /// <summary>
        /// A/B experiments under the endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.DeABExperiment> Data { get; set; }

        /// <summary>
        /// Cursor for the next page. Null if there are no more results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Object type. Always `list`.
        /// </summary>
        /// <default>"list"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "list";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeListABExperimentsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A/B experiments under the endpoint.
        /// </param>
        /// <param name="nextCursor">
        /// Cursor for the next page. Null if there are no more results.
        /// </param>
        /// <param name="object">
        /// Object type. Always `list`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeListABExperimentsResponse(
            global::System.Collections.Generic.IList<global::Together.DeABExperiment> data,
            string? nextCursor,
            string @object = "list")
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.NextCursor = nextCursor;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeListABExperimentsResponse" /> class.
        /// </summary>
        public DeListABExperimentsResponse()
        {
        }

    }
}