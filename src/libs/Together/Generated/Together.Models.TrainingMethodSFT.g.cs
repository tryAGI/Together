
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrainingMethodSFT
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.TrainingMethodSFTMethodJsonConverter))]
        public global::Together.TrainingMethodSFTMethod Method { get; set; }

        /// <summary>
        /// Whether to mask the user messages in conversational data or prompts in instruction data.<br/>
        /// Default Value: auto
        /// </summary>
        /// <default>global::Together.TrainingMethodSFTTrainOnInputs.Auto</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("train_on_inputs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<bool?, global::Together.TrainingMethodSFTTrainOnInputs?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.OneOf<bool?, global::Together.TrainingMethodSFTTrainOnInputs?> TrainOnInputs { get; set; } = global::Together.TrainingMethodSFTTrainOnInputs.Auto;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingMethodSFT" /> class.
        /// </summary>
        /// <param name="method"></param>
        /// <param name="trainOnInputs">
        /// Whether to mask the user messages in conversational data or prompts in instruction data.<br/>
        /// Default Value: auto
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrainingMethodSFT(
            global::Together.OneOf<bool?, global::Together.TrainingMethodSFTTrainOnInputs?> trainOnInputs,
            global::Together.TrainingMethodSFTMethod method)
        {
            this.TrainOnInputs = trainOnInputs;
            this.Method = method;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingMethodSFT" /> class.
        /// </summary>
        public TrainingMethodSFT()
        {
        }
    }
}