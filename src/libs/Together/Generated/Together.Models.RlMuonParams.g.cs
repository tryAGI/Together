
#nullable enable

namespace Together
{
    /// <summary>
    /// Per-step Muon optimizer overrides
    /// </summary>
    public sealed partial class RlMuonParams
    {
        /// <summary>
        /// Learning rate for this Muon optimizer step.<br/>
        /// Example: 0.02
        /// </summary>
        /// <example>0.02</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("learning_rate")]
        public double? LearningRate { get; set; }

        /// <summary>
        /// Momentum coefficient<br/>
        /// Default Value: 0.95<br/>
        /// Example: 0.95
        /// </summary>
        /// <example>0.95</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("momentum")]
        public double? Momentum { get; set; }

        /// <summary>
        /// Number of Newton-Schulz iterations<br/>
        /// Default Value: 5<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("newton_schulz_steps")]
        public int? NewtonSchulzSteps { get; set; }

        /// <summary>
        /// Weight decay coefficient<br/>
        /// Default Value: 0.0<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight_decay")]
        public double? WeightDecay { get; set; }

        /// <summary>
        /// Maximum gradient norm for this step, gradients across all model parameters are clipped to this value. Set to 0 to disable gradient clipping. When unset, gradients are clipped to the session default (1.0).<br/>
        /// Default Value: 1.0<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("grad_clip_norm")]
        public double? GradClipNorm { get; set; }

        /// <summary>
        /// Per-step Adam optimizer overrides for the Adam-tuned parameters in a Muon-tuned optimizer session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adam")]
        public global::Together.RlAdamParams? Adam { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlMuonParams" /> class.
        /// </summary>
        /// <param name="learningRate">
        /// Learning rate for this Muon optimizer step.<br/>
        /// Example: 0.02
        /// </param>
        /// <param name="momentum">
        /// Momentum coefficient<br/>
        /// Default Value: 0.95<br/>
        /// Example: 0.95
        /// </param>
        /// <param name="newtonSchulzSteps">
        /// Number of Newton-Schulz iterations<br/>
        /// Default Value: 5<br/>
        /// Example: 5
        /// </param>
        /// <param name="weightDecay">
        /// Weight decay coefficient<br/>
        /// Default Value: 0.0<br/>
        /// Example: 0
        /// </param>
        /// <param name="gradClipNorm">
        /// Maximum gradient norm for this step, gradients across all model parameters are clipped to this value. Set to 0 to disable gradient clipping. When unset, gradients are clipped to the session default (1.0).<br/>
        /// Default Value: 1.0<br/>
        /// Example: 10
        /// </param>
        /// <param name="adam">
        /// Per-step Adam optimizer overrides for the Adam-tuned parameters in a Muon-tuned optimizer session.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlMuonParams(
            double? learningRate,
            double? momentum,
            int? newtonSchulzSteps,
            double? weightDecay,
            double? gradClipNorm,
            global::Together.RlAdamParams? adam)
        {
            this.LearningRate = learningRate;
            this.Momentum = momentum;
            this.NewtonSchulzSteps = newtonSchulzSteps;
            this.WeightDecay = weightDecay;
            this.GradClipNorm = gradClipNorm;
            this.Adam = adam;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlMuonParams" /> class.
        /// </summary>
        public RlMuonParams()
        {
        }

    }
}