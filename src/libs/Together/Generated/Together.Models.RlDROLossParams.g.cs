
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RlDROLossParams
    {
        /// <summary>
        /// Coefficient on the quadratic log-ratio penalty. Required; there is no default.<br/>
        /// Example: 0.05
        /// </summary>
        /// <example>0.05</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("beta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float Beta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlDROLossParams" /> class.
        /// </summary>
        /// <param name="beta">
        /// Coefficient on the quadratic log-ratio penalty. Required; there is no default.<br/>
        /// Example: 0.05
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlDROLossParams(
            float beta)
        {
            this.Beta = beta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlDROLossParams" /> class.
        /// </summary>
        public RlDROLossParams()
        {
        }

    }
}