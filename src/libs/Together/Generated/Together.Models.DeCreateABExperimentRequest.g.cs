
#nullable enable

namespace Together
{
    /// <summary>
    /// Configuration for a managed live-traffic split across deployments under one endpoint.
    /// </summary>
    public sealed partial class DeCreateABExperimentRequest
    {
        /// <summary>
        /// Human-readable A/B experiment name, unique within the endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional free-form description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Two to 20 participating deployments with exactly one control. Integer traffic percentages across all members must add up to 100.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.DeABExperimentMember> Members { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeCreateABExperimentRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Human-readable A/B experiment name, unique within the endpoint.
        /// </param>
        /// <param name="members">
        /// Two to 20 participating deployments with exactly one control. Integer traffic percentages across all members must add up to 100.
        /// </param>
        /// <param name="description">
        /// Optional free-form description.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeCreateABExperimentRequest(
            string name,
            global::System.Collections.Generic.IList<global::Together.DeABExperimentMember> members,
            string? description)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Members = members ?? throw new global::System.ArgumentNullException(nameof(members));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeCreateABExperimentRequest" /> class.
        /// </summary>
        public DeCreateABExperimentRequest()
        {
        }

    }
}