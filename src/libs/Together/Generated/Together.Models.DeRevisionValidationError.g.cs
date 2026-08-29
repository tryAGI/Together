
#nullable enable

namespace Together
{
    /// <summary>
    /// One validation error reported for a model revision.
    /// </summary>
    public sealed partial class DeRevisionValidationError
    {
        /// <summary>
        /// Validation rule that produced the error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rule")]
        public string? Rule { get; set; }

        /// <summary>
        /// Severity level reported by the validation rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        public string? Severity { get; set; }

        /// <summary>
        /// Human-readable validation error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeRevisionValidationError" /> class.
        /// </summary>
        /// <param name="rule">
        /// Validation rule that produced the error.
        /// </param>
        /// <param name="severity">
        /// Severity level reported by the validation rule.
        /// </param>
        /// <param name="message">
        /// Human-readable validation error message.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeRevisionValidationError(
            string? rule,
            string? severity,
            string? message)
        {
            this.Rule = rule;
            this.Severity = severity;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeRevisionValidationError" /> class.
        /// </summary>
        public DeRevisionValidationError()
        {
        }

    }
}