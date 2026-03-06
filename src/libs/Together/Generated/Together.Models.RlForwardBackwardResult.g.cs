
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RlForwardBackwardResult
    {
        /// <summary>
        /// Loss value<br/>
        /// Example: 2.345
        /// </summary>
        /// <example>2.345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("loss")]
        public double? Loss { get; set; }

        /// <summary>
        /// Loss-specific metrics (e.g., KL divergence, clip fraction for GRPO)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        public global::System.Collections.Generic.Dictionary<string, double>? Metrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlForwardBackwardResult" /> class.
        /// </summary>
        /// <param name="loss">
        /// Loss value<br/>
        /// Example: 2.345
        /// </param>
        /// <param name="metrics">
        /// Loss-specific metrics (e.g., KL divergence, clip fraction for GRPO)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlForwardBackwardResult(
            double? loss,
            global::System.Collections.Generic.Dictionary<string, double>? metrics)
        {
            this.Loss = loss;
            this.Metrics = metrics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlForwardBackwardResult" /> class.
        /// </summary>
        public RlForwardBackwardResult()
        {
        }
    }
}