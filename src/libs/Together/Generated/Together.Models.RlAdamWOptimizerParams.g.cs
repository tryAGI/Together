
#nullable enable

namespace Together
{
    /// <summary>
    /// AdamW optimizer parameters
    /// </summary>
    public sealed partial class RlAdamWOptimizerParams
    {
        /// <summary>
        /// First moment decay rate<br/>
        /// Default Value: 0.9<br/>
        /// Example: 0.9
        /// </summary>
        /// <example>0.9</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("beta1")]
        public float? Beta1 { get; set; }

        /// <summary>
        /// Second moment decay rate<br/>
        /// Default Value: 0.95<br/>
        /// Example: 0.95
        /// </summary>
        /// <example>0.95</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("beta2")]
        public float? Beta2 { get; set; }

        /// <summary>
        /// Epsilon for numerical stability<br/>
        /// Default Value: 1e-8<br/>
        /// Example: 0.00000001
        /// </summary>
        /// <example>0.00000001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("eps")]
        public float? Eps { get; set; }

        /// <summary>
        /// Weight decay coefficient<br/>
        /// Default Value: 0.1<br/>
        /// Example: 0.1
        /// </summary>
        /// <example>0.1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight_decay")]
        public float? WeightDecay { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlAdamWOptimizerParams" /> class.
        /// </summary>
        /// <param name="beta1">
        /// First moment decay rate<br/>
        /// Default Value: 0.9<br/>
        /// Example: 0.9
        /// </param>
        /// <param name="beta2">
        /// Second moment decay rate<br/>
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
        /// Default Value: 0.1<br/>
        /// Example: 0.1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlAdamWOptimizerParams(
            float? beta1,
            float? beta2,
            float? eps,
            float? weightDecay)
        {
            this.Beta1 = beta1;
            this.Beta2 = beta2;
            this.Eps = eps;
            this.WeightDecay = weightDecay;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlAdamWOptimizerParams" /> class.
        /// </summary>
        public RlAdamWOptimizerParams()
        {
        }
    }
}