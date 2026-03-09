
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueueMetricsResponse
    {
        /// <summary>
        /// Number of jobs currently being processed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages_running")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int MessagesRunning { get; set; } = default!;

        /// <summary>
        /// Number of jobs waiting to be claimed by a worker
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages_waiting")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int MessagesWaiting { get; set; } = default!;

        /// <summary>
        /// Total number of active jobs (waiting + running)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_jobs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int TotalJobs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueMetricsResponse" /> class.
        /// </summary>
        /// <param name="messagesRunning">
        /// Number of jobs currently being processed
        /// </param>
        /// <param name="messagesWaiting">
        /// Number of jobs waiting to be claimed by a worker
        /// </param>
        /// <param name="totalJobs">
        /// Total number of active jobs (waiting + running)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueMetricsResponse(
            int messagesRunning,
            int messagesWaiting,
            int totalJobs)
        {
            this.MessagesRunning = messagesRunning;
            this.MessagesWaiting = messagesWaiting;
            this.TotalJobs = totalJobs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueMetricsResponse" /> class.
        /// </summary>
        public QueueMetricsResponse()
        {
        }
    }
}