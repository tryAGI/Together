
#nullable enable

namespace Together
{
    /// <summary>
    /// LoRA adapter configuration
    /// </summary>
    public sealed partial class RlLoraConfig
    {
        /// <summary>
        /// Rank of the LoRA adapter<br/>
        /// Default Value: 8<br/>
        /// Example: 8
        /// </summary>
        /// <example>8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("rank")]
        public long? Rank { get; set; }

        /// <summary>
        /// Alpha of the LoRA adapter<br/>
        /// Default Value: 16<br/>
        /// Example: 16
        /// </summary>
        /// <example>16</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("alpha")]
        public long? Alpha { get; set; }

        /// <summary>
        /// Dropout of the LoRA adapter<br/>
        /// Default Value: 0.05<br/>
        /// Example: 0.05
        /// </summary>
        /// <example>0.05</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dropout")]
        public float? Dropout { get; set; }

        /// <summary>
        /// Whether to enable LoRA fine-tuning. If false, full fine-tuning is used.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable")]
        public bool? Enable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlLoraConfig" /> class.
        /// </summary>
        /// <param name="rank">
        /// Rank of the LoRA adapter<br/>
        /// Default Value: 8<br/>
        /// Example: 8
        /// </param>
        /// <param name="alpha">
        /// Alpha of the LoRA adapter<br/>
        /// Default Value: 16<br/>
        /// Example: 16
        /// </param>
        /// <param name="dropout">
        /// Dropout of the LoRA adapter<br/>
        /// Default Value: 0.05<br/>
        /// Example: 0.05
        /// </param>
        /// <param name="enable">
        /// Whether to enable LoRA fine-tuning. If false, full fine-tuning is used.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlLoraConfig(
            long? rank,
            long? alpha,
            float? dropout,
            bool? enable)
        {
            this.Rank = rank;
            this.Alpha = alpha;
            this.Dropout = dropout;
            this.Enable = enable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlLoraConfig" /> class.
        /// </summary>
        public RlLoraConfig()
        {
        }

    }
}