
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
        /// Target GPU count for the cluster. When omitted, the server keeps the current GPU count from cluster metadata (use for config-only or decommission-time-only updates).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_gpus")]
        public int? NumGpus { get; set; }

        /// <summary>
        /// Timestamp at which the cluster should be decommissioned. Only accepted for prepaid clusters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reservation_end_time")]
        public global::System.DateTime? ReservationEndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cluster_config")]
        public global::Together.InstanceClusterConfig? ClusterConfig { get; set; }

        /// <summary>
        /// Number of reserved GPUs to update to. This field is only applicable for clusters with RESERVED billing type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_reserved_gpus")]
        public int? NumReservedGpus { get; set; }

        /// <summary>
        /// Updated desired number of preemptible GPUs for the cluster. When omitted, the current value is preserved. Must be a multiple of 8.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_preemptible_gpus")]
        public int? NumPreemptibleGpus { get; set; }

        /// <summary>
        /// Add-ons to update on the cluster. Each entry identifies an existing add-on by name and provides the new external config to merge.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_ons")]
        public global::System.Collections.Generic.IList<global::Together.AddOnUpdateRequest>? AddOns { get; set; }

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
        /// Target GPU count for the cluster. When omitted, the server keeps the current GPU count from cluster metadata (use for config-only or decommission-time-only updates).
        /// </param>
        /// <param name="reservationEndTime">
        /// Timestamp at which the cluster should be decommissioned. Only accepted for prepaid clusters.
        /// </param>
        /// <param name="clusterConfig"></param>
        /// <param name="numReservedGpus">
        /// Number of reserved GPUs to update to. This field is only applicable for clusters with RESERVED billing type.
        /// </param>
        /// <param name="numPreemptibleGpus">
        /// Updated desired number of preemptible GPUs for the cluster. When omitted, the current value is preserved. Must be a multiple of 8.
        /// </param>
        /// <param name="addOns">
        /// Add-ons to update on the cluster. Each entry identifies an existing add-on by name and provides the new external config to merge.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GPUClusterUpdateRequest(
            global::Together.GPUClusterUpdateRequestClusterType? clusterType,
            int? numGpus,
            global::System.DateTime? reservationEndTime,
            global::Together.InstanceClusterConfig? clusterConfig,
            int? numReservedGpus,
            int? numPreemptibleGpus,
            global::System.Collections.Generic.IList<global::Together.AddOnUpdateRequest>? addOns)
        {
            this.ClusterType = clusterType;
            this.NumGpus = numGpus;
            this.ReservationEndTime = reservationEndTime;
            this.ClusterConfig = clusterConfig;
            this.NumReservedGpus = numReservedGpus;
            this.NumPreemptibleGpus = numPreemptibleGpus;
            this.AddOns = addOns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GPUClusterUpdateRequest" /> class.
        /// </summary>
        public GPUClusterUpdateRequest()
        {
        }

    }
}