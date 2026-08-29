
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GPUClusterVolume
    {
        /// <summary>
        /// ID of the volume.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VolumeId { get; set; }

        /// <summary>
        /// User provided name of the volume.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VolumeName { get; set; }

        /// <summary>
        /// Size of the volume in TiB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_tib")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SizeTib { get; set; }

        /// <summary>
        /// Current status of the volume.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GPUClusterVolume" /> class.
        /// </summary>
        /// <param name="volumeId">
        /// ID of the volume.
        /// </param>
        /// <param name="volumeName">
        /// User provided name of the volume.
        /// </param>
        /// <param name="sizeTib">
        /// Size of the volume in TiB.
        /// </param>
        /// <param name="status">
        /// Current status of the volume.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GPUClusterVolume(
            string volumeId,
            string volumeName,
            int sizeTib,
            string status)
        {
            this.VolumeId = volumeId ?? throw new global::System.ArgumentNullException(nameof(volumeId));
            this.VolumeName = volumeName ?? throw new global::System.ArgumentNullException(nameof(volumeName));
            this.SizeTib = sizeTib;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GPUClusterVolume" /> class.
        /// </summary>
        public GPUClusterVolume()
        {
        }

    }
}