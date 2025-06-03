
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Request
    {
        /// <summary>
        /// The content of the file being uploaded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// The content of the file being uploaded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// The name of the file being uploaded<br/>
        /// Example: dataset.csv
        /// </summary>
        /// <example>dataset.csv</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileName { get; set; }

        /// <summary>
        /// The type of the file<br/>
        /// Default Value: jsonl<br/>
        /// Example: jsonl
        /// </summary>
        /// <example>jsonl</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.FileTypeJsonConverter))]
        public global::Together.FileType? FileType { get; set; }

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
        /// Initializes a new instance of the <see cref="Request" /> class.
        /// </summary>
        /// <param name="file">
        /// The content of the file being uploaded
        /// </param>
        /// <param name="filename">
        /// The content of the file being uploaded
        /// </param>
        /// <param name="fileName">
        /// The name of the file being uploaded<br/>
        /// Example: dataset.csv
        /// </param>
        /// <param name="fileType">
        /// The type of the file<br/>
        /// Default Value: jsonl<br/>
        /// Example: jsonl
        /// </param>
        /// <param name="purpose">
        /// The purpose of the file<br/>
        /// Example: fine-tune
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Request(
            byte[] file,
            string filename,
            string fileName,
            global::Together.FilePurpose purpose,
            global::Together.FileType? fileType)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.FileName = fileName ?? throw new global::System.ArgumentNullException(nameof(fileName));
            this.Purpose = purpose;
            this.FileType = fileType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Request" /> class.
        /// </summary>
        public Request()
        {
        }
    }
}