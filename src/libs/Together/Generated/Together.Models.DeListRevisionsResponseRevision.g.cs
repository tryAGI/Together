
#nullable enable

namespace Together
{
    /// <summary>
    /// Revision metadata for a volume object.
    /// </summary>
    public sealed partial class DeListRevisionsResponseRevision
    {
        /// <summary>
        /// Revision identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revisionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RevisionId { get; set; }

        /// <summary>
        /// Timestamp when the revision was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Current validation status for the revision.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validationStatus")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeListRevisionsResponseRevisionValidationStatusJsonConverter))]
        public global::Together.DeListRevisionsResponseRevisionValidationStatus? ValidationStatus { get; set; }

        /// <summary>
        /// Timestamp when validation most recently ran for the revision.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastValidatedAt")]
        public global::System.DateTime? LastValidatedAt { get; set; }

        /// <summary>
        /// Validation errors reported for the revision.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validationErrors")]
        public global::System.Collections.Generic.IList<global::Together.DeRevisionValidationError>? ValidationErrors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeListRevisionsResponseRevision" /> class.
        /// </summary>
        /// <param name="revisionId">
        /// Revision identifier.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the revision was created.
        /// </param>
        /// <param name="validationStatus">
        /// Current validation status for the revision.
        /// </param>
        /// <param name="lastValidatedAt">
        /// Timestamp when validation most recently ran for the revision.
        /// </param>
        /// <param name="validationErrors">
        /// Validation errors reported for the revision.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeListRevisionsResponseRevision(
            string revisionId,
            global::System.DateTime createdAt,
            global::Together.DeListRevisionsResponseRevisionValidationStatus? validationStatus,
            global::System.DateTime? lastValidatedAt,
            global::System.Collections.Generic.IList<global::Together.DeRevisionValidationError>? validationErrors)
        {
            this.RevisionId = revisionId ?? throw new global::System.ArgumentNullException(nameof(revisionId));
            this.CreatedAt = createdAt;
            this.ValidationStatus = validationStatus;
            this.LastValidatedAt = lastValidatedAt;
            this.ValidationErrors = validationErrors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeListRevisionsResponseRevision" /> class.
        /// </summary>
        public DeListRevisionsResponseRevision()
        {
        }

    }
}