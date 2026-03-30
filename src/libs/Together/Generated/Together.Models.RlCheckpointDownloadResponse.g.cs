
#nullable enable

namespace Together
{
    /// <summary>
    /// Presigned download URLs for a checkpoint's files
    /// </summary>
    public sealed partial class RlCheckpointDownloadResponse
    {
        /// <summary>
        /// List of files with presigned download URLs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.RlCheckpointFile> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlCheckpointDownloadResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// List of files with presigned download URLs
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlCheckpointDownloadResponse(
            global::System.Collections.Generic.IList<global::Together.RlCheckpointFile> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlCheckpointDownloadResponse" /> class.
        /// </summary>
        public RlCheckpointDownloadResponse()
        {
        }
    }
}