
#nullable enable

namespace Together
{
    /// <summary>
    /// Presigned download metadata for a fine-tune tokenized dataset archive.
    /// </summary>
    public sealed partial class FineTuneTokenizedDatasetRetrieveResponse
    {
        /// <summary>
        /// Presigned URL for downloading the tokenized dataset archive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Archive filename to use when saving the downloaded tokenized dataset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Archive size in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Size { get; set; }

        /// <summary>
        /// MIME type for the tokenized dataset archive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

        /// <summary>
        /// Time when the presigned download URL expires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneTokenizedDatasetRetrieveResponse" /> class.
        /// </summary>
        /// <param name="url">
        /// Presigned URL for downloading the tokenized dataset archive.
        /// </param>
        /// <param name="filename">
        /// Archive filename to use when saving the downloaded tokenized dataset.
        /// </param>
        /// <param name="size">
        /// Archive size in bytes.
        /// </param>
        /// <param name="contentType">
        /// MIME type for the tokenized dataset archive.
        /// </param>
        /// <param name="expiresAt">
        /// Time when the presigned download URL expires.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FineTuneTokenizedDatasetRetrieveResponse(
            string url,
            string filename,
            long size,
            string contentType,
            global::System.DateTime expiresAt)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Size = size;
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneTokenizedDatasetRetrieveResponse" /> class.
        /// </summary>
        public FineTuneTokenizedDatasetRetrieveResponse()
        {
        }

    }
}