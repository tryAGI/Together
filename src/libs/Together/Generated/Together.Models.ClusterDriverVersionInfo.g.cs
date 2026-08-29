
#nullable enable

namespace Together
{
    /// <summary>
    /// NVIDIA software configuration available in the region.
    /// </summary>
    public sealed partial class ClusterDriverVersionInfo
    {
        /// <summary>
        /// Semantic CUDA version without operating system text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cuda_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CudaVersion { get; set; }

        /// <summary>
        /// NVIDIA driver version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nvidia_driver_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NvidiaDriverVersion { get; set; }

        /// <summary>
        /// Region-specific NVIDIA catalog ID to send as nvidia_version_id when creating a cluster.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Operating system image family for this catalog entry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("os")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Os { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterDriverVersionInfo" /> class.
        /// </summary>
        /// <param name="cudaVersion">
        /// Semantic CUDA version without operating system text.
        /// </param>
        /// <param name="nvidiaDriverVersion">
        /// NVIDIA driver version.
        /// </param>
        /// <param name="id">
        /// Region-specific NVIDIA catalog ID to send as nvidia_version_id when creating a cluster.
        /// </param>
        /// <param name="os">
        /// Operating system image family for this catalog entry.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClusterDriverVersionInfo(
            string cudaVersion,
            string nvidiaDriverVersion,
            string id,
            string os)
        {
            this.CudaVersion = cudaVersion ?? throw new global::System.ArgumentNullException(nameof(cudaVersion));
            this.NvidiaDriverVersion = nvidiaDriverVersion ?? throw new global::System.ArgumentNullException(nameof(nvidiaDriverVersion));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Os = os ?? throw new global::System.ArgumentNullException(nameof(os));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterDriverVersionInfo" /> class.
        /// </summary>
        public ClusterDriverVersionInfo()
        {
        }

    }
}