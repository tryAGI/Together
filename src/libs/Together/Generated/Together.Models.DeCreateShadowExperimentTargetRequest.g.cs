
#nullable enable

namespace Together
{
    /// <summary>
    /// Deployment under the parent endpoint that should receive mirrored requests from a shadow experiment.
    /// </summary>
    public sealed partial class DeCreateShadowExperimentTargetRequest
    {
        /// <summary>
        /// Human-readable target name, unique within the shadow experiment. At most 256 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Deployment under the parent endpoint that receives mirrored traffic. It must not be a live traffic-split member or the source or target of an active rollout; traffic-split weight 0 warm-up targets are allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetDeploymentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetDeploymentId { get; set; }

        /// <summary>
        /// Optional free-form target description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeCreateShadowExperimentTargetRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Human-readable target name, unique within the shadow experiment. At most 256 characters.
        /// </param>
        /// <param name="targetDeploymentId">
        /// Deployment under the parent endpoint that receives mirrored traffic. It must not be a live traffic-split member or the source or target of an active rollout; traffic-split weight 0 warm-up targets are allowed.
        /// </param>
        /// <param name="description">
        /// Optional free-form target description.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeCreateShadowExperimentTargetRequest(
            string name,
            string targetDeploymentId,
            string? description)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.TargetDeploymentId = targetDeploymentId ?? throw new global::System.ArgumentNullException(nameof(targetDeploymentId));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeCreateShadowExperimentTargetRequest" /> class.
        /// </summary>
        public DeCreateShadowExperimentTargetRequest()
        {
        }

    }
}