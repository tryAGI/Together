
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RlInferenceCheckpointOperation
    {
        /// <summary>
        /// Operation ID<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Operation status<br/>
        /// Default Value: TRAINING_OPERATION_STATUS_UNSPECIFIED
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.RlTrainingOperationStatusJsonConverter))]
        public global::Together.RlTrainingOperationStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::Together.RlInferenceCheckpointResult? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::Together.RlTrainingOperationError? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlInferenceCheckpointOperation" /> class.
        /// </summary>
        /// <param name="id">
        /// Operation ID<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="status">
        /// Operation status<br/>
        /// Default Value: TRAINING_OPERATION_STATUS_UNSPECIFIED
        /// </param>
        /// <param name="output"></param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlInferenceCheckpointOperation(
            string? id,
            global::Together.RlTrainingOperationStatus? status,
            global::Together.RlInferenceCheckpointResult? output,
            global::Together.RlTrainingOperationError? error)
        {
            this.Id = id;
            this.Status = status;
            this.Output = output;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlInferenceCheckpointOperation" /> class.
        /// </summary>
        public RlInferenceCheckpointOperation()
        {
        }
    }
}