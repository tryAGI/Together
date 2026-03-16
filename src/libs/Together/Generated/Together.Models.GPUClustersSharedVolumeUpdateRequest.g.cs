
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GPUClustersSharedVolumeUpdateRequest
    {
        /// <summary>
        /// ID of the volume to update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume_id")]
        public string? VolumeId { get; set; }

        /// <summary>
        /// Size of the volume in whole tebibytes (TiB).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_tib")]
        public long? SizeTib { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GPUClustersSharedVolumeUpdateRequest" /> class.
        /// </summary>
        /// <param name="volumeId">
        /// ID of the volume to update.
        /// </param>
        /// <param name="sizeTib">
        /// Size of the volume in whole tebibytes (TiB).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GPUClustersSharedVolumeUpdateRequest(
            string? volumeId,
            long? sizeTib)
        {
            this.VolumeId = volumeId;
            this.SizeTib = sizeTib;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GPUClustersSharedVolumeUpdateRequest" /> class.
        /// </summary>
        public GPUClustersSharedVolumeUpdateRequest()
        {
        }
    }
}