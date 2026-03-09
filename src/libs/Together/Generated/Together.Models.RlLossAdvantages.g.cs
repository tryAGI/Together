
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RlLossAdvantages
    {
        /// <summary>
        /// Float array of per-token advantages<br/>
        /// Example: [0.5, 0.5]
        /// </summary>
        /// <example>[0.5, 0.5]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<float> Data { get; set; } = default!;

        /// <summary>
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
        /// Initializes a new instance of the <see cref="RlLossAdvantages" /> class.
        /// </summary>
        /// <param name="data">
        /// Float array of per-token advantages<br/>
        /// Example: [0.5, 0.5]
        /// </param>
        /// <param name="dtype">
        /// Default Value: D_TYPE_UNSPECIFIED
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlLossAdvantages(
            global::System.Collections.Generic.IList<float> data,
            global::Together.RlDType? dtype)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Dtype = dtype;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlLossAdvantages" /> class.
        /// </summary>
        public RlLossAdvantages()
        {
        }
    }
}