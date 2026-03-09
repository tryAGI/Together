
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GPUClusterVolume
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_tib")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int SizeTib { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string VolumeId { get; set; } = default!;

        /// <summary>
        /// 
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
        /// Initializes a new instance of the <see cref="GPUClusterVolume" /> class.
        /// </summary>
        /// <param name="sizeTib"></param>
        /// <param name="status"></param>
        /// <param name="volumeId"></param>
        /// <param name="volumeName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GPUClusterVolume(
            int sizeTib,
            string status,
            string volumeId,
            string volumeName)
        {
            this.SizeTib = sizeTib;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.VolumeId = volumeId ?? throw new global::System.ArgumentNullException(nameof(volumeId));
            this.VolumeName = volumeName ?? throw new global::System.ArgumentNullException(nameof(volumeName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GPUClusterVolume" /> class.
        /// </summary>
        public GPUClusterVolume()
        {
        }
    }
}