
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RlOptimStepBody
    {
        /// <summary>
        /// AdamW optimizer parameters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adamw_params")]
        public global::Together.RlAdamWOptimizerParams? AdamwParams { get; set; }

        /// <summary>
        /// Learning rate for this step.<br/>
        /// Default Value: 0.0001<br/>
        /// Example: 0.0001
        /// </summary>
        /// <example>0.0001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("learning_rate")]
        public float? LearningRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlOptimStepBody" /> class.
        /// </summary>
        /// <param name="adamwParams">
        /// AdamW optimizer parameters
        /// </param>
        /// <param name="learningRate">
        /// Learning rate for this step.<br/>
        /// Default Value: 0.0001<br/>
        /// Example: 0.0001
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlOptimStepBody(
            global::Together.RlAdamWOptimizerParams? adamwParams,
            float? learningRate)
        {
            this.AdamwParams = adamwParams;
            this.LearningRate = learningRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlOptimStepBody" /> class.
        /// </summary>
        public RlOptimStepBody()
        {
        }
    }
}