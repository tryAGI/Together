
#nullable enable

namespace Together
{
    /// <summary>
    /// Structured reason a rollout stopped progressing.
    /// </summary>
    public sealed partial class DeRolloutCondition
    {
        /// <summary>
        /// Category that classifies why the rollout stopped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeRolloutConditionCategoryJsonConverter))]
        public global::Together.DeRolloutConditionCategory? Category { get; set; }

        /// <summary>
        /// Human-readable explanation for the condition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Step index where the condition arose. Step 0 serializes explicitly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("atStep")]
        public int? AtStep { get; set; }

        /// <summary>
        /// Timestamp when the condition was observed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("observedAt")]
        public global::System.DateTime? ObservedAt { get; set; }

        /// <summary>
        /// Metrics observed at the failing gate, enriched with their criteria.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        public global::System.Collections.Generic.IList<global::Together.DeMetricResult>? Metrics { get; set; }

        /// <summary>
        /// Informational condition type. `CapacityLimited` means the current step advanced partially because full capacity was not placeable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeRolloutConditionTypeJsonConverter))]
        public global::Together.DeRolloutConditionType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeRolloutCondition" /> class.
        /// </summary>
        /// <param name="category">
        /// Category that classifies why the rollout stopped.
        /// </param>
        /// <param name="message">
        /// Human-readable explanation for the condition.
        /// </param>
        /// <param name="atStep">
        /// Step index where the condition arose. Step 0 serializes explicitly.
        /// </param>
        /// <param name="observedAt">
        /// Timestamp when the condition was observed.
        /// </param>
        /// <param name="metrics">
        /// Metrics observed at the failing gate, enriched with their criteria.
        /// </param>
        /// <param name="type">
        /// Informational condition type. `CapacityLimited` means the current step advanced partially because full capacity was not placeable.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeRolloutCondition(
            global::Together.DeRolloutConditionCategory? category,
            string? message,
            int? atStep,
            global::System.DateTime? observedAt,
            global::System.Collections.Generic.IList<global::Together.DeMetricResult>? metrics,
            global::Together.DeRolloutConditionType? type)
        {
            this.Category = category;
            this.Message = message;
            this.AtStep = atStep;
            this.ObservedAt = observedAt;
            this.Metrics = metrics;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeRolloutCondition" /> class.
        /// </summary>
        public DeRolloutCondition()
        {
        }

    }
}