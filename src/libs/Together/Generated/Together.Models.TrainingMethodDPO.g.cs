
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrainingMethodDPO
    {
        /// <summary>
        /// Default Value: 0.1F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dpo_beta")]
        public float? DpoBeta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.TrainingMethodDPOMethodJsonConverter))]
        public global::Together.TrainingMethodDPOMethod Method { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingMethodDPO" /> class.
        /// </summary>
        /// <param name="dpoBeta">
        /// Default Value: 0.1F
        /// </param>
        /// <param name="method"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrainingMethodDPO(
            float? dpoBeta,
            global::Together.TrainingMethodDPOMethod method)
        {
            this.DpoBeta = dpoBeta;
            this.Method = method;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingMethodDPO" /> class.
        /// </summary>
        public TrainingMethodDPO()
        {
        }
    }
}