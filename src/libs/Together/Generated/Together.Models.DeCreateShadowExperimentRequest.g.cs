
#nullable enable

namespace Together
{
    /// <summary>
    /// Sampling strategy and optional initial targets for mirroring endpoint requests without affecting client responses.
    /// </summary>
    public sealed partial class DeCreateShadowExperimentRequest
    {
        /// <summary>
        /// Human-readable shadow experiment name, unique within the endpoint. At most 256 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Endpoint source and sampling configuration for the experiment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.DeShadowExperimentSource Source { get; set; }

        /// <summary>
        /// Optional initial target deployments. At most 100 targets; manage later changes through the target APIs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        public global::System.Collections.Generic.IList<global::Together.DeCreateShadowExperimentTargetRequest>? Targets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeCreateShadowExperimentRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Human-readable shadow experiment name, unique within the endpoint. At most 256 characters.
        /// </param>
        /// <param name="source">
        /// Endpoint source and sampling configuration for the experiment.
        /// </param>
        /// <param name="targets">
        /// Optional initial target deployments. At most 100 targets; manage later changes through the target APIs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeCreateShadowExperimentRequest(
            string name,
            global::Together.DeShadowExperimentSource source,
            global::System.Collections.Generic.IList<global::Together.DeCreateShadowExperimentTargetRequest>? targets)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Targets = targets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeCreateShadowExperimentRequest" /> class.
        /// </summary>
        public DeCreateShadowExperimentRequest()
        {
        }

    }
}