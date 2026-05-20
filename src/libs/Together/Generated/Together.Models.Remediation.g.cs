
#nullable enable

namespace Together
{
    /// <summary>
    /// Remediation represents a node remediation request for an instance.<br/>
    /// An instance can have multiple remediations over time (e.g., failed attempts followed by retries).
    /// </summary>
    public sealed partial class Remediation
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("cluster_id")]
        public string ClusterId { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("instance_id")]
        public string InstanceId { get; set; } = default!;

        /// <summary>
        /// Remediation mode specifies how the remediation should be performed.<br/>
        /// - `REMEDIATION_MODE_VM_ONLY`: Deletes the VM and provisions a new one on any available host.<br/>
        /// - `REMEDIATION_MODE_HOST_AWARE`: Cordons the host, deletes the VM, and provisions a new one on a different host.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.RemediationModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.RemediationMode Mode { get; set; }

        /// <summary>
        /// RemediationTrigger specifies how the remediation was triggered.<br/>
        /// - `REMEDIATION_TRIGGER_MANUAL`: A user-initiated remediation (either via web UI or API call).<br/>
        /// - `REMEDIATION_TRIGGER_AUTOMATED`: A system-initiated remediation that requires approval.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.RemediationTriggerJsonConverter))]
        public global::Together.RemediationTrigger Trigger { get; set; } = default!;

        /// <summary>
        /// RemediationState represents the lifecycle state of a remediation.<br/>
        /// - `PENDING_APPROVAL`: Awaiting approval before processing can begin.<br/>
        /// - `PENDING`: Approved and queued for processing.<br/>
        /// - `RUNNING`: Actively being processed.<br/>
        /// - `SUCCEEDED`: Successfully completed.<br/>
        /// - `FAILED`: Failed with an error.<br/>
        /// - `CANCELLED`: Cancelled by user or system.<br/>
        /// - `AUTO_RESOLVED`: The underlying issue was automatically resolved before processing.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.RemediationStateJsonConverter))]
        public global::Together.RemediationState State { get; set; } = default!;

        /// <summary>
        /// User-provided reason for the remediation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Active health check run ID (UUID) that triggered this remediation.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_health_check_run_id")]
        public string? ActiveHealthCheckRunId { get; set; }

        /// <summary>
        /// Passive health check event ID that triggered this remediation.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passive_health_check_event_id")]
        public string? PassiveHealthCheckEventId { get; set; }

        /// <summary>
        /// Who requested the remediation.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_by")]
        public string? RequestedBy { get; set; }

        /// <summary>
        /// When the remediation was created.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("create_time")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// Who reviewed the remediation.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewed_by")]
        public string? ReviewedBy { get; set; }

        /// <summary>
        /// When the remediation was reviewed.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_time")]
        public global::System.DateTime? ReviewTime { get; set; }

        /// <summary>
        /// Review comment.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_comment")]
        public string? ReviewComment { get; set; }

        /// <summary>
        /// When processing started.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// When the remediation completed.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Error message if the remediation failed.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// When the remediation was last updated.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("update_time")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Remediation" /> class.
        /// </summary>
        /// <param name="mode">
        /// Remediation mode specifies how the remediation should be performed.<br/>
        /// - `REMEDIATION_MODE_VM_ONLY`: Deletes the VM and provisions a new one on any available host.<br/>
        /// - `REMEDIATION_MODE_HOST_AWARE`: Cordons the host, deletes the VM, and provisions a new one on a different host.
        /// </param>
        /// <param name="reason">
        /// User-provided reason for the remediation.
        /// </param>
        /// <param name="activeHealthCheckRunId">
        /// Active health check run ID (UUID) that triggered this remediation.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="passiveHealthCheckEventId">
        /// Passive health check event ID that triggered this remediation.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="requestedBy">
        /// Who requested the remediation.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createTime">
        /// When the remediation was created.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="reviewedBy">
        /// Who reviewed the remediation.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="reviewTime">
        /// When the remediation was reviewed.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="reviewComment">
        /// Review comment.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="startTime">
        /// When processing started.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="endTime">
        /// When the remediation completed.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="errorMessage">
        /// Error message if the remediation failed.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updateTime">
        /// When the remediation was last updated.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="clusterId">
        /// Included only in responses
        /// </param>
        /// <param name="instanceId">
        /// Included only in responses
        /// </param>
        /// <param name="trigger">
        /// RemediationTrigger specifies how the remediation was triggered.<br/>
        /// - `REMEDIATION_TRIGGER_MANUAL`: A user-initiated remediation (either via web UI or API call).<br/>
        /// - `REMEDIATION_TRIGGER_AUTOMATED`: A system-initiated remediation that requires approval.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="state">
        /// RemediationState represents the lifecycle state of a remediation.<br/>
        /// - `PENDING_APPROVAL`: Awaiting approval before processing can begin.<br/>
        /// - `PENDING`: Approved and queued for processing.<br/>
        /// - `RUNNING`: Actively being processed.<br/>
        /// - `SUCCEEDED`: Successfully completed.<br/>
        /// - `FAILED`: Failed with an error.<br/>
        /// - `CANCELLED`: Cancelled by user or system.<br/>
        /// - `AUTO_RESOLVED`: The underlying issue was automatically resolved before processing.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Remediation(
            global::Together.RemediationMode mode,
            string? reason,
            string? activeHealthCheckRunId,
            string? passiveHealthCheckEventId,
            string? requestedBy,
            global::System.DateTime? createTime,
            string? reviewedBy,
            global::System.DateTime? reviewTime,
            string? reviewComment,
            global::System.DateTime? startTime,
            global::System.DateTime? endTime,
            string? errorMessage,
            global::System.DateTime? updateTime,
            string id = default!,
            string clusterId = default!,
            string instanceId = default!,
            global::Together.RemediationTrigger trigger = default!,
            global::Together.RemediationState state = default!)
        {
            this.Id = id;
            this.ClusterId = clusterId;
            this.InstanceId = instanceId;
            this.Mode = mode;
            this.Trigger = trigger;
            this.State = state;
            this.Reason = reason;
            this.ActiveHealthCheckRunId = activeHealthCheckRunId;
            this.PassiveHealthCheckEventId = passiveHealthCheckEventId;
            this.RequestedBy = requestedBy;
            this.CreateTime = createTime;
            this.ReviewedBy = reviewedBy;
            this.ReviewTime = reviewTime;
            this.ReviewComment = reviewComment;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.ErrorMessage = errorMessage;
            this.UpdateTime = updateTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Remediation" /> class.
        /// </summary>
        public Remediation()
        {
        }

        /// <summary>
        /// Creates a new <see cref="Remediation"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static Remediation FromMode(global::Together.RemediationMode mode)
        {
            return new Remediation
            {
                Mode = mode,
            };
        }

    }
}