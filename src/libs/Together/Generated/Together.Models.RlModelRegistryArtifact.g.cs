
#nullable enable

namespace Together
{
    /// <summary>
    /// A specific revision of a model in the Together model registry
    /// </summary>
    public sealed partial class RlModelRegistryArtifact
    {
        /// <summary>
        /// ID of the model in the Together model registry, as used by the models API<br/>
        /// Example: ml_abc123
        /// </summary>
        /// <example>ml_abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Revision of the model that holds this checkpoint<br/>
        /// Example: rv_def456
        /// </summary>
        /// <example>rv_def456</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RevisionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlModelRegistryArtifact" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the model in the Together model registry, as used by the models API<br/>
        /// Example: ml_abc123
        /// </param>
        /// <param name="revisionId">
        /// Revision of the model that holds this checkpoint<br/>
        /// Example: rv_def456
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlModelRegistryArtifact(
            string id,
            string revisionId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.RevisionId = revisionId ?? throw new global::System.ArgumentNullException(nameof(revisionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlModelRegistryArtifact" /> class.
        /// </summary>
        public RlModelRegistryArtifact()
        {
        }

    }
}