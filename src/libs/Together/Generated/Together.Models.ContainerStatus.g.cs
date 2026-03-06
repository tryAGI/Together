
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContainerStatus
    {
        /// <summary>
        /// FinishedAt is the timestamp when the container finished execution (if terminated)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finishedAt")]
        public string? FinishedAt { get; set; }

        /// <summary>
        /// Message provides a human-readable message with details about the container's status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Name is the name of the container
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Reason provides a brief machine-readable reason for the container's current status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// StartedAt is the timestamp when the container started execution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedAt")]
        public string? StartedAt { get; set; }

        /// <summary>
        /// Status is the current state of the container (e.g., "Running", "Terminated", "Waiting")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerStatus" /> class.
        /// </summary>
        /// <param name="finishedAt">
        /// FinishedAt is the timestamp when the container finished execution (if terminated)
        /// </param>
        /// <param name="message">
        /// Message provides a human-readable message with details about the container's status
        /// </param>
        /// <param name="name">
        /// Name is the name of the container
        /// </param>
        /// <param name="reason">
        /// Reason provides a brief machine-readable reason for the container's current status
        /// </param>
        /// <param name="startedAt">
        /// StartedAt is the timestamp when the container started execution
        /// </param>
        /// <param name="status">
        /// Status is the current state of the container (e.g., "Running", "Terminated", "Waiting")
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContainerStatus(
            string? finishedAt,
            string? message,
            string? name,
            string? reason,
            string? startedAt,
            string? status)
        {
            this.FinishedAt = finishedAt;
            this.Message = message;
            this.Name = name;
            this.Reason = reason;
            this.StartedAt = startedAt;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerStatus" /> class.
        /// </summary>
        public ContainerStatus()
        {
        }
    }
}