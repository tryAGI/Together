
#nullable enable

namespace Together
{
    /// <summary>
    /// Completed create-form state — the caller's spec with defaulted values filled in, the steps the rollout is expected to walk, and the capacity context the defaults were computed from. Display only.
    /// </summary>
    public sealed partial class DeRolloutDefaultsPreview
    {
        /// <summary>
        /// The caller's spec with defaulted values filled in for display. canary.steps is echoed exactly as sent; the suggested ladder is returned in estimatedEffectiveSteps instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spec")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.DeCreateRolloutRequest Spec { get; set; }

        /// <summary>
        /// Steps the rollout is expected to walk when the caller leaves steps unset. Display only. Empty when the caller supplied steps or no ladder applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimatedEffectiveSteps")]
        public global::System.Collections.Generic.IList<global::Together.DeRolloutStep>? EstimatedEffectiveSteps { get; set; }

        /// <summary>
        /// True when both deployments stand in the endpoint traffic split, so the rollout resumes from the current split rather than from zero. See warnings for standing split shapes that StartRollout will still reject.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frozenPair")]
        public bool? FrozenPair { get; set; }

        /// <summary>
        /// Percentage of the pair's traffic currently reaching the target, the floor the suggested steps start above. Unset when not a frozen pair or unknown; 0 is a real measurement.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimatedSeedPercent")]
        public int? EstimatedSeedPercent { get; set; }

        /// <summary>
        /// Source deployment replica count the defaults were computed from. Zero is a real value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceReplicas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SourceReplicas { get; set; }

        /// <summary>
        /// Target deployment replica count the defaults were computed from. Zero is a real value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetReplicas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TargetReplicas { get; set; }

        /// <summary>
        /// Target deployment autoscaling minimum replica count. Zero is a real value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetMinReplicas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TargetMinReplicas { get; set; }

        /// <summary>
        /// Target deployment autoscaling maximum replica count. Zero is a real value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetMaxReplicas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TargetMaxReplicas { get; set; }

        /// <summary>
        /// Non-blocking findings to surface next to the form. An empty list means the shown values are safe to submit as-is.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warnings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.DePreviewWarning> Warnings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeRolloutDefaultsPreview" /> class.
        /// </summary>
        /// <param name="spec">
        /// The caller's spec with defaulted values filled in for display. canary.steps is echoed exactly as sent; the suggested ladder is returned in estimatedEffectiveSteps instead.
        /// </param>
        /// <param name="sourceReplicas">
        /// Source deployment replica count the defaults were computed from. Zero is a real value.
        /// </param>
        /// <param name="targetReplicas">
        /// Target deployment replica count the defaults were computed from. Zero is a real value.
        /// </param>
        /// <param name="targetMinReplicas">
        /// Target deployment autoscaling minimum replica count. Zero is a real value.
        /// </param>
        /// <param name="targetMaxReplicas">
        /// Target deployment autoscaling maximum replica count. Zero is a real value.
        /// </param>
        /// <param name="warnings">
        /// Non-blocking findings to surface next to the form. An empty list means the shown values are safe to submit as-is.
        /// </param>
        /// <param name="estimatedEffectiveSteps">
        /// Steps the rollout is expected to walk when the caller leaves steps unset. Display only. Empty when the caller supplied steps or no ladder applies.
        /// </param>
        /// <param name="frozenPair">
        /// True when both deployments stand in the endpoint traffic split, so the rollout resumes from the current split rather than from zero. See warnings for standing split shapes that StartRollout will still reject.
        /// </param>
        /// <param name="estimatedSeedPercent">
        /// Percentage of the pair's traffic currently reaching the target, the floor the suggested steps start above. Unset when not a frozen pair or unknown; 0 is a real measurement.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeRolloutDefaultsPreview(
            global::Together.DeCreateRolloutRequest spec,
            int sourceReplicas,
            int targetReplicas,
            int targetMinReplicas,
            int targetMaxReplicas,
            global::System.Collections.Generic.IList<global::Together.DePreviewWarning> warnings,
            global::System.Collections.Generic.IList<global::Together.DeRolloutStep>? estimatedEffectiveSteps,
            bool? frozenPair,
            int? estimatedSeedPercent)
        {
            this.Spec = spec ?? throw new global::System.ArgumentNullException(nameof(spec));
            this.EstimatedEffectiveSteps = estimatedEffectiveSteps;
            this.FrozenPair = frozenPair;
            this.EstimatedSeedPercent = estimatedSeedPercent;
            this.SourceReplicas = sourceReplicas;
            this.TargetReplicas = targetReplicas;
            this.TargetMinReplicas = targetMinReplicas;
            this.TargetMaxReplicas = targetMaxReplicas;
            this.Warnings = warnings ?? throw new global::System.ArgumentNullException(nameof(warnings));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeRolloutDefaultsPreview" /> class.
        /// </summary>
        public DeRolloutDefaultsPreview()
        {
        }

    }
}