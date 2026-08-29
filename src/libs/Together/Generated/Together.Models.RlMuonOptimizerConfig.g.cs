
#nullable enable

namespace Together
{
    /// <summary>
    /// Advanced configuration for the Muon optimizer.
    /// </summary>
    public sealed partial class RlMuonOptimizerConfig
    {
        /// <summary>
        /// Scaling strategy for the Muon optimizer.<br/>
        /// Default Value: MUON_SCALING_STRATEGY_MATCH_ADAMW
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scaling_strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.RlMuonScalingStrategyJsonConverter))]
        public global::Together.RlMuonScalingStrategy? ScalingStrategy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlMuonOptimizerConfig" /> class.
        /// </summary>
        /// <param name="scalingStrategy">
        /// Scaling strategy for the Muon optimizer.<br/>
        /// Default Value: MUON_SCALING_STRATEGY_MATCH_ADAMW
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlMuonOptimizerConfig(
            global::Together.RlMuonScalingStrategy? scalingStrategy)
        {
            this.ScalingStrategy = scalingStrategy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlMuonOptimizerConfig" /> class.
        /// </summary>
        public RlMuonOptimizerConfig()
        {
        }

    }
}