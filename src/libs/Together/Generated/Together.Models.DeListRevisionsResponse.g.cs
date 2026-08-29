
#nullable enable

namespace Together
{
    /// <summary>
    /// Immutable model revisions and pagination metadata.
    /// </summary>
    public sealed partial class DeListRevisionsResponse
    {
        /// <summary>
        /// Immutable revisions available for the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Together.DeListRevisionsResponseRevision>? Data { get; set; }

        /// <summary>
        /// Cursor for the next page. Null if there are no more results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Object type. Always `list`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeListRevisionsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Immutable revisions available for the model.
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
        public DeListRevisionsResponse(
            global::System.Collections.Generic.IList<global::Together.DeListRevisionsResponseRevision>? data,
            string? nextCursor,
            string? @object)
        {
            this.Data = data;
            this.NextCursor = nextCursor;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeListRevisionsResponse" /> class.
        /// </summary>
        public DeListRevisionsResponse()
        {
        }

    }
}