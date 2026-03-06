
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VersionHistoryItem
    {
        /// <summary>
        /// Content specifies the new content that will be preloaded to this volume
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::Together.VolumeContentRequest? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mounted_by")]
        public global::System.Collections.Generic.IList<string>? MountedBy { get; set; }

        /// <summary>
        /// 
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
        /// Content specifies the new content that will be preloaded to this volume
        /// </param>
        /// <param name="mountedBy"></param>
        /// <param name="version"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VersionHistoryItem(
            global::Together.VolumeContentRequest? content,
            global::System.Collections.Generic.IList<string>? mountedBy,
            int? version)
        {
            this.Content = content;
            this.MountedBy = mountedBy;
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