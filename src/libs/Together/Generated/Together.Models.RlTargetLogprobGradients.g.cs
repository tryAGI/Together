
#nullable enable

namespace Together
{
    /// <summary>
    /// Per-token gradients of the loss with respect to target log-probabilities
    /// </summary>
    public sealed partial class RlTargetLogprobGradients
    {
        /// <summary>
        /// Float array of per-token gradients (d loss / d log p)<br/>
        /// Example: [-0.1, 0.05, -0.08, 0.12, -0.03]
        /// </summary>
        /// <example>[-0.1, 0.05, -0.08, 0.12, -0.03]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> Data { get; set; }

        /// <summary>
        /// Data type of the float array<br/>
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
        /// Initializes a new instance of the <see cref="RlTargetLogprobGradients" /> class.
        /// </summary>
        /// <param name="data">
        /// Float array of per-token gradients (d loss / d log p)<br/>
        /// Example: [-0.1, 0.05, -0.08, 0.12, -0.03]
        /// </param>
        /// <param name="dtype">
        /// Data type of the float array<br/>
        /// Default Value: D_TYPE_UNSPECIFIED
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlTargetLogprobGradients(
            global::System.Collections.Generic.IList<double> data,
            global::Together.RlDType? dtype)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Dtype = dtype;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlTargetLogprobGradients" /> class.
        /// </summary>
        public RlTargetLogprobGradients()
        {
        }

    }
}