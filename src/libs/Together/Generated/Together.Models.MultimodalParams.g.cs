
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MultimodalParams
    {
        /// <summary>
        /// Whether to train the vision encoder of the model. Only available for multimodal models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("train_vision")]
        public bool? TrainVision { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultimodalParams" /> class.
        /// </summary>
        /// <param name="trainVision">
        /// Whether to train the vision encoder of the model. Only available for multimodal models.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultimodalParams(
            bool? trainVision)
        {
            this.TrainVision = trainVision;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultimodalParams" /> class.
        /// </summary>
        public MultimodalParams()
        {
        }
    }
}