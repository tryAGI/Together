
#nullable enable

namespace Together
{
    /// <summary>
    /// Pause metadata returned while a rollout is paused.
    /// </summary>
    public sealed partial class DePauseInfo
    {
        /// <summary>
        /// Human-readable reason recorded when the rollout was paused.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Timestamp when the rollout was paused.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pausedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime PausedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DePauseInfo" /> class.
        /// </summary>
        /// <param name="pausedAt">
        /// Timestamp when the rollout was paused.
        /// </param>
        /// <param name="reason">
        /// Human-readable reason recorded when the rollout was paused.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DePauseInfo(
            global::System.DateTime pausedAt,
            string? reason)
        {
            this.Reason = reason;
            this.PausedAt = pausedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DePauseInfo" /> class.
        /// </summary>
        public DePauseInfo()
        {
        }

    }
}