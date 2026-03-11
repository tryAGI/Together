
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RlLossLogprobs
    {
        /// <summary>
        /// Float array of per-token log probabilities<br/>
        /// Example: [-1.2, -0.8]
        /// </summary>
        /// <example>[-1.2, -0.8]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<float> Data { get; set; }

        /// <summary>
        /// Data type of the float array (D_TYPE_FLOAT32 or D_TYPE_BFLOAT16)<br/>
        /// Default Value: D_TYPE_UNSPECIFIED
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dtype")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.RlDTypeJsonConverter))]
        public global::Together.RlDType? Dtype { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlLossLogprobs" /> class.
        /// </summary>
        /// <param name="data">
        /// Float array of per-token log probabilities<br/>
        /// Example: [-1.2, -0.8]
        /// </param>
        /// <param name="dtype">
        /// Data type of the float array (D_TYPE_FLOAT32 or D_TYPE_BFLOAT16)<br/>
        /// Default Value: D_TYPE_UNSPECIFIED
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlLossLogprobs(
            global::System.Collections.Generic.IList<float> data,
            global::Together.RlDType? dtype)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Dtype = dtype;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlLossLogprobs" /> class.
        /// </summary>
        public RlLossLogprobs()
        {
        }
    }
}