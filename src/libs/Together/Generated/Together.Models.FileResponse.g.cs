
#nullable enable

namespace Together
{
    /// <summary>
    /// Structured information describing a file uploaded to Together.
    /// </summary>
    public sealed partial class FileResponse
    {
        /// <summary>
        /// ID of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type, which is always `file`.
        /// </summary>
        /// <default>"file"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "file";

        /// <summary>
        /// The timestamp when the file was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        /// The name of the file as it was uploaded.<br/>
        /// Example: my_file.jsonl
        /// </summary>
        /// <example>my_file.jsonl</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// The number of bytes in the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Bytes { get; set; }

        /// <summary>
        /// The purpose of the file as it was uploaded.<br/>
        /// Example: fine-tune
        /// </summary>
        /// <example>fine-tune</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.FilePurposeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.FilePurpose Purpose { get; set; }

        /// <summary>
        /// Whether the file has been parsed and analyzed for correctness for fine-tuning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Processed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Processed { get; set; }

        /// <summary>
        /// The type of the file such as `jsonl`, `csv`, or `parquet`.<br/>
        /// Default Value: jsonl<br/>
        /// Example: jsonl
        /// </summary>
        /// <default>global::Together.FileType.Jsonl</default>
        /// <example>jsonl</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("FileType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.FileTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.FileType FileType { get; set; } = global::Together.FileType.Jsonl;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the file.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `file`.
        /// </param>
        /// <param name="createdAt">
        /// The timestamp when the file was created.
        /// </param>
        /// <param name="filename">
        /// The name of the file as it was uploaded.<br/>
        /// Example: my_file.jsonl
        /// </param>
        /// <param name="bytes">
        /// The number of bytes in the file.
        /// </param>
        /// <param name="purpose">
        /// The purpose of the file as it was uploaded.<br/>
        /// Example: fine-tune
        /// </param>
        /// <param name="processed">
        /// Whether the file has been parsed and analyzed for correctness for fine-tuning.
        /// </param>
        /// <param name="fileType">
        /// The type of the file such as `jsonl`, `csv`, or `parquet`.<br/>
        /// Default Value: jsonl<br/>
        /// Example: jsonl
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileResponse(
            string id,
            int createdAt,
            string filename,
            long bytes,
            global::Together.FilePurpose purpose,
            bool processed,
            global::Together.FileType fileType,
            string @object = "file")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Bytes = bytes;
            this.Purpose = purpose;
            this.Processed = processed;
            this.FileType = fileType;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileResponse" /> class.
        /// </summary>
        public FileResponse()
        {
        }
    }
}