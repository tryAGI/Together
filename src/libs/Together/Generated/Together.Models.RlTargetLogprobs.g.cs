
#nullable enable

namespace Together
{
    /// <summary>
    /// Per-token log-probabilities from the target model
    /// </summary>
    public sealed partial class RlTargetLogprobs
    {
        /// <summary>
        /// Float array of per-token log probabilities<br/>
        /// Example: [-1.2, -0.8, -1.5, -0.9, -1.1]
        /// </summary>
        /// <example>[-1.2, -0.8, -1.5, -0.9, -1.1]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlTargetLogprobs" /> class.
        /// </summary>
        /// <param name="data">
        /// Float array of per-token log probabilities<br/>
        /// Example: [-1.2, -0.8, -1.5, -0.9, -1.1]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlTargetLogprobs(
            global::System.Collections.Generic.IList<double> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlTargetLogprobs" /> class.
        /// </summary>
        public RlTargetLogprobs()
        {
        }

    }
}