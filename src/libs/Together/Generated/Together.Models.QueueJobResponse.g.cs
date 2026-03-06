
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueueJobResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::Together.QueueError? Error { get; set; }

        /// <summary>
        /// Unique identifier for the submitted job. Use this to poll status or cancel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueJobResponse" /> class.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="requestId">
        /// Unique identifier for the submitted job. Use this to poll status or cancel.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueJobResponse(
            global::Together.QueueError? error,
            string? requestId)
        {
            this.Error = error;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueJobResponse" /> class.
        /// </summary>
        public QueueJobResponse()
        {
        }
    }
}