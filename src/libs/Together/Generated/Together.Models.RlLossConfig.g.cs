
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RlLossConfig
    {
        /// <summary>
        /// Type of loss function to use<br/>
        /// Default Value: LOSS_TYPE_UNSPECIFIED
        /// </summary>
        /// <default>global::Together.RlLossType.LossTypeUnspecified</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.RlLossTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.RlLossType Type { get; set; } = global::Together.RlLossType.LossTypeUnspecified;

        /// <summary>
        /// Cross-entropy loss parameters (currently empty).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cross_entropy_params")]
        public global::Together.RlCrossEntropyLossParams? CrossEntropyParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grpo_params")]
        public global::Together.RlGRPOLossParams? GrpoParams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlLossConfig" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of loss function to use<br/>
        /// Default Value: LOSS_TYPE_UNSPECIFIED
        /// </param>
        /// <param name="crossEntropyParams">
        /// Cross-entropy loss parameters (currently empty).
        /// </param>
        /// <param name="grpoParams"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlLossConfig(
            global::Together.RlLossType type,
            global::Together.RlCrossEntropyLossParams? crossEntropyParams,
            global::Together.RlGRPOLossParams? grpoParams)
        {
            this.Type = type;
            this.CrossEntropyParams = crossEntropyParams;
            this.GrpoParams = grpoParams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlLossConfig" /> class.
        /// </summary>
        public RlLossConfig()
        {
        }
    }
}