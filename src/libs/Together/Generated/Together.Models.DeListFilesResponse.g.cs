
#nullable enable

namespace Together
{
    /// <summary>
    /// Files and aggregate size information for one model revision.
    /// </summary>
    public sealed partial class DeListFilesResponse
    {
        /// <summary>
        /// Files in the selected model revision.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.DeListFilesResponseFile> Data { get; set; }

        /// <summary>
        /// Cursor for the next page. Null if there are no more results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"list"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "list";

        /// <summary>
        /// ID of the model revision whose files are listed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revisionId")]
        public string? RevisionId { get; set; }

        /// <summary>
        /// Time when the listed model revision was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revisionCreatedAt")]
        public global::System.DateTime? RevisionCreatedAt { get; set; }

        /// <summary>
        /// Total size of all files in the revision, in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalSizeBytes")]
        public string? TotalSizeBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeListFilesResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Files in the selected model revision.
        /// </param>
        /// <param name="nextCursor">
        /// Cursor for the next page. Null if there are no more results.
        /// </param>
        /// <param name="revisionId">
        /// ID of the model revision whose files are listed.
        /// </param>
        /// <param name="revisionCreatedAt">
        /// Time when the listed model revision was created.
        /// </param>
        /// <param name="totalSizeBytes">
        /// Total size of all files in the revision, in bytes.
        /// </param>
        /// <param name="object"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeListFilesResponse(
            global::System.Collections.Generic.IList<global::Together.DeListFilesResponseFile> data,
            string? nextCursor,
            string? revisionId,
            global::System.DateTime? revisionCreatedAt,
            string? totalSizeBytes,
            string @object = "list")
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.NextCursor = nextCursor;
            this.Object = @object;
            this.RevisionId = revisionId;
            this.RevisionCreatedAt = revisionCreatedAt;
            this.TotalSizeBytes = totalSizeBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeListFilesResponse" /> class.
        /// </summary>
        public DeListFilesResponse()
        {
        }

    }
}