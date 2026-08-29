
#nullable enable

namespace Together
{
    /// <summary>
    /// Canary strategy configuration for gradual traffic progression. An empty config uses the default 5, 25, 50, 100 percent ladder; over a frozen traffic-split pair left by cancel, the default ladder is derived at start from the pair's current served share so it begins above it.
    /// </summary>
    public sealed partial class DeCanaryConfig
    {
        /// <summary>
        /// Optional progression steps. Defaults to 5, 25, 50, 100 percent when empty; explicit steps must increase and end at 100 percent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public global::System.Collections.Generic.IList<global::Together.DeRolloutStep>? Steps { get; set; }

        /// <summary>
        /// Optional positive soak between steps. Defaults to 3m if omitted, and grows to cover metric rule windows plus ingestion lag.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stepInterval")]
        public string? StepInterval { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeCanaryConfig" /> class.
        /// </summary>
        /// <param name="steps">
        /// Optional progression steps. Defaults to 5, 25, 50, 100 percent when empty; explicit steps must increase and end at 100 percent.
        /// </param>
        /// <param name="stepInterval">
        /// Optional positive soak between steps. Defaults to 3m if omitted, and grows to cover metric rule windows plus ingestion lag.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeCanaryConfig(
            global::System.Collections.Generic.IList<global::Together.DeRolloutStep>? steps,
            string? stepInterval)
        {
            this.Steps = steps;
            this.StepInterval = stepInterval;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeCanaryConfig" /> class.
        /// </summary>
        public DeCanaryConfig()
        {
        }

    }
}