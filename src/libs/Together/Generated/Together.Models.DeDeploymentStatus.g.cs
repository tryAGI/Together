
#nullable enable

namespace Together
{
    /// <summary>
    /// Current status of a deployment, derived at read time from internal state.
    /// </summary>
    public sealed partial class DeDeploymentStatus
    {
        /// <summary>
        /// High-level lifecycle state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeDeploymentStatusStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.DeDeploymentStatusState State { get; set; }

        /// <summary>
        /// Total replicas actively serving traffic across all clusters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readyReplicas")]
        public int? ReadyReplicas { get; set; }

        /// <summary>
        /// Human-readable explanation of the current state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Replicas the scheduler has placed on clusters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduledReplicas")]
        public int? ScheduledReplicas { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeDeploymentStatus" /> class.
        /// </summary>
        /// <param name="state">
        /// High-level lifecycle state.
        /// </param>
        /// <param name="message">
        /// Human-readable explanation of the current state.
        /// </param>
        /// <param name="readyReplicas">
        /// Total replicas actively serving traffic across all clusters.
        /// </param>
        /// <param name="scheduledReplicas">
        /// Replicas the scheduler has placed on clusters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeDeploymentStatus(
            global::Together.DeDeploymentStatusState state,
            string message,
            int? readyReplicas,
            int? scheduledReplicas)
        {
            this.State = state;
            this.ReadyReplicas = readyReplicas;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.ScheduledReplicas = scheduledReplicas;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeDeploymentStatus" /> class.
        /// </summary>
        public DeDeploymentStatus()
        {
        }

    }
}