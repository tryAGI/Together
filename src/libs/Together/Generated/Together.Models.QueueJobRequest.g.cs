
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueueJobRequest
    {
        /// <summary>
        /// Arbitrary JSON metadata stored with the job and returned in status<br/>
        /// responses. The model and system may add or update keys during<br/>
        /// processing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("info")]
        public object? Info { get; set; }

        /// <summary>
        /// Required model identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Freeform model input. Passed unchanged to the model. Contents are model-specific.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Payload { get; set; }

        /// <summary>
        /// Job priority. Higher values are processed first (strict priority<br/>
        /// ordering). Jobs with equal priority are processed in submission<br/>
        /// order (FIFO).<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueJobRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// Required model identifier
        /// </param>
        /// <param name="payload">
        /// Freeform model input. Passed unchanged to the model. Contents are model-specific.
        /// </param>
        /// <param name="info">
        /// Arbitrary JSON metadata stored with the job and returned in status<br/>
        /// responses. The model and system may add or update keys during<br/>
        /// processing.
        /// </param>
        /// <param name="priority">
        /// Job priority. Higher values are processed first (strict priority<br/>
        /// ordering). Jobs with equal priority are processed in submission<br/>
        /// order (FIFO).<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueJobRequest(
            string model,
            object payload,
            object? info,
            int? priority)
        {
            this.Info = info;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
            this.Priority = priority;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueJobRequest" /> class.
        /// </summary>
        public QueueJobRequest()
        {
        }
    }
}