
#nullable enable

namespace Together
{
    /// <summary>
    /// Immutable, user-facing configuration revision that defines how a compatible model runs, including engine and hardware selectors.
    /// </summary>
    public sealed partial class DeModelConfig
    {
        /// <summary>
        /// Config revision identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Model, hardware, and runtime combinations certified for this config revision.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("certifications")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.DeCertification> Certifications { get; set; }

        /// <summary>
        /// Deprecated. Use `referenceModel`. Reference model identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceModelId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReferenceModelId { get; set; }

        /// <summary>
        /// Hardware and runtime selectors used to place and configure replicas.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selectors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.DeSelector> Selectors { get; set; }

        /// <summary>
        /// ID of the project that owns the config revision. Public configs may be owned by a different project than the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Resource name of the referenced model, using `projects/{modelProject}/models/{modelId}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceModel")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReferenceModel { get; set; }

        /// <summary>
        /// Resource name of the draft model, using `projects/{draftProject}/models/{modelId}`; empty when speculative decoding is not enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("draftModel")]
        public string? DraftModel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeModelConfig" /> class.
        /// </summary>
        /// <param name="id">
        /// Config revision identifier.
        /// </param>
        /// <param name="certifications">
        /// Model, hardware, and runtime combinations certified for this config revision.
        /// </param>
        /// <param name="referenceModelId">
        /// Deprecated. Use `referenceModel`. Reference model identifier.
        /// </param>
        /// <param name="selectors">
        /// Hardware and runtime selectors used to place and configure replicas.
        /// </param>
        /// <param name="projectId">
        /// ID of the project that owns the config revision. Public configs may be owned by a different project than the deployment.
        /// </param>
        /// <param name="referenceModel">
        /// Resource name of the referenced model, using `projects/{modelProject}/models/{modelId}`.
        /// </param>
        /// <param name="draftModel">
        /// Resource name of the draft model, using `projects/{draftProject}/models/{modelId}`; empty when speculative decoding is not enabled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeModelConfig(
            string id,
            global::System.Collections.Generic.IList<global::Together.DeCertification> certifications,
            string referenceModelId,
            global::System.Collections.Generic.IList<global::Together.DeSelector> selectors,
            string projectId,
            string referenceModel,
            string? draftModel)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Certifications = certifications ?? throw new global::System.ArgumentNullException(nameof(certifications));
            this.ReferenceModelId = referenceModelId ?? throw new global::System.ArgumentNullException(nameof(referenceModelId));
            this.Selectors = selectors ?? throw new global::System.ArgumentNullException(nameof(selectors));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ReferenceModel = referenceModel ?? throw new global::System.ArgumentNullException(nameof(referenceModel));
            this.DraftModel = draftModel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeModelConfig" /> class.
        /// </summary>
        public DeModelConfig()
        {
        }

    }
}