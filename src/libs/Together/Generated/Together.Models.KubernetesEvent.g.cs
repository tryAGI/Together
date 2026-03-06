
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KubernetesEvent
    {
        /// <summary>
        /// Action is the action taken or reported by this event
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        public string? Action { get; set; }

        /// <summary>
        /// Count is the number of times this event has occurred
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        /// FirstSeen is the timestamp when this event was first observed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_seen")]
        public string? FirstSeen { get; set; }

        /// <summary>
        /// LastSeen is the timestamp when this event was last observed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_seen")]
        public string? LastSeen { get; set; }

        /// <summary>
        /// Message is a human-readable description of the event
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Reason is a brief machine-readable reason for this event (e.g., "Pulling", "Started", "Failed")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KubernetesEvent" /> class.
        /// </summary>
        /// <param name="action">
        /// Action is the action taken or reported by this event
        /// </param>
        /// <param name="count">
        /// Count is the number of times this event has occurred
        /// </param>
        /// <param name="firstSeen">
        /// FirstSeen is the timestamp when this event was first observed
        /// </param>
        /// <param name="lastSeen">
        /// LastSeen is the timestamp when this event was last observed
        /// </param>
        /// <param name="message">
        /// Message is a human-readable description of the event
        /// </param>
        /// <param name="reason">
        /// Reason is a brief machine-readable reason for this event (e.g., "Pulling", "Started", "Failed")
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KubernetesEvent(
            string? action,
            int? count,
            string? firstSeen,
            string? lastSeen,
            string? message,
            string? reason)
        {
            this.Action = action;
            this.Count = count;
            this.FirstSeen = firstSeen;
            this.LastSeen = lastSeen;
            this.Message = message;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KubernetesEvent" /> class.
        /// </summary>
        public KubernetesEvent()
        {
        }
    }
}