
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GPUClustersSharedVolumeCreateRequest
    {
        /// <summary>
        /// User provided name of the volume.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VolumeName { get; set; }

        /// <summary>
        /// Volume size in whole tebibytes (TiB).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_tib")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long SizeTib { get; set; }

        /// <summary>
        /// Region name. Usable regions can be found from `clusters.list_regions()`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// When true, the shared volume is not deleted when the cluster is decommissioned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_lifecycle_independent")]
        public bool? IsLifecycleIndependent { get; set; }

        /// <summary>
        /// Project ID that will own the volume. When omitted, the caller's default project is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GPUClustersSharedVolumeCreateRequest" /> class.
        /// </summary>
        /// <param name="volumeName">
        /// User provided name of the volume.
        /// </param>
        /// <param name="sizeTib">
        /// Volume size in whole tebibytes (TiB).
        /// </param>
        /// <param name="region">
        /// Region name. Usable regions can be found from `clusters.list_regions()`
        /// </param>
        /// <param name="isLifecycleIndependent">
        /// When true, the shared volume is not deleted when the cluster is decommissioned.
        /// </param>
        /// <param name="projectId">
        /// Project ID that will own the volume. When omitted, the caller's default project is used.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GPUClustersSharedVolumeCreateRequest(
            string volumeName,
            long sizeTib,
            string region,
            bool? isLifecycleIndependent,
            string? projectId)
        {
            this.VolumeName = volumeName ?? throw new global::System.ArgumentNullException(nameof(volumeName));
            this.SizeTib = sizeTib;
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.IsLifecycleIndependent = isLifecycleIndependent;
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GPUClustersSharedVolumeCreateRequest" /> class.
        /// </summary>
        public GPUClustersSharedVolumeCreateRequest()
        {
        }

    }
}