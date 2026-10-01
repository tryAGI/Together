
#nullable enable

namespace Together
{
    /// <summary>
    /// Metadata for a previous volume version.
    /// </summary>
    public sealed partial class VersionHistoryItem
    {
        /// <summary>
        /// Content configuration used to create this version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::Together.VolumeContentRequest? Content { get; set; }

        /// <summary>
        /// Deployment IDs currently mounting this version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mounted_by")]
        public global::System.Collections.Generic.IList<string>? MountedBy { get; set; }

        /// <summary>
        /// Status of this volume version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.VolumeStatusJsonConverter))]
        public global::Together.VolumeStatus? Status { get; set; }

        /// <summary>
        /// Message explaining why this volume version failed, when applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_message")]
        public string? StatusMessage { get; set; }

        /// <summary>
        /// Numeric version identifier for this volume content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VersionHistoryItem" /> class.
        /// </summary>
        /// <param name="content">
        /// Content configuration used to create this version.
        /// </param>
        /// <param name="mountedBy">
        /// Deployment IDs currently mounting this version.
        /// </param>
        /// <param name="status">
        /// Status of this volume version.
        /// </param>
        /// <param name="statusMessage">
        /// Message explaining why this volume version failed, when applicable.
        /// </param>
        /// <param name="version">
        /// Numeric version identifier for this volume content.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VersionHistoryItem(
            global::Together.VolumeContentRequest? content,
            global::System.Collections.Generic.IList<string>? mountedBy,
            global::Together.VolumeStatus? status,
            string? statusMessage,
            int? version)
        {
            this.Content = content;
            this.MountedBy = mountedBy;
            this.Status = status;
            this.StatusMessage = statusMessage;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VersionHistoryItem" /> class.
        /// </summary>
        public VersionHistoryItem()
        {
        }

    }
}