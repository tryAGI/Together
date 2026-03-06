
#nullable enable

namespace Together
{
    /// <summary>
    /// LoRA adapter configuration
    /// </summary>
    public sealed partial class RlLoraConfig
    {
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
        /// Rank of the LoRA adapter<br/>
        /// Default Value: 8<br/>
        /// Example: 8
        /// </summary>
        /// <example>8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("rank")]
        public long? Rank { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlLoraConfig" /> class.
        /// </summary>
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
        /// <param name="rank">
        /// Rank of the LoRA adapter<br/>
        /// Default Value: 8<br/>
        /// Example: 8
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlLoraConfig(
            long? alpha,
            float? dropout,
            long? rank)
        {
            this.Alpha = alpha;
            this.Dropout = dropout;
            this.Rank = rank;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlLoraConfig" /> class.
        /// </summary>
        public RlLoraConfig()
        {
        }
    }
}