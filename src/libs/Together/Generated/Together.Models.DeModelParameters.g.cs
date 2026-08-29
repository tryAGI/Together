
#nullable enable

namespace Together
{
    /// <summary>
    /// Model parameter count and precision breakdown.
    /// </summary>
    public sealed partial class DeModelParameters
    {
        /// <summary>
        /// Total number of parameters in the model weights.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Total { get; set; }

        /// <summary>
        /// Parameter counts grouped by numerical data type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("byDtype")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.DeModelDTypeCount> ByDtype { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeModelParameters" /> class.
        /// </summary>
        /// <param name="total">
        /// Total number of parameters in the model weights.
        /// </param>
        /// <param name="byDtype">
        /// Parameter counts grouped by numerical data type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeModelParameters(
            string total,
            global::System.Collections.Generic.IList<global::Together.DeModelDTypeCount> byDtype)
        {
            this.Total = total ?? throw new global::System.ArgumentNullException(nameof(total));
            this.ByDtype = byDtype ?? throw new global::System.ArgumentNullException(nameof(byDtype));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeModelParameters" /> class.
        /// </summary>
        public DeModelParameters()
        {
        }

    }
}