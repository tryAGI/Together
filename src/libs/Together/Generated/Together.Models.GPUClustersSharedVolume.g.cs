
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GPUClustersSharedVolume
    {
        /// <summary>
        /// Size of the volume in whole tebibytes (TiB).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_tib")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int SizeTib { get; set; } = default!;

        /// <summary>
        /// Deployment status of the volume.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.GPUClustersSharedVolumeStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Together.GPUClustersSharedVolumeStatus Status { get; set; } = default!;

        /// <summary>
        /// ID of the volume.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string VolumeId { get; set; } = default!;

        /// <summary>
        /// Provided name of the volume.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string VolumeName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GPUClustersSharedVolume" /> class.
        /// </summary>
        /// <param name="sizeTib">
        /// Size of the volume in whole tebibytes (TiB).
        /// </param>
        /// <param name="status">
        /// Deployment status of the volume.
        /// </param>
        /// <param name="volumeId">
        /// ID of the volume.
        /// </param>
        /// <param name="volumeName">
        /// Provided name of the volume.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GPUClustersSharedVolume(
            int sizeTib,
            global::Together.GPUClustersSharedVolumeStatus status,
            string volumeId,
            string volumeName)
        {
            this.SizeTib = sizeTib;
            this.Status = status;
            this.VolumeId = volumeId ?? throw new global::System.ArgumentNullException(nameof(volumeId));
            this.VolumeName = volumeName ?? throw new global::System.ArgumentNullException(nameof(volumeName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GPUClustersSharedVolume" /> class.
        /// </summary>
        public GPUClustersSharedVolume()
        {
        }
    }
}