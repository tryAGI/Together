
#nullable enable

namespace Together
{
    /// <summary>
    /// Optional concurrency check for immediately completing a rollout on its target deployment.
    /// </summary>
    public sealed partial class DePromoteRolloutRequest
    {
        /// <summary>
        /// Optional etag for optimistic concurrency.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("etag")]
        public string? Etag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DePromoteRolloutRequest" /> class.
        /// </summary>
        /// <param name="etag">
        /// Optional etag for optimistic concurrency.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DePromoteRolloutRequest(
            string? etag)
        {
            this.Etag = etag;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DePromoteRolloutRequest" /> class.
        /// </summary>
        public DePromoteRolloutRequest()
        {
        }

    }
}