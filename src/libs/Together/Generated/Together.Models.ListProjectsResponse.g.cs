
#nullable enable

namespace Together
{
    /// <summary>
    /// One page of projects available to the authenticated caller.
    /// </summary>
    public sealed partial class ListProjectsResponse
    {
        /// <summary>
        /// Object type. Always `list`.
        /// </summary>
        /// <default>"list"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "list";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.Project> Data { get; set; }

        /// <summary>
        /// Opaque cursor for the next page. Empty when this is the last page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectsResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="nextCursor">
        /// Opaque cursor for the next page. Empty when this is the last page.
        /// </param>
        /// <param name="object">
        /// Object type. Always `list`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListProjectsResponse(
            global::System.Collections.Generic.IList<global::Together.Project> data,
            string nextCursor,
            string @object = "list")
        {
            this.Object = @object;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.NextCursor = nextCursor ?? throw new global::System.ArgumentNullException(nameof(nextCursor));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectsResponse" /> class.
        /// </summary>
        public ListProjectsResponse()
        {
        }

    }
}