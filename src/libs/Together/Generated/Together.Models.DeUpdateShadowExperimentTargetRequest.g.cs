
#nullable enable

namespace Together
{
    /// <summary>
    /// Mutable name, deployment, and description for a shadow experiment target.
    /// </summary>
    public sealed partial class DeUpdateShadowExperimentTargetRequest
    {
        /// <summary>
        /// Updated human-readable target name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Replacement deployment under the parent endpoint. It must not be a live traffic-split member or the source or target of an active rollout; traffic-split weight 0 warm-up targets are allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetDeploymentId")]
        public string? TargetDeploymentId { get; set; }

        /// <summary>
        /// Updated free-form target description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

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
        /// Initializes a new instance of the <see cref="DeUpdateShadowExperimentTargetRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Updated human-readable target name.
        /// </param>
        /// <param name="targetDeploymentId">
        /// Replacement deployment under the parent endpoint. It must not be a live traffic-split member or the source or target of an active rollout; traffic-split weight 0 warm-up targets are allowed.
        /// </param>
        /// <param name="description">
        /// Updated free-form target description.
        /// </param>
        /// <param name="etag">
        /// Opaque version tag from a prior read for optimistic concurrency.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeUpdateShadowExperimentTargetRequest(
            string? name,
            string? targetDeploymentId,
            string? description,
            string? etag)
        {
            this.Name = name;
            this.TargetDeploymentId = targetDeploymentId;
            this.Description = description;
            this.Etag = etag;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeUpdateShadowExperimentTargetRequest" /> class.
        /// </summary>
        public DeUpdateShadowExperimentTargetRequest()
        {
        }

    }
}