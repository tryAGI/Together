
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VolumeResponseItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::Together.VolumeContent? Content { get; set; }

        /// <summary>
        /// CreatedAt is the ISO8601 timestamp when this volume was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// CurrentVersion is the current version number of this volume
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_version")]
        public int? CurrentVersion { get; set; }

        /// <summary>
        /// ID is the unique identifier for this volume
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// MountedBy is the list of deployment IDs currently mounting current volume version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mounted_by")]
        public global::System.Collections.Generic.IList<string>? MountedBy { get; set; }

        /// <summary>
        /// Name is the name of the volume
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Object is the type identifier for this response (always "volume")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.VolumeTypeJsonConverter))]
        public global::Together.VolumeType? Type { get; set; }

        /// <summary>
        /// UpdatedAt is the ISO8601 timestamp when this volume was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// VersionHistory contains previous versions of this volume, keyed by version number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_history")]
        public global::System.Collections.Generic.Dictionary<string, global::Together.VersionHistoryItem>? VersionHistory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeResponseItem" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="createdAt">
        /// CreatedAt is the ISO8601 timestamp when this volume was created
        /// </param>
        /// <param name="currentVersion">
        /// CurrentVersion is the current version number of this volume
        /// </param>
        /// <param name="id">
        /// ID is the unique identifier for this volume
        /// </param>
        /// <param name="mountedBy">
        /// MountedBy is the list of deployment IDs currently mounting current volume version
        /// </param>
        /// <param name="name">
        /// Name is the name of the volume
        /// </param>
        /// <param name="object">
        /// Object is the type identifier for this response (always "volume")
        /// </param>
        /// <param name="type"></param>
        /// <param name="updatedAt">
        /// UpdatedAt is the ISO8601 timestamp when this volume was last updated
        /// </param>
        /// <param name="versionHistory">
        /// VersionHistory contains previous versions of this volume, keyed by version number
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VolumeResponseItem(
            global::Together.VolumeContent? content,
            string? createdAt,
            int? currentVersion,
            string? id,
            global::System.Collections.Generic.IList<string>? mountedBy,
            string? name,
            string? @object,
            global::Together.VolumeType? type,
            string? updatedAt,
            global::System.Collections.Generic.Dictionary<string, global::Together.VersionHistoryItem>? versionHistory)
        {
            this.Content = content;
            this.CreatedAt = createdAt;
            this.CurrentVersion = currentVersion;
            this.Id = id;
            this.MountedBy = mountedBy;
            this.Name = name;
            this.Object = @object;
            this.Type = type;
            this.UpdatedAt = updatedAt;
            this.VersionHistory = versionHistory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeResponseItem" /> class.
        /// </summary>
        public VolumeResponseItem()
        {
        }
    }
}