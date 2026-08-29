
#nullable enable

namespace Together
{
    /// <summary>
    /// Reason, disposition, and optional concurrency check for canceling a rollout.
    /// </summary>
    public sealed partial class DeCancelRolloutRequest
    {
        /// <summary>
        /// Required human-readable reason recorded in the rollout audit trail.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reason { get; set; }

        /// <summary>
        /// Optional etag for optimistic concurrency.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("etag")]
        public string? Etag { get; set; }

        /// <summary>
        /// Optional cancel behavior. Absent defaults to freeze, which preserves the current traffic split. Revert is removed and rejected with FAILED_PRECONDITION; cancel with freeze, then run a reverse rollout back to the source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disposition")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeCancelRolloutRequestDispositionJsonConverter))]
        public global::Together.DeCancelRolloutRequestDisposition? Disposition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeCancelRolloutRequest" /> class.
        /// </summary>
        /// <param name="reason">
        /// Required human-readable reason recorded in the rollout audit trail.
        /// </param>
        /// <param name="etag">
        /// Optional etag for optimistic concurrency.
        /// </param>
        /// <param name="disposition">
        /// Optional cancel behavior. Absent defaults to freeze, which preserves the current traffic split. Revert is removed and rejected with FAILED_PRECONDITION; cancel with freeze, then run a reverse rollout back to the source.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeCancelRolloutRequest(
            string reason,
            string? etag,
            global::Together.DeCancelRolloutRequestDisposition? disposition)
        {
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
            this.Etag = etag;
            this.Disposition = disposition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeCancelRolloutRequest" /> class.
        /// </summary>
        public DeCancelRolloutRequest()
        {
        }

    }
}