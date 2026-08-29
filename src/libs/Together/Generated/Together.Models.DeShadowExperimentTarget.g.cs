
#nullable enable

namespace Together
{
    /// <summary>
    /// Deployment that receives mirrored traffic for a shadow experiment.
    /// </summary>
    public sealed partial class DeShadowExperimentTarget
    {
        /// <summary>
        /// Output only. Unique shadow experiment target identifier.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Output only. Shadow experiment this target belongs to.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimentId")]
        public string ExperimentId { get; set; } = default!;

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
        /// Output only. Timestamp when the target was created.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Output only. Timestamp when the target was last updated.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Opaque version tag for optimistic concurrency control. Returned on read; set it on update or delete requests for consistent read-modify-write.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("etag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Etag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeShadowExperimentTarget" /> class.
        /// </summary>
        /// <param name="name">
        /// Human-readable target name, unique within the shadow experiment. At most 256 characters.
        /// </param>
        /// <param name="targetDeploymentId">
        /// Deployment under the parent endpoint that receives mirrored traffic. It must not be a live traffic-split member or the source or target of an active rollout; traffic-split weight 0 warm-up targets are allowed.
        /// </param>
        /// <param name="etag">
        /// Opaque version tag for optimistic concurrency control. Returned on read; set it on update or delete requests for consistent read-modify-write.
        /// </param>
        /// <param name="description">
        /// Optional free-form target description.
        /// </param>
        /// <param name="id">
        /// Output only. Unique shadow experiment target identifier.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="experimentId">
        /// Output only. Shadow experiment this target belongs to.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// Output only. Timestamp when the target was created.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// Output only. Timestamp when the target was last updated.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeShadowExperimentTarget(
            string name,
            string targetDeploymentId,
            string etag,
            string? description,
            string id = default!,
            string experimentId = default!,
            global::System.DateTime createdAt = default!,
            global::System.DateTime updatedAt = default!)
        {
            this.Id = id;
            this.ExperimentId = experimentId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.TargetDeploymentId = targetDeploymentId ?? throw new global::System.ArgumentNullException(nameof(targetDeploymentId));
            this.Description = description;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Etag = etag ?? throw new global::System.ArgumentNullException(nameof(etag));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeShadowExperimentTarget" /> class.
        /// </summary>
        public DeShadowExperimentTarget()
        {
        }

    }
}