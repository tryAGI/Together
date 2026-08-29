
#nullable enable

namespace Together
{
    /// <summary>
    /// Result of a weights-sync operation
    /// </summary>
    public sealed partial class RlWeightsSyncResult
    {
        /// <summary>
        /// Policy version now available for sampling, or queued to become available for deferred sync modes. Comparable to `policy_segments[].version` on sample results.<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("weights_version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<string, int?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.OneOf<string, int?> WeightsVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlWeightsSyncResult" /> class.
        /// </summary>
        /// <param name="weightsVersion">
        /// Policy version now available for sampling, or queued to become available for deferred sync modes. Comparable to `policy_segments[].version` on sample results.<br/>
        /// Example: 100
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlWeightsSyncResult(
            global::Together.OneOf<string, int?> weightsVersion)
        {
            this.WeightsVersion = weightsVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlWeightsSyncResult" /> class.
        /// </summary>
        public RlWeightsSyncResult()
        {
        }

    }
}