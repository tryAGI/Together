
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GPUClusterUpdateRequest
    {
        /// <summary>
        /// Type of cluster to update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cluster_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.GPUClusterUpdateRequestClusterTypeJsonConverter))]
        public global::Together.GPUClusterUpdateRequestClusterType? ClusterType { get; set; }

        /// <summary>
        /// Number of GPUs to allocate in the cluster. This must be multiple of 8. For example, 8, 16 or 24
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_gpus")]
        public int? NumGpus { get; set; }

        /// <summary>
        /// Timestamp at which the cluster should be decommissioned. Only accepted for prepaid clusters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reservation_end_time")]
        public global::System.DateTime? ReservationEndTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GPUClusterUpdateRequest" /> class.
        /// </summary>
        /// <param name="clusterType">
        /// Type of cluster to update.
        /// </param>
        /// <param name="numGpus">
        /// Number of GPUs to allocate in the cluster. This must be multiple of 8. For example, 8, 16 or 24
        /// </param>
        /// <param name="reservationEndTime">
        /// Timestamp at which the cluster should be decommissioned. Only accepted for prepaid clusters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GPUClusterUpdateRequest(
            global::Together.GPUClusterUpdateRequestClusterType? clusterType,
            int? numGpus,
            global::System.DateTime? reservationEndTime)
        {
            this.ClusterType = clusterType;
            this.NumGpus = numGpus;
            this.ReservationEndTime = reservationEndTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GPUClusterUpdateRequest" /> class.
        /// </summary>
        public GPUClusterUpdateRequest()
        {
        }
    }
}