
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RlTrainingOperationError
    {
        /// <summary>
        /// Application error code<br/>
        /// Default Value: TRAINING_OPERATION_ERROR_CODE_UNSPECIFIED
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.RlTrainingOperationErrorCodeJsonConverter))]
        public global::Together.RlTrainingOperationErrorCode? Code { get; set; }

        /// <summary>
        /// Human-readable error message<br/>
        /// Example: Operation timed out
        /// </summary>
        /// <example>Operation timed out</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlTrainingOperationError" /> class.
        /// </summary>
        /// <param name="code">
        /// Application error code<br/>
        /// Default Value: TRAINING_OPERATION_ERROR_CODE_UNSPECIFIED
        /// </param>
        /// <param name="message">
        /// Human-readable error message<br/>
        /// Example: Operation timed out
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlTrainingOperationError(
            global::Together.RlTrainingOperationErrorCode? code,
            string? message)
        {
            this.Code = code;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlTrainingOperationError" /> class.
        /// </summary>
        public RlTrainingOperationError()
        {
        }
    }
}