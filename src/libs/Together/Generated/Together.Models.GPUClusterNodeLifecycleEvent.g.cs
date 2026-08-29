
#nullable enable

namespace Together
{
    /// <summary>
    /// Node lifecycle event included in a GPU cluster timeline.
    /// </summary>
    public sealed partial class GPUClusterNodeLifecycleEvent
    {
        /// <summary>
        /// Tenant node name this lifecycle event applies to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// Lifecycle event reason, for example TogetherScaledUp, TogetherScaledDown, or TogetherPreempted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reason { get; set; }

        /// <summary>
        /// Human-readable lifecycle event message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Event timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GPUClusterNodeLifecycleEvent" /> class.
        /// </summary>
        /// <param name="nodeId">
        /// Tenant node name this lifecycle event applies to.
        /// </param>
        /// <param name="reason">
        /// Lifecycle event reason, for example TogetherScaledUp, TogetherScaledDown, or TogetherPreempted.
        /// </param>
        /// <param name="message">
        /// Human-readable lifecycle event message.
        /// </param>
        /// <param name="timestamp">
        /// Event timestamp.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GPUClusterNodeLifecycleEvent(
            string nodeId,
            string reason,
            string message,
            global::System.DateTime timestamp)
        {
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GPUClusterNodeLifecycleEvent" /> class.
        /// </summary>
        public GPUClusterNodeLifecycleEvent()
        {
        }

    }
}