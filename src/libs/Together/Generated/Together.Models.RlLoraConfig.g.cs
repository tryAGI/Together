
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
        /// Default Value: 32<br/>
        /// Example: 32
        /// </summary>
        /// <example>32</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("rank")]
        public int? Rank { get; set; }

        /// <summary>
        /// Alpha of the LoRA adapter<br/>
        /// Default Value: 64<br/>
        /// Example: 64
        /// </summary>
        /// <example>64</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("alpha")]
        public int? Alpha { get; set; }

        /// <summary>
        /// Dropout of the LoRA adapter<br/>
        /// Default Value: 0.0<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dropout")]
        public double? Dropout { get; set; }

        /// <summary>
        /// Random seed for initializing LoRA adapter weights. Ignored when LoRA is disabled or the session resumes from a checkpoint.<br/>
        /// Example: 59
        /// </summary>
        /// <example>59</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<string, int?>))]
        public global::Together.OneOf<string, int?>? Seed { get; set; }

        /// <summary>
        /// Whether to also train a LoRA adapter on the output head. Defaults to true.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("train_unembed")]
        public bool? TrainUnembed { get; set; }

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
        /// Default Value: 32<br/>
        /// Example: 32
        /// </param>
        /// <param name="alpha">
        /// Alpha of the LoRA adapter<br/>
        /// Default Value: 64<br/>
        /// Example: 64
        /// </param>
        /// <param name="dropout">
        /// Dropout of the LoRA adapter<br/>
        /// Default Value: 0.0<br/>
        /// Example: 0
        /// </param>
        /// <param name="seed">
        /// Random seed for initializing LoRA adapter weights. Ignored when LoRA is disabled or the session resumes from a checkpoint.<br/>
        /// Example: 59
        /// </param>
        /// <param name="trainUnembed">
        /// Whether to also train a LoRA adapter on the output head. Defaults to true.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlLoraConfig(
            int? rank,
            int? alpha,
            double? dropout,
            global::Together.OneOf<string, int?>? seed,
            bool? trainUnembed)
        {
            this.Rank = rank;
            this.Alpha = alpha;
            this.Dropout = dropout;
            this.Seed = seed;
            this.TrainUnembed = trainUnembed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlLoraConfig" /> class.
        /// </summary>
        public RlLoraConfig()
        {
        }

    }
}