
#nullable enable

namespace Together
{
    /// <summary>
    /// Response containing shadow experiments and pagination metadata.
    /// </summary>
    public sealed partial class DeListShadowExperimentsResponse
    {
        /// <summary>
        /// Shadow experiments under the endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.DeShadowExperiment> Data { get; set; }

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
        /// Initializes a new instance of the <see cref="DeListShadowExperimentsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Shadow experiments under the endpoint.
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
        public DeListShadowExperimentsResponse(
            global::System.Collections.Generic.IList<global::Together.DeShadowExperiment> data,
            string? nextCursor,
            string @object = "list")
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.NextCursor = nextCursor;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeListShadowExperimentsResponse" /> class.
        /// </summary>
        public DeListShadowExperimentsResponse()
        {
        }

    }
}