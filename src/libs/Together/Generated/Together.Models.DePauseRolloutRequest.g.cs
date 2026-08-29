
#nullable enable

namespace Together
{
    /// <summary>
    /// Optional concurrency check and audit reason for pausing a running rollout.
    /// </summary>
    public sealed partial class DePauseRolloutRequest
    {
        /// <summary>
        /// Optional etag for optimistic concurrency.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("etag")]
        public string? Etag { get; set; }

        /// <summary>
        /// Optional human-readable reason recorded on the rollout pause metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DePauseRolloutRequest" /> class.
        /// </summary>
        /// <param name="etag">
        /// Optional etag for optimistic concurrency.
        /// </param>
        /// <param name="reason">
        /// Optional human-readable reason recorded on the rollout pause metadata.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DePauseRolloutRequest(
            string? etag,
            string? reason)
        {
            this.Etag = etag;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DePauseRolloutRequest" /> class.
        /// </summary>
        public DePauseRolloutRequest()
        {
        }

    }
}