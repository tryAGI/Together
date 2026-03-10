
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueueCancelRequest
    {
        /// <summary>
        /// Model identifier the job was submitted to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The request ID returned from the submit endpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueCancelRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// Model identifier the job was submitted to
        /// </param>
        /// <param name="requestId">
        /// The request ID returned from the submit endpoint
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueCancelRequest(
            string model,
            string requestId)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueCancelRequest" /> class.
        /// </summary>
        public QueueCancelRequest()
        {
        }
    }
}