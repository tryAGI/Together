
#nullable enable

namespace Together
{
    /// <summary>
    /// Per-token loss mask (1=compute loss, 0=ignore)
    /// </summary>
    public sealed partial class RlLossMask
    {
        /// <summary>
        /// Integer array of per-token mask values (0s and 1s)<br/>
        /// Example: [0, 0, 1]
        /// </summary>
        /// <example>[0, 0, 1]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.OneOf<string, int?>> Data { get; set; }

        /// <summary>
        /// Data type of the integer array (must be D_TYPE_INT64)<br/>
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
        /// Initializes a new instance of the <see cref="RlLossMask" /> class.
        /// </summary>
        /// <param name="data">
        /// Integer array of per-token mask values (0s and 1s)<br/>
        /// Example: [0, 0, 1]
        /// </param>
        /// <param name="dtype">
        /// Data type of the integer array (must be D_TYPE_INT64)<br/>
        /// Default Value: D_TYPE_UNSPECIFIED
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlLossMask(
            global::System.Collections.Generic.IList<global::Together.OneOf<string, int?>> data,
            global::Together.RlDType? dtype)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Dtype = dtype;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlLossMask" /> class.
        /// </summary>
        public RlLossMask()
        {
        }
    }
}