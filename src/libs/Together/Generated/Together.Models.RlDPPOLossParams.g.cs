
#nullable enable

namespace Together
{
    /// <summary>
    /// Parameters for DPPO loss. Both probability-change limits must be in [0, 1] and default to 0.15.
    /// </summary>
    public sealed partial class RlDPPOLossParams
    {
        /// <summary>
        /// Probability-change limit for tokens with negative advantage. Measured in probability space, not log-probability space. Must be in [0, 1]. Defaults to 0.15.<br/>
        /// Default Value: 0.15<br/>
        /// Example: 0.15
        /// </summary>
        /// <example>0.15</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta_low")]
        public float? DeltaLow { get; set; }

        /// <summary>
        /// Probability-change limit for tokens with positive advantage. Measured in probability space, not log-probability space. Must be in [0, 1]. Defaults to 0.15.<br/>
        /// Default Value: 0.15<br/>
        /// Example: 0.15
        /// </summary>
        /// <example>0.15</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta_high")]
        public float? DeltaHigh { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlDPPOLossParams" /> class.
        /// </summary>
        /// <param name="deltaLow">
        /// Probability-change limit for tokens with negative advantage. Measured in probability space, not log-probability space. Must be in [0, 1]. Defaults to 0.15.<br/>
        /// Default Value: 0.15<br/>
        /// Example: 0.15
        /// </param>
        /// <param name="deltaHigh">
        /// Probability-change limit for tokens with positive advantage. Measured in probability space, not log-probability space. Must be in [0, 1]. Defaults to 0.15.<br/>
        /// Default Value: 0.15<br/>
        /// Example: 0.15
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlDPPOLossParams(
            float? deltaLow,
            float? deltaHigh)
        {
            this.DeltaLow = deltaLow;
            this.DeltaHigh = deltaHigh;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlDPPOLossParams" /> class.
        /// </summary>
        public RlDPPOLossParams()
        {
        }

    }
}