
#nullable enable

namespace Together
{
    /// <summary>
    /// Adjusts the likelihood of specific tokens appearing in the generated output.
    /// </summary>
    public sealed partial class CompletionRequestLogitBias
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionRequestLogitBias" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CompletionRequestLogitBias(
 )
        {
        }
    }
}