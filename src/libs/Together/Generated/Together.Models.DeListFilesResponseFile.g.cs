
#nullable enable

namespace Together
{
    /// <summary>
    /// Metadata for one file in a model revision.
    /// </summary>
    public sealed partial class DeListFilesResponseFile
    {
        /// <summary>
        /// File path within the model revision.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Content hash for integrity verification and upload deduplication.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hash")]
        public string? Hash { get; set; }

        /// <summary>
        /// File size in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sizeBytes")]
        public string? SizeBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeListFilesResponseFile" /> class.
        /// </summary>
        /// <param name="path">
        /// File path within the model revision.
        /// </param>
        /// <param name="hash">
        /// Content hash for integrity verification and upload deduplication.
        /// </param>
        /// <param name="sizeBytes">
        /// File size in bytes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeListFilesResponseFile(
            string? path,
            string? hash,
            string? sizeBytes)
        {
            this.Path = path;
            this.Hash = hash;
            this.SizeBytes = sizeBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeListFilesResponseFile" /> class.
        /// </summary>
        public DeListFilesResponseFile()
        {
        }

    }
}