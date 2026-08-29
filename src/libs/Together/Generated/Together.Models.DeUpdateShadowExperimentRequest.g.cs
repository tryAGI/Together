
#nullable enable

namespace Together
{
    /// <summary>
    /// Mutable description and source sampling strategy for a shadow experiment.
    /// </summary>
    public sealed partial class DeUpdateShadowExperimentRequest
    {
        /// <summary>
        /// Updated free-form description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Updated endpoint sampling configuration. Source updates require etag in the request body.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public global::Together.DeShadowExperimentSource? Source { get; set; }

        /// <summary>
        /// Opaque version tag from a prior read for optimistic concurrency.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("etag")]
        public string? Etag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeUpdateShadowExperimentRequest" /> class.
        /// </summary>
        /// <param name="description">
        /// Updated free-form description.
        /// </param>
        /// <param name="source">
        /// Updated endpoint sampling configuration. Source updates require etag in the request body.
        /// </param>
        /// <param name="etag">
        /// Opaque version tag from a prior read for optimistic concurrency.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeUpdateShadowExperimentRequest(
            string? description,
            global::Together.DeShadowExperimentSource? source,
            string? etag)
        {
            this.Description = description;
            this.Source = source;
            this.Etag = etag;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeUpdateShadowExperimentRequest" /> class.
        /// </summary>
        public DeUpdateShadowExperimentRequest()
        {
        }

    }
}