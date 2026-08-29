
#nullable enable

namespace Together
{
    /// <summary>
    /// Certification result for a model, config, and optional draft-model combination.
    /// </summary>
    public sealed partial class DeCertification
    {
        /// <summary>
        /// Product or serving environment for which the combination was evaluated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeCertificationTargetJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.DeCertificationTarget Target { get; set; }

        /// <summary>
        /// Whether the model and config combination passed certification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("certificationType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeCertificationCertificationTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.DeCertificationCertificationType CertificationType { get; set; }

        /// <summary>
        /// Time when the certification decision was recorded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("certifiedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CertifiedAt { get; set; }

        /// <summary>
        /// Service or reviewer that recorded the certification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("certifiedBy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CertifiedBy { get; set; }

        /// <summary>
        /// Human-readable certification notes or limitations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notes")]
        public string? Notes { get; set; }

        /// <summary>
        /// Resource name of the certified model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Revision identifier of the certified model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelRevisionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelRevisionId { get; set; }

        /// <summary>
        /// Resource name of the certified draft model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("draftModel")]
        public string? DraftModel { get; set; }

        /// <summary>
        /// Revision identifier of the certified draft model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("draftModelRevisionId")]
        public string? DraftModelRevisionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeCertification" /> class.
        /// </summary>
        /// <param name="target">
        /// Product or serving environment for which the combination was evaluated.
        /// </param>
        /// <param name="certificationType">
        /// Whether the model and config combination passed certification.
        /// </param>
        /// <param name="certifiedAt">
        /// Time when the certification decision was recorded.
        /// </param>
        /// <param name="certifiedBy">
        /// Service or reviewer that recorded the certification.
        /// </param>
        /// <param name="model">
        /// Resource name of the certified model.
        /// </param>
        /// <param name="modelRevisionId">
        /// Revision identifier of the certified model.
        /// </param>
        /// <param name="notes">
        /// Human-readable certification notes or limitations.
        /// </param>
        /// <param name="draftModel">
        /// Resource name of the certified draft model.
        /// </param>
        /// <param name="draftModelRevisionId">
        /// Revision identifier of the certified draft model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeCertification(
            global::Together.DeCertificationTarget target,
            global::Together.DeCertificationCertificationType certificationType,
            global::System.DateTime certifiedAt,
            string certifiedBy,
            string model,
            string modelRevisionId,
            string? notes,
            string? draftModel,
            string? draftModelRevisionId)
        {
            this.Target = target;
            this.CertificationType = certificationType;
            this.CertifiedAt = certifiedAt;
            this.CertifiedBy = certifiedBy ?? throw new global::System.ArgumentNullException(nameof(certifiedBy));
            this.Notes = notes;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.ModelRevisionId = modelRevisionId ?? throw new global::System.ArgumentNullException(nameof(modelRevisionId));
            this.DraftModel = draftModel;
            this.DraftModelRevisionId = draftModelRevisionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeCertification" /> class.
        /// </summary>
        public DeCertification()
        {
        }

    }
}