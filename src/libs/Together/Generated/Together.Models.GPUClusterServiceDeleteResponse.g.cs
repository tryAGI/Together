
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GPUClusterServiceDeleteResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cluster_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClusterId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GPUClusterServiceDeleteResponse" /> class.
        /// </summary>
        /// <param name="clusterId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GPUClusterServiceDeleteResponse(
            string clusterId)
        {
            this.ClusterId = clusterId ?? throw new global::System.ArgumentNullException(nameof(clusterId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GPUClusterServiceDeleteResponse" /> class.
        /// </summary>
        public GPUClusterServiceDeleteResponse()
        {
        }
    }
}