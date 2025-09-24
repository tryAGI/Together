
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MultipartInitiateResponse
    {
        /// <summary>
        /// File ID for the upload<br/>
        /// Example: file-def456
        /// </summary>
        /// <example>file-def456</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// Presigned URLs and headers for each part
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.PartInfo> Parts { get; set; }

        /// <summary>
        /// Unique identifier for this multipart upload session<br/>
        /// Example: upload-abc123
        /// </summary>
        /// <example>upload-abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UploadId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartInitiateResponse" /> class.
        /// </summary>
        /// <param name="fileId">
        /// File ID for the upload<br/>
        /// Example: file-def456
        /// </param>
        /// <param name="parts">
        /// Presigned URLs and headers for each part
        /// </param>
        /// <param name="uploadId">
        /// Unique identifier for this multipart upload session<br/>
        /// Example: upload-abc123
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultipartInitiateResponse(
            string fileId,
            global::System.Collections.Generic.IList<global::Together.PartInfo> parts,
            string uploadId)
        {
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.Parts = parts ?? throw new global::System.ArgumentNullException(nameof(parts));
            this.UploadId = uploadId ?? throw new global::System.ArgumentNullException(nameof(uploadId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartInitiateResponse" /> class.
        /// </summary>
        public MultipartInitiateResponse()
        {
        }
    }
}