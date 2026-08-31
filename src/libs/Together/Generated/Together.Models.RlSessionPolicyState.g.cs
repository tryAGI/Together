
#nullable enable

namespace Together
{
    /// <summary>
    /// Session-scoped policy and weight versions. Comparable to `policy_segments[].version` on sample results. Resets if the session is resumed or its training runtime restarts.
    /// </summary>
    public sealed partial class RlSessionPolicyState
    {
        /// <summary>
        /// Policy version produced by the last completed optimizer step. Distinct from `TrainingSession.step`, which is the durable optimizer-step counter.<br/>
        /// Example: 7
        /// </summary>
        /// <example>7</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("trainer_step")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<string, int?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.OneOf<string, int?> TrainerStep { get; set; }

        /// <summary>
        /// Policy version promised to the generator by the latest weights-sync.<br/>
        /// Example: 7
        /// </summary>
        /// <example>7</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_weights_version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<string, int?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.OneOf<string, int?> TargetWeightsVersion { get; set; }

        /// <summary>
        /// Policy version successfully applied to the generator for this session.<br/>
        /// Example: 6
        /// </summary>
        /// <example>6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("applied_weights_version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<string, int?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.OneOf<string, int?> AppliedWeightsVersion { get; set; }

        /// <summary>
        /// True when a generator publish has been requested but has not finished.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_publish")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PendingPublish { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlSessionPolicyState" /> class.
        /// </summary>
        /// <param name="trainerStep">
        /// Policy version produced by the last completed optimizer step. Distinct from `TrainingSession.step`, which is the durable optimizer-step counter.<br/>
        /// Example: 7
        /// </param>
        /// <param name="targetWeightsVersion">
        /// Policy version promised to the generator by the latest weights-sync.<br/>
        /// Example: 7
        /// </param>
        /// <param name="appliedWeightsVersion">
        /// Policy version successfully applied to the generator for this session.<br/>
        /// Example: 6
        /// </param>
        /// <param name="pendingPublish">
        /// True when a generator publish has been requested but has not finished.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlSessionPolicyState(
            global::Together.OneOf<string, int?> trainerStep,
            global::Together.OneOf<string, int?> targetWeightsVersion,
            global::Together.OneOf<string, int?> appliedWeightsVersion,
            bool pendingPublish)
        {
            this.TrainerStep = trainerStep;
            this.TargetWeightsVersion = targetWeightsVersion;
            this.AppliedWeightsVersion = appliedWeightsVersion;
            this.PendingPublish = pendingPublish;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlSessionPolicyState" /> class.
        /// </summary>
        public RlSessionPolicyState()
        {
        }

    }
}