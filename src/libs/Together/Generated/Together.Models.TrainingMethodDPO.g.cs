
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
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dpo_normalize_logratios_by_length")]
        public bool? DpoNormalizeLogratiosByLength { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dpo_reference_free")]
        public bool? DpoReferenceFree { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.TrainingMethodDPOMethodJsonConverter))]
        public global::Together.TrainingMethodDPOMethod Method { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rpo_alpha")]
        public float? RpoAlpha { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("simpo_gamma")]
        public float? SimpoGamma { get; set; }

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
        /// <param name="dpoNormalizeLogratiosByLength">
        /// Default Value: false
        /// </param>
        /// <param name="dpoReferenceFree">
        /// Default Value: false
        /// </param>
        /// <param name="method"></param>
        /// <param name="rpoAlpha">
        /// Default Value: 0F
        /// </param>
        /// <param name="simpoGamma">
        /// Default Value: 0F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrainingMethodDPO(
            float? dpoBeta,
            bool? dpoNormalizeLogratiosByLength,
            bool? dpoReferenceFree,
            global::Together.TrainingMethodDPOMethod method,
            float? rpoAlpha,
            float? simpoGamma)
        {
            this.DpoBeta = dpoBeta;
            this.DpoNormalizeLogratiosByLength = dpoNormalizeLogratiosByLength;
            this.DpoReferenceFree = dpoReferenceFree;
            this.Method = method;
            this.RpoAlpha = rpoAlpha;
            this.SimpoGamma = simpoGamma;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingMethodDPO" /> class.
        /// </summary>
        public TrainingMethodDPO()
        {
        }
    }
}