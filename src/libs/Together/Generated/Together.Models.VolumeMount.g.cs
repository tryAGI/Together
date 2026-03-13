
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VolumeMount
    {
        /// <summary>
        /// MountPath is the path in the container where the volume will be mounted (e.g., "/data")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mount_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MountPath { get; set; }

        /// <summary>
        /// Name is the name of the volume to mount. Must reference an existing volume by name or ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Version is the volume version to mount. On create, defaults to the latest version. On update, defaults to the currently mounted version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeMount" /> class.
        /// </summary>
        /// <param name="mountPath">
        /// MountPath is the path in the container where the volume will be mounted (e.g., "/data")
        /// </param>
        /// <param name="name">
        /// Name is the name of the volume to mount. Must reference an existing volume by name or ID
        /// </param>
        /// <param name="version">
        /// Version is the volume version to mount. On create, defaults to the latest version. On update, defaults to the currently mounted version.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VolumeMount(
            string mountPath,
            string name,
            int? version)
        {
            this.MountPath = mountPath ?? throw new global::System.ArgumentNullException(nameof(mountPath));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeMount" /> class.
        /// </summary>
        public VolumeMount()
        {
        }
    }
}