
#nullable enable

namespace Together
{
    /// <summary>
    /// Count of pending jobs canceled by the clear operation.
    /// </summary>
    public sealed partial class QueueClearResponse
    {
        /// <summary>
        /// Number of pending jobs that were canceled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canceled_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CanceledCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueClearResponse" /> class.
        /// </summary>
        /// <param name="canceledCount">
        /// Number of pending jobs that were canceled
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueClearResponse(
            int canceledCount)
        {
            this.CanceledCount = canceledCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueClearResponse" /> class.
        /// </summary>
        public QueueClearResponse()
        {
        }

    }
}