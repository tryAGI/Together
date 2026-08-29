
#nullable enable

namespace Together
{
    /// <summary>
    /// Collapsed execution state for one rollout step.
    /// </summary>
    public sealed partial class DeRolloutStepStatus
    {
        /// <summary>
        /// Index of this step in the rollout progression. Step 0 serializes explicitly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stepIndex")]
        public int? StepIndex { get; set; }

        /// <summary>
        /// Target traffic percentage configured for this step. Always serializes for recorded steps.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetTrafficPercent")]
        public int? TargetTrafficPercent { get; set; }

        /// <summary>
        /// Execution state of this rollout step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeRolloutStepStatusStateJsonConverter))]
        public global::Together.DeRolloutStepStatusState? State { get; set; }

        /// <summary>
        /// Metric gate results for this step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        public global::System.Collections.Generic.IList<global::Together.DeMetricResult>? Metrics { get; set; }

        /// <summary>
        /// Timestamp when this step started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedAt")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// Timestamp when this step completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completedAt")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Failure reason when this step failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failureReason")]
        public string? FailureReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeRolloutStepStatus" /> class.
        /// </summary>
        /// <param name="stepIndex">
        /// Index of this step in the rollout progression. Step 0 serializes explicitly.
        /// </param>
        /// <param name="targetTrafficPercent">
        /// Target traffic percentage configured for this step. Always serializes for recorded steps.
        /// </param>
        /// <param name="state">
        /// Execution state of this rollout step.
        /// </param>
        /// <param name="metrics">
        /// Metric gate results for this step.
        /// </param>
        /// <param name="startedAt">
        /// Timestamp when this step started.
        /// </param>
        /// <param name="completedAt">
        /// Timestamp when this step completed.
        /// </param>
        /// <param name="failureReason">
        /// Failure reason when this step failed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeRolloutStepStatus(
            int? stepIndex,
            int? targetTrafficPercent,
            global::Together.DeRolloutStepStatusState? state,
            global::System.Collections.Generic.IList<global::Together.DeMetricResult>? metrics,
            global::System.DateTime? startedAt,
            global::System.DateTime? completedAt,
            string? failureReason)
        {
            this.StepIndex = stepIndex;
            this.TargetTrafficPercent = targetTrafficPercent;
            this.State = state;
            this.Metrics = metrics;
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
            this.FailureReason = failureReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeRolloutStepStatus" /> class.
        /// </summary>
        public DeRolloutStepStatus()
        {
        }

    }
}