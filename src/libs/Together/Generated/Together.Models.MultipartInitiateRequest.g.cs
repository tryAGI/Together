
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MultipartInitiateRequest
    {
        /// <summary>
        /// Total size of the file in bytes<br/>
        /// Example: 7516192768L
        /// </summary>
        /// <example>7516192768L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long FileSize { get; set; }

        /// <summary>
        /// The type of the file<br/>
        /// Default Value: jsonl<br/>
        /// Example: jsonl
        /// </summary>
        /// <default>global::Together.FileType.Jsonl</default>
        /// <example>jsonl</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.FileTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.FileType FileType { get; set; } = global::Together.FileType.Jsonl;

        /// <summary>
        /// The name of the file being uploaded<br/>
        /// Example: large_dataset.jsonl
        /// </summary>
        /// <example>large_dataset.jsonl</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Number of parts to split the file into (1-250)<br/>
        /// Example: 75
        /// </summary>
        /// <example>75</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_parts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumParts { get; set; }

        /// <summary>
        /// The purpose of the file<br/>
        /// Example: fine-tune
        /// </summary>
        /// <example>fine-tune</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.FilePurposeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.FilePurpose Purpose { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartInitiateRequest" /> class.
        /// </summary>
        /// <param name="fileSize">
        /// Total size of the file in bytes<br/>
        /// Example: 7516192768L
        /// </param>
        /// <param name="fileType">
        /// The type of the file<br/>
        /// Default Value: jsonl<br/>
        /// Example: jsonl
        /// </param>
        /// <param name="filename">
        /// The name of the file being uploaded<br/>
        /// Example: large_dataset.jsonl
        /// </param>
        /// <param name="numParts">
        /// Number of parts to split the file into (1-250)<br/>
        /// Example: 75
        /// </param>
        /// <param name="purpose">
        /// The purpose of the file<br/>
        /// Example: fine-tune
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultipartInitiateRequest(
            long fileSize,
            global::Together.FileType fileType,
            string filename,
            int numParts,
            global::Together.FilePurpose purpose)
        {
            this.FileSize = fileSize;
            this.FileType = fileType;
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.NumParts = numParts;
            this.Purpose = purpose;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartInitiateRequest" /> class.
        /// </summary>
        public MultipartInitiateRequest()
        {
        }
    }
}