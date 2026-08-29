
#nullable enable

namespace Together
{
    /// <summary>
    /// Per-step Adam optimizer overrides.
    /// </summary>
    public sealed partial class RlAdamParams
    {
        /// <summary>
        /// Learning rate for the Adam-tuned parameters<br/>
        /// Example: 0.0001
        /// </summary>
        /// <example>0.0001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("learning_rate")]
        public double? LearningRate { get; set; }

        /// <summary>
        /// Exponential decay rate for the first-moment estimate<br/>
        /// Default Value: 0.9<br/>
        /// Example: 0.9
        /// </summary>
        /// <example>0.9</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("beta1")]
        public double? Beta1 { get; set; }

        /// <summary>
        /// Exponential decay rate for the second-moment estimate<br/>
        /// Default Value: 0.95<br/>
        /// Example: 0.95
        /// </summary>
        /// <example>0.95</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("beta2")]
        public double? Beta2 { get; set; }

        /// <summary>
        /// Epsilon for numerical stability<br/>
        /// Default Value: 1e-8<br/>
        /// Example: 0.00000001
        /// </summary>
        /// <example>0.00000001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("eps")]
        public double? Eps { get; set; }

        /// <summary>
        /// Weight decay coefficient<br/>
        /// Default Value: 0<br/>
        /// Example: 0.1
        /// </summary>
        /// <example>0.1</example>
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlAdamParams" /> class.
        /// </summary>
        /// <param name="learningRate">
        /// Learning rate for the Adam-tuned parameters<br/>
        /// Example: 0.0001
        /// </param>
        /// <param name="beta1">
        /// Exponential decay rate for the first-moment estimate<br/>
        /// Default Value: 0.9<br/>
        /// Example: 0.9
        /// </param>
        /// <param name="beta2">
        /// Exponential decay rate for the second-moment estimate<br/>
        /// Default Value: 0.95<br/>
        /// Example: 0.95
        /// </param>
        /// <param name="eps">
        /// Epsilon for numerical stability<br/>
        /// Default Value: 1e-8<br/>
        /// Example: 0.00000001
        /// </param>
        /// <param name="weightDecay">
        /// Weight decay coefficient<br/>
        /// Default Value: 0<br/>
        /// Example: 0.1
        /// </param>
        /// <param name="gradClipNorm">
        /// Maximum gradient norm for this step, gradients across all model parameters are clipped to this value. Set to 0 to disable gradient clipping. When unset, gradients are clipped to the session default (1.0).<br/>
        /// Default Value: 1.0<br/>
        /// Example: 10
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlAdamParams(
            double? learningRate,
            double? beta1,
            double? beta2,
            double? eps,
            double? weightDecay,
            double? gradClipNorm)
        {
            this.LearningRate = learningRate;
            this.Beta1 = beta1;
            this.Beta2 = beta2;
            this.Eps = eps;
            this.WeightDecay = weightDecay;
            this.GradClipNorm = gradClipNorm;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlAdamParams" /> class.
        /// </summary>
        public RlAdamParams()
        {
        }

    }
}