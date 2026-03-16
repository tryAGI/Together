
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileInfo
    {
        /// <summary>
        /// LastModified is the timestamp when the file was last modified
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_modified")]
        public string? LastModified { get; set; }

        /// <summary>
        /// Name is the filename including extension (e.g., "model_weights.bin")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Size is the file size in bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public long? Size { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileInfo" /> class.
        /// </summary>
        /// <param name="lastModified">
        /// LastModified is the timestamp when the file was last modified
        /// </param>
        /// <param name="name">
        /// Name is the filename including extension (e.g., "model_weights.bin")
        /// </param>
        /// <param name="size">
        /// Size is the file size in bytes
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileInfo(
            string? lastModified,
            string? name,
            long? size)
        {
            this.LastModified = lastModified;
            this.Name = name;
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileInfo" /> class.
        /// </summary>
        public FileInfo()
        {
        }
    }
}