
#nullable enable

namespace Together
{
    /// <summary>
    /// Passive health check alert returned by the health check API.
    /// </summary>
    public sealed partial class PassiveHealthCheckAlert
    {
        /// <summary>
        /// Primary key UUID for the passive health check alert.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("passive_health_check_alert_id")]
        public string PassiveHealthCheckAlertId { get; set; } = default!;

        /// <summary>
        /// Resolved instance UUID. Empty until the alert is joined to an instance.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instance_id")]
        public string? InstanceId { get; set; }

        /// <summary>
        /// Cluster UUID the alert was raised against.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("cluster_id")]
        public string ClusterId { get; set; } = default!;

        /// <summary>
        /// VM name extracted from the Alertmanager labels.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_vm")]
        public string TargetVm { get; set; } = default!;

        /// <summary>
        /// Alertmanager alert name.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("alert_name")]
        public string AlertName { get; set; } = default!;

        /// <summary>
        /// Canonical severity tier for the alert.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.PassiveHealthCheckAlertSeverityJsonConverter))]
        public global::Together.PassiveHealthCheckAlertSeverity Severity { get; set; } = default!;

        /// <summary>
        /// Legacy Alertmanager annotations as key-value strings.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        public global::System.Collections.Generic.Dictionary<string, string> Annotations { get; set; } = default!;

        /// <summary>
        /// Time when the underlying alert first fired.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime StartedAt { get; set; } = default!;

        /// <summary>
        /// Time when the underlying alert resolved. Empty while the alert is firing.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolved_at")]
        public global::System.DateTime? ResolvedAt { get; set; }

        /// <summary>
        /// Remediation intent UUID attached to this alert, if any.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_remediation_intent_id")]
        public string? NodeRemediationIntentId { get; set; }

        /// <summary>
        /// Typed annotation content parsed from the legacy annotations bag.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation")]
        public global::Together.PHCAnnotation Annotation { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PassiveHealthCheckAlert" /> class.
        /// </summary>
        /// <param name="instanceId">
        /// Resolved instance UUID. Empty until the alert is joined to an instance.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="resolvedAt">
        /// Time when the underlying alert resolved. Empty while the alert is firing.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="nodeRemediationIntentId">
        /// Remediation intent UUID attached to this alert, if any.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="passiveHealthCheckAlertId">
        /// Primary key UUID for the passive health check alert.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="clusterId">
        /// Cluster UUID the alert was raised against.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="targetVm">
        /// VM name extracted from the Alertmanager labels.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="alertName">
        /// Alertmanager alert name.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="severity">
        /// Canonical severity tier for the alert.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="annotations">
        /// Legacy Alertmanager annotations as key-value strings.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="startedAt">
        /// Time when the underlying alert first fired.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="annotation">
        /// Typed annotation content parsed from the legacy annotations bag.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PassiveHealthCheckAlert(
            string? instanceId,
            global::System.DateTime? resolvedAt,
            string? nodeRemediationIntentId,
            string passiveHealthCheckAlertId = default!,
            string clusterId = default!,
            string targetVm = default!,
            string alertName = default!,
            global::Together.PassiveHealthCheckAlertSeverity severity = default!,
            global::System.Collections.Generic.Dictionary<string, string> annotations = default!,
            global::System.DateTime startedAt = default!,
            global::Together.PHCAnnotation annotation = default!)
        {
            this.PassiveHealthCheckAlertId = passiveHealthCheckAlertId;
            this.InstanceId = instanceId;
            this.ClusterId = clusterId;
            this.TargetVm = targetVm;
            this.AlertName = alertName;
            this.Severity = severity;
            this.Annotations = annotations;
            this.StartedAt = startedAt;
            this.ResolvedAt = resolvedAt;
            this.NodeRemediationIntentId = nodeRemediationIntentId;
            this.Annotation = annotation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PassiveHealthCheckAlert" /> class.
        /// </summary>
        public PassiveHealthCheckAlert()
        {
        }

    }
}