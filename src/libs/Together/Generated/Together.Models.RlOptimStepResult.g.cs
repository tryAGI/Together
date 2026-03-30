
#nullable enable

namespace Together
{
    /// <summary>
    /// Result of an optimizer step operation
    /// </summary>
    public sealed partial class RlOptimStepResult
    {
        /// <summary>
        /// Step number<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("step")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Step { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlOptimStepResult" /> class.
        /// </summary>
        /// <param name="step">
        /// Step number<br/>
        /// Example: 100
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlOptimStepResult(
            string step)
        {
            this.Step = step ?? throw new global::System.ArgumentNullException(nameof(step));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlOptimStepResult" /> class.
        /// </summary>
        public RlOptimStepResult()
        {
        }
    }
}