
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NodePhaseTransition
    {
        /// <summary>
        /// Node phase.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phase")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.NodePhaseTransitionPhaseJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.NodePhaseTransitionPhase Phase { get; set; }

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
        /// Initializes a new instance of the <see cref="NodePhaseTransition" /> class.
        /// </summary>
        /// <param name="phase">
        /// Node phase.
        /// </param>
        /// <param name="transitionTime">
        /// Timestamp when the phase transition occurred.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NodePhaseTransition(
            global::Together.NodePhaseTransitionPhase phase,
            global::System.DateTime transitionTime)
        {
            this.Phase = phase;
            this.TransitionTime = transitionTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodePhaseTransition" /> class.
        /// </summary>
        public NodePhaseTransition()
        {
        }

    }
}