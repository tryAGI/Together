
#nullable enable

namespace Together
{
    /// <summary>
    /// Response returned after queueing a job.
    /// </summary>
    public sealed partial class QueueJobResponse
    {
        /// <summary>
        /// Unique identifier for the submitted job. Use this to poll status or cancel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueJobResponse" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Unique identifier for the submitted job. Use this to poll status or cancel.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueJobResponse(
            string requestId)
        {
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueJobResponse" /> class.
        /// </summary>
        public QueueJobResponse()
        {
        }

    }
}