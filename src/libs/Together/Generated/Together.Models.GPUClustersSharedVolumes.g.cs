
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GPUClustersSharedVolumes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volumes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::Together.GPUClustersSharedVolume> Volumes { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GPUClustersSharedVolumes" /> class.
        /// </summary>
        /// <param name="volumes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GPUClustersSharedVolumes(
            global::System.Collections.Generic.IList<global::Together.GPUClustersSharedVolume> volumes)
        {
            this.Volumes = volumes ?? throw new global::System.ArgumentNullException(nameof(volumes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GPUClustersSharedVolumes" /> class.
        /// </summary>
        public GPUClustersSharedVolumes()
        {
        }
    }
}