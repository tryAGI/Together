
#nullable enable

namespace Together
{
    /// <summary>
    /// Realized scheduled and ready replica counts for one deployment region.
    /// </summary>
    public sealed partial class DeRegionStatus
    {
        /// <summary>
        /// Region name using the same vocabulary accepted by inline placement regions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// Replicas the scheduler has placed in this region.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduledReplicas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ScheduledReplicas { get; set; }

        /// <summary>
        /// Replicas serving traffic in this region.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readyReplicas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReadyReplicas { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeRegionStatus" /> class.
        /// </summary>
        /// <param name="region">
        /// Region name using the same vocabulary accepted by inline placement regions.
        /// </param>
        /// <param name="scheduledReplicas">
        /// Replicas the scheduler has placed in this region.
        /// </param>
        /// <param name="readyReplicas">
        /// Replicas serving traffic in this region.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeRegionStatus(
            string region,
            int scheduledReplicas,
            int readyReplicas)
        {
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.ScheduledReplicas = scheduledReplicas;
            this.ReadyReplicas = readyReplicas;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeRegionStatus" /> class.
        /// </summary>
        public DeRegionStatus()
        {
        }

    }
}