
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ClusterPhaseTransition
    {
        /// <summary>
        /// Cluster phase.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phase")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.ClusterPhaseTransitionPhaseJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.ClusterPhaseTransitionPhase Phase { get; set; }

        /// <summary>
        /// Timestamp when the phase transition occurred.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transition_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime TransitionTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterPhaseTransition" /> class.
        /// </summary>
        /// <param name="phase">
        /// Cluster phase.
        /// </param>
        /// <param name="transitionTime">
        /// Timestamp when the phase transition occurred.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClusterPhaseTransition(
            global::Together.ClusterPhaseTransitionPhase phase,
            global::System.DateTime transitionTime)
        {
            this.Phase = phase;
            this.TransitionTime = transitionTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterPhaseTransition" /> class.
        /// </summary>
        public ClusterPhaseTransition()
        {
        }

    }
}