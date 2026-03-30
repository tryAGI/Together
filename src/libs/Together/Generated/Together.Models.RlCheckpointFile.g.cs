
#nullable enable

namespace Together
{
    /// <summary>
    /// A downloadable file within a checkpoint
    /// </summary>
    public sealed partial class RlCheckpointFile
    {
        /// <summary>
        /// Name of the file<br/>
        /// Example: model-00001-of-00002.safetensors
        /// </summary>
        /// <example>model-00001-of-00002.safetensors</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Presigned URL for downloading the file<br/>
        /// Example: https://...
        /// </summary>
        /// <example>https://...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// File size in bytes<br/>
        /// Example: 123456789
        /// </summary>
        /// <example>123456789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Size { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlCheckpointFile" /> class.
        /// </summary>
        /// <param name="filename">
        /// Name of the file<br/>
        /// Example: model-00001-of-00002.safetensors
        /// </param>
        /// <param name="url">
        /// Presigned URL for downloading the file<br/>
        /// Example: https://...
        /// </param>
        /// <param name="size">
        /// File size in bytes<br/>
        /// Example: 123456789
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlCheckpointFile(
            string filename,
            string url,
            string size)
        {
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Size = size ?? throw new global::System.ArgumentNullException(nameof(size));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlCheckpointFile" /> class.
        /// </summary>
        public RlCheckpointFile()
        {
        }
    }
}