
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileResponse
    {
        /// <summary>
        /// Example: jsonl
        /// </summary>
        /// <example>jsonl</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("FileType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.FileResponseFileTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.FileResponseFileType FileType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("LineCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LineCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Processed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Processed { get; set; }

        /// <summary>
        /// Example: 2664
        /// </summary>
        /// <example>2664</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Bytes { get; set; }

        /// <summary>
        /// Example: 1715021438
        /// </summary>
        /// <example>1715021438</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        /// Example: my_file.jsonl
        /// </summary>
        /// <example>my_file.jsonl</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Example: file
        /// </summary>
        /// <example>file</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Object { get; set; }

        /// <summary>
        /// Example: fine-tune
        /// </summary>
        /// <example>fine-tune</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.FileResponsePurposeJsonConverter))]
        public global::Together.FileResponsePurpose Purpose { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileResponse" /> class.
        /// </summary>
        /// <param name="fileType">
        /// Example: jsonl
        /// </param>
        /// <param name="lineCount"></param>
        /// <param name="processed"></param>
        /// <param name="bytes">
        /// Example: 2664
        /// </param>
        /// <param name="createdAt">
        /// Example: 1715021438
        /// </param>
        /// <param name="filename">
        /// Example: my_file.jsonl
        /// </param>
        /// <param name="id"></param>
        /// <param name="object">
        /// Example: file
        /// </param>
        /// <param name="purpose">
        /// Example: fine-tune
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileResponse(
            global::Together.FileResponseFileType fileType,
            int lineCount,
            bool processed,
            int bytes,
            int createdAt,
            string filename,
            string id,
            string @object,
            global::Together.FileResponsePurpose purpose)
        {
            this.FileType = fileType;
            this.LineCount = lineCount;
            this.Processed = processed;
            this.Bytes = bytes;
            this.CreatedAt = createdAt;
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.Purpose = purpose;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileResponse" /> class.
        /// </summary>
        public FileResponse()
        {
        }
    }
}