
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueueCancelResponse
    {
        /// <summary>
        /// Job status after the cancel attempt. Only pending jobs can be<br/>
        /// canceled. If the job is already running, done, or failed, the status<br/>
        /// is returned unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.QueueCancelResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.QueueCancelResponseStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueCancelResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// Job status after the cancel attempt. Only pending jobs can be<br/>
        /// canceled. If the job is already running, done, or failed, the status<br/>
        /// is returned unchanged.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueCancelResponse(
            global::Together.QueueCancelResponseStatus status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueCancelResponse" /> class.
        /// </summary>
        public QueueCancelResponse()
        {
        }
    }
}