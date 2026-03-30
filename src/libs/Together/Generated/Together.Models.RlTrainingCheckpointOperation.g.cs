
#nullable enable

namespace Together
{
    /// <summary>
    /// Async save training checkpoint operation
    /// </summary>
    public sealed partial class RlTrainingCheckpointOperation
    {
        /// <summary>
        /// Operation ID<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Operation status<br/>
        /// Default Value: TRAINING_OPERATION_STATUS_UNSPECIFIED
        /// </summary>
        /// <default>global::Together.RlTrainingOperationStatus.TrainingOperationStatusUnspecified</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.RlTrainingOperationStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.RlTrainingOperationStatus Status { get; set; } = global::Together.RlTrainingOperationStatus.TrainingOperationStatusUnspecified;

        /// <summary>
        /// Result on success
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::Together.RlTrainingCheckpointResult? Output { get; set; }

        /// <summary>
        /// Error details on failure
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::Together.RlTrainingOperationError? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlTrainingCheckpointOperation" /> class.
        /// </summary>
        /// <param name="id">
        /// Operation ID<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="status">
        /// Operation status<br/>
        /// Default Value: TRAINING_OPERATION_STATUS_UNSPECIFIED
        /// </param>
        /// <param name="output">
        /// Result on success
        /// </param>
        /// <param name="error">
        /// Error details on failure
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlTrainingCheckpointOperation(
            string id,
            global::Together.RlTrainingOperationStatus status,
            global::Together.RlTrainingCheckpointResult? output,
            global::Together.RlTrainingOperationError? error)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.Output = output;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlTrainingCheckpointOperation" /> class.
        /// </summary>
        public RlTrainingCheckpointOperation()
        {
        }
    }
}