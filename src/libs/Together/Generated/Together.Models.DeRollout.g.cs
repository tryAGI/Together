
#nullable enable

namespace Together
{
    /// <summary>
    /// Public view of a rollout resource and its embedded runtime status.
    /// </summary>
    public sealed partial class DeRollout
    {
        /// <summary>
        /// Output only. Unique rollout identifier.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Output only. Endpoint this rollout belongs to.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpointId")]
        public string EndpointId { get; set; } = default!;

        /// <summary>
        /// Output only. Deployment that traffic is shifting away from.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceDeploymentId")]
        public string SourceDeploymentId { get; set; } = default!;

        /// <summary>
        /// Output only. Deployment that traffic is shifting toward.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetDeploymentId")]
        public string TargetDeploymentId { get; set; } = default!;

        /// <summary>
        /// Output only. Rollout strategy selected at creation.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeRolloutStrategyJsonConverter))]
        public global::Together.DeRolloutStrategy Strategy { get; set; } = default!;

        /// <summary>
        /// Output only. High-level rollout lifecycle state.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeRolloutStateJsonConverter))]
        public global::Together.DeRolloutState State { get; set; } = default!;

        /// <summary>
        /// Output only. Zero-based index of the current step. Unset while PENDING; step 0 is reported explicitly after start.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentStep")]
        public int? CurrentStep { get; set; }

        /// <summary>
        /// Output only. Applied percentage of traffic on the target deployment.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentTrafficPercent")]
        public int? CurrentTrafficPercent { get; set; }

        /// <summary>
        /// Output only. Timestamp when the rollout was created.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Output only. Timestamp when the rollout started running.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedAt")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// Output only. Timestamp when the rollout reached a terminal state.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completedAt")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Output only. Opaque version tag for optimistic concurrency control.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("etag")]
        public string? Etag { get; set; }

        /// <summary>
        /// Output only. Derived runtime progress and failure details.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::Together.DeRolloutStatus Status { get; set; } = default!;

        /// <summary>
        /// Output only. Why and when the rollout was paused. Set while a pause is pending or effective (PAUSING, PAUSED, or SYSTEM_PAUSED); while PAUSING, pausedAt records when the pause was requested.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pauseInfo")]
        public global::Together.DePauseInfo? PauseInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeRollout" /> class.
        /// </summary>
        /// <param name="currentStep">
        /// Output only. Zero-based index of the current step. Unset while PENDING; step 0 is reported explicitly after start.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="currentTrafficPercent">
        /// Output only. Applied percentage of traffic on the target deployment.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="startedAt">
        /// Output only. Timestamp when the rollout started running.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="completedAt">
        /// Output only. Timestamp when the rollout reached a terminal state.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="etag">
        /// Output only. Opaque version tag for optimistic concurrency control.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="pauseInfo">
        /// Output only. Why and when the rollout was paused. Set while a pause is pending or effective (PAUSING, PAUSED, or SYSTEM_PAUSED); while PAUSING, pausedAt records when the pause was requested.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Output only. Unique rollout identifier.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="endpointId">
        /// Output only. Endpoint this rollout belongs to.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="sourceDeploymentId">
        /// Output only. Deployment that traffic is shifting away from.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="targetDeploymentId">
        /// Output only. Deployment that traffic is shifting toward.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="strategy">
        /// Output only. Rollout strategy selected at creation.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="state">
        /// Output only. High-level rollout lifecycle state.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// Output only. Timestamp when the rollout was created.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="status">
        /// Output only. Derived runtime progress and failure details.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeRollout(
            int? currentStep,
            int? currentTrafficPercent,
            global::System.DateTime? startedAt,
            global::System.DateTime? completedAt,
            string? etag,
            global::Together.DePauseInfo? pauseInfo,
            string id = default!,
            string endpointId = default!,
            string sourceDeploymentId = default!,
            string targetDeploymentId = default!,
            global::Together.DeRolloutStrategy strategy = default!,
            global::Together.DeRolloutState state = default!,
            global::System.DateTime createdAt = default!,
            global::Together.DeRolloutStatus status = default!)
        {
            this.Id = id;
            this.EndpointId = endpointId;
            this.SourceDeploymentId = sourceDeploymentId;
            this.TargetDeploymentId = targetDeploymentId;
            this.Strategy = strategy;
            this.State = state;
            this.CurrentStep = currentStep;
            this.CurrentTrafficPercent = currentTrafficPercent;
            this.CreatedAt = createdAt;
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
            this.Etag = etag;
            this.Status = status;
            this.PauseInfo = pauseInfo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeRollout" /> class.
        /// </summary>
        public DeRollout()
        {
        }

    }
}