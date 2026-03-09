
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GPUClustersSharedVolumeCreateRequest
    {
        /// <summary>
        /// Customizable name of the volume to create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VolumeName { get; set; }

        /// <summary>
        /// Volume size in whole tebibytes (TiB).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_tib")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SizeTib { get; set; }

        /// <summary>
        /// Region name. Usable regions can be found from `client.clusters.list_regions()`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GPUClustersSharedVolumeCreateRequest" /> class.
        /// </summary>
        /// <param name="volumeName">
        /// Customizable name of the volume to create.
        /// </param>
        /// <param name="sizeTib">
        /// Volume size in whole tebibytes (TiB).
        /// </param>
        /// <param name="region">
        /// Region name. Usable regions can be found from `client.clusters.list_regions()`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GPUClustersSharedVolumeCreateRequest(
            string volumeName,
            int sizeTib,
            string region)
        {
            this.VolumeName = volumeName ?? throw new global::System.ArgumentNullException(nameof(volumeName));
            this.SizeTib = sizeTib;
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GPUClustersSharedVolumeCreateRequest" /> class.
        /// </summary>
        public GPUClustersSharedVolumeCreateRequest()
        {
        }
    }
}