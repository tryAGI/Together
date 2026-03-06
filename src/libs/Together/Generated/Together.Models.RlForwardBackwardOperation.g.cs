
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RlForwardBackwardOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::Together.RlTrainingOperationError? Error { get; set; }

        /// <summary>
        /// Operation ID<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::Together.RlForwardBackwardResult? Output { get; set; }

        /// <summary>
        /// Default Value: TRAINING_OPERATION_STATUS_UNSPECIFIED
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.RlTrainingOperationStatusJsonConverter))]
        public global::Together.RlTrainingOperationStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlForwardBackwardOperation" /> class.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="id">
        /// Operation ID<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="output"></param>
        /// <param name="status">
        /// Default Value: TRAINING_OPERATION_STATUS_UNSPECIFIED
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlForwardBackwardOperation(
            global::Together.RlTrainingOperationError? error,
            string? id,
            global::Together.RlForwardBackwardResult? output,
            global::Together.RlTrainingOperationStatus? status)
        {
            this.Error = error;
            this.Id = id;
            this.Output = output;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlForwardBackwardOperation" /> class.
        /// </summary>
        public RlForwardBackwardOperation()
        {
        }
    }
}