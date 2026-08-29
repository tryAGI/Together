
#nullable enable

namespace Together
{
    /// <summary>
    /// One stage of a canary rollout progression.
    /// </summary>
    public sealed partial class DeRolloutStep
    {
        /// <summary>
        /// Required percentage of traffic on the target deployment for this step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traffic")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Traffic { get; set; }

        /// <summary>
        /// Optional explicit target replica count for this step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicas")]
        public int? Replicas { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeRolloutStep" /> class.
        /// </summary>
        /// <param name="traffic">
        /// Required percentage of traffic on the target deployment for this step.
        /// </param>
        /// <param name="replicas">
        /// Optional explicit target replica count for this step.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeRolloutStep(
            int traffic,
            int? replicas)
        {
            this.Traffic = traffic;
            this.Replicas = replicas;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeRolloutStep" /> class.
        /// </summary>
        public DeRolloutStep()
        {
        }

    }
}