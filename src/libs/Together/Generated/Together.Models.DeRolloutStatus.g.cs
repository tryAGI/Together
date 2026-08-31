
#nullable enable

namespace Together
{
    /// <summary>
    /// Derived runtime progress for a rollout.
    /// </summary>
    public sealed partial class DeRolloutStatus
    {
        /// <summary>
        /// Total number of steps in the rollout progression. Always serializes when status is present.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalSteps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalSteps { get; set; }

        /// <summary>
        /// Failure detail set when the rollout pauses, system-pauses, or aborts; carries the human-readable reason and structured detail.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        public global::Together.DeRolloutCondition? Condition { get; set; }

        /// <summary>
        /// Per-step rollout execution summaries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.DeRolloutStepStatus> Steps { get; set; }

        /// <summary>
        /// Timestamp of the most recent progress update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Informational conditions that describe the rollout's current state. Omitted when empty; clients should treat an absent key as an empty list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditions")]
        public global::System.Collections.Generic.IList<global::Together.DeRolloutCondition>? Conditions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeRolloutStatus" /> class.
        /// </summary>
        /// <param name="totalSteps">
        /// Total number of steps in the rollout progression. Always serializes when status is present.
        /// </param>
        /// <param name="steps">
        /// Per-step rollout execution summaries.
        /// </param>
        /// <param name="condition">
        /// Failure detail set when the rollout pauses, system-pauses, or aborts; carries the human-readable reason and structured detail.
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp of the most recent progress update.
        /// </param>
        /// <param name="conditions">
        /// Informational conditions that describe the rollout's current state. Omitted when empty; clients should treat an absent key as an empty list.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeRolloutStatus(
            int totalSteps,
            global::System.Collections.Generic.IList<global::Together.DeRolloutStepStatus> steps,
            global::Together.DeRolloutCondition? condition,
            global::System.DateTime? updatedAt,
            global::System.Collections.Generic.IList<global::Together.DeRolloutCondition>? conditions)
        {
            this.TotalSteps = totalSteps;
            this.Condition = condition;
            this.Steps = steps ?? throw new global::System.ArgumentNullException(nameof(steps));
            this.UpdatedAt = updatedAt;
            this.Conditions = conditions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeRolloutStatus" /> class.
        /// </summary>
        public DeRolloutStatus()
        {
        }

    }
}