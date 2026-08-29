
#nullable enable

namespace Together
{
    /// <summary>
    /// Request parameters for creating a remote upload.
    /// </summary>
    public sealed partial class DeCreateRemoteUploadSpec
    {
        /// <summary>
        /// ID of the registered model that will receive the imported files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// Hugging Face repository URL or presigned archive URL to import.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remoteUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RemoteUrl { get; set; }

        /// <summary>
        /// Optional source credential used to access a private remote location. The value is write-only and is not returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeCreateRemoteUploadSpec" /> class.
        /// </summary>
        /// <param name="modelId">
        /// ID of the registered model that will receive the imported files.
        /// </param>
        /// <param name="remoteUrl">
        /// Hugging Face repository URL or presigned archive URL to import.
        /// </param>
        /// <param name="token">
        /// Optional source credential used to access a private remote location. The value is write-only and is not returned.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeCreateRemoteUploadSpec(
            string modelId,
            string remoteUrl,
            string? token)
        {
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.RemoteUrl = remoteUrl ?? throw new global::System.ArgumentNullException(nameof(remoteUrl));
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeCreateRemoteUploadSpec" /> class.
        /// </summary>
        public DeCreateRemoteUploadSpec()
        {
        }

    }
}