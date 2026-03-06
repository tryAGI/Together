
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GPUClusters
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clusters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.GPUClusterInfo> Clusters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GPUClusters" /> class.
        /// </summary>
        /// <param name="clusters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GPUClusters(
            global::System.Collections.Generic.IList<global::Together.GPUClusterInfo> clusters)
        {
            this.Clusters = clusters ?? throw new global::System.ArgumentNullException(nameof(clusters));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GPUClusters" /> class.
        /// </summary>
        public GPUClusters()
        {
        }
    }
}