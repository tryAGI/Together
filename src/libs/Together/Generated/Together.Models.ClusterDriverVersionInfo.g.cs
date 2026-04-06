
#nullable enable

namespace Together
{
    /// <summary>
    /// CUDA/NVIDIA driver versions pair available in the region to use in the create cluster request.
    /// </summary>
    public sealed partial class ClusterDriverVersionInfo
    {
        /// <summary>
        /// CUDA driver version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cuda_driver_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CudaDriverVersion { get; set; }

        /// <summary>
        /// NVIDIA driver version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nvidia_driver_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NvidiaDriverVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterDriverVersionInfo" /> class.
        /// </summary>
        /// <param name="cudaDriverVersion">
        /// CUDA driver version.
        /// </param>
        /// <param name="nvidiaDriverVersion">
        /// NVIDIA driver version.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClusterDriverVersionInfo(
            string cudaDriverVersion,
            string nvidiaDriverVersion)
        {
            this.CudaDriverVersion = cudaDriverVersion ?? throw new global::System.ArgumentNullException(nameof(cudaDriverVersion));
            this.NvidiaDriverVersion = nvidiaDriverVersion ?? throw new global::System.ArgumentNullException(nameof(nvidiaDriverVersion));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterDriverVersionInfo" /> class.
        /// </summary>
        public ClusterDriverVersionInfo()
        {
        }
    }
}