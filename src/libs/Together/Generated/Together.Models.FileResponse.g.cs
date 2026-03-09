
#nullable enable

namespace Together
{
    /// <summary>
    /// Structured information describing a file uploaded to Together.
    /// </summary>
    public sealed partial class FileResponse
    {
        /// <summary>
        /// The type of the file<br/>
        /// Default Value: jsonl<br/>
        /// Example: jsonl
        /// </summary>
        /// <default>global::Together.FileType.Jsonl</default>
        /// <example>jsonl</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("FileType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.FileTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Together.FileType FileType { get; set; } = default!;

        /// <summary>
        /// Whether the file has been parsed and analyzed for correctness for fine-tuning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Processed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public bool Processed { get; set; } = default!;

        /// <summary>
        /// The number of bytes in the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int Bytes { get; set; } = default!;

        /// <summary>
        /// The timestamp when the file was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int CreatedAt { get; set; } = default!;

        /// <summary>
        /// The name of the file as it was uploaded.<br/>
        /// Example: my_file.jsonl
        /// </summary>
        /// <example>my_file.jsonl</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// ID of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The object type, which is always `file`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.FileResponseObjectJsonConverter))]
        public global::Together.FileResponseObject Object { get; set; }

        /// <summary>
        /// The purpose of the file<br/>
        /// Example: fine-tune
        /// </summary>
        /// <example>fine-tune</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.FilePurposeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Together.FilePurpose Purpose { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileResponse" /> class.
        /// </summary>
        /// <param name="fileType">
        /// The type of the file<br/>
        /// Default Value: jsonl<br/>
        /// Example: jsonl
        /// </param>
        /// <param name="processed">
        /// Whether the file has been parsed and analyzed for correctness for fine-tuning.
        /// </param>
        /// <param name="bytes">
        /// The number of bytes in the file.
        /// </param>
        /// <param name="createdAt">
        /// The timestamp when the file was created.
        /// </param>
        /// <param name="filename">
        /// The name of the file as it was uploaded.<br/>
        /// Example: my_file.jsonl
        /// </param>
        /// <param name="id">
        /// ID of the file.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `file`.
        /// </param>
        /// <param name="purpose">
        /// The purpose of the file<br/>
        /// Example: fine-tune
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileResponse(
            global::Together.FileType fileType,
            bool processed,
            int bytes,
            int createdAt,
            string filename,
            string id,
            global::Together.FilePurpose purpose,
            global::Together.FileResponseObject @object)
        {
            this.FileType = fileType;
            this.Processed = processed;
            this.Bytes = bytes;
            this.CreatedAt = createdAt;
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Purpose = purpose;
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