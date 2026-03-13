
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RlLossTargetTokens
    {
        /// <summary>
        /// Integer array of target tokens<br/>
        /// Example: [123, 456, 789]
        /// </summary>
        /// <example>[123, 456, 789]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Data { get; set; }

        /// <summary>
        /// Data type of the integer array<br/>
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
        /// Initializes a new instance of the <see cref="RlLossTargetTokens" /> class.
        /// </summary>
        /// <param name="data">
        /// Integer array of target tokens<br/>
        /// Example: [123, 456, 789]
        /// </param>
        /// <param name="dtype">
        /// Data type of the integer array<br/>
        /// Default Value: D_TYPE_UNSPECIFIED
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlLossTargetTokens(
            global::System.Collections.Generic.IList<string> data,
            global::Together.RlDType? dtype)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Dtype = dtype;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlLossTargetTokens" /> class.
        /// </summary>
        public RlLossTargetTokens()
        {
        }
    }
}