
#nullable enable

namespace Together
{
    /// <summary>
    /// Deployment configuration captured for one retained revision.
    /// </summary>
    public sealed partial class RevisionDetailResponse
    {
        /// <summary>
        /// The object type, which is always `revision`.
        /// </summary>
        /// <default>"revision"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "revision";

        /// <summary>
        /// Unique revision identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RevisionId { get; set; }

        /// <summary>
        /// Container image used by this revision.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Image { get; set; }

        /// <summary>
        /// Minimum number of replicas configured for this revision.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_replicas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MinReplicas { get; set; }

        /// <summary>
        /// Maximum number of replicas configured for this revision.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_replicas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxReplicas { get; set; }

        /// <summary>
        /// Container port exposed by this revision.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("port")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Port { get; set; }

        /// <summary>
        /// Network protocol served by the deployment revision.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protocol")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Protocol { get; set; }

        /// <summary>
        /// Capacity behavior for replicas above reserved capacity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capacity_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.RevisionDetailResponseCapacityTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.RevisionDetailResponseCapacityType CapacityType { get; set; }

        /// <summary>
        /// Entrypoint command run by the container.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Command { get; set; }

        /// <summary>
        /// Arguments passed to the container command.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Args { get; set; }

        /// <summary>
        /// Environment variables configured on this revision.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_variables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.EnvironmentVariable> EnvironmentVariables { get; set; }

        /// <summary>
        /// Volume mounts attached to this revision.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volumes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.VolumeMount> Volumes { get; set; }

        /// <summary>
        /// GPU hardware type configured for this revision.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GpuType { get; set; }

        /// <summary>
        /// Number of GPUs allocated to each replica.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int GpuCount { get; set; }

        /// <summary>
        /// CPU cores allocated to each replica.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpu")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Cpu { get; set; }

        /// <summary>
        /// Memory allocated to each replica in GiB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Memory { get; set; }

        /// <summary>
        /// Ephemeral storage allocated to each replica.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Storage { get; set; }

        /// <summary>
        /// HTTP path used for health checks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("health_check_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HealthCheckPath { get; set; }

        /// <summary>
        /// Autoscaling configuration captured for this revision.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.HTTPAutoscalingConfig, global::Together.QueueAutoscalingConfig, global::Together.CustomMetricAutoscalingConfig>))]
        public global::Together.OneOf<global::Together.HTTPAutoscalingConfig, global::Together.QueueAutoscalingConfig, global::Together.CustomMetricAutoscalingConfig>? Autoscaling { get; set; }

        /// <summary>
        /// Seconds to wait for graceful shutdown before forcefully terminating a replica.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("termination_grace_period_seconds")]
        public int? TerminationGracePeriodSeconds { get; set; }

        /// <summary>
        /// Time when this revision was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RevisionDetailResponse" /> class.
        /// </summary>
        /// <param name="revisionId">
        /// Unique revision identifier.
        /// </param>
        /// <param name="image">
        /// Container image used by this revision.
        /// </param>
        /// <param name="minReplicas">
        /// Minimum number of replicas configured for this revision.
        /// </param>
        /// <param name="maxReplicas">
        /// Maximum number of replicas configured for this revision.
        /// </param>
        /// <param name="port">
        /// Container port exposed by this revision.
        /// </param>
        /// <param name="protocol">
        /// Network protocol served by the deployment revision.
        /// </param>
        /// <param name="capacityType">
        /// Capacity behavior for replicas above reserved capacity.
        /// </param>
        /// <param name="command">
        /// Entrypoint command run by the container.
        /// </param>
        /// <param name="args">
        /// Arguments passed to the container command.
        /// </param>
        /// <param name="environmentVariables">
        /// Environment variables configured on this revision.
        /// </param>
        /// <param name="volumes">
        /// Volume mounts attached to this revision.
        /// </param>
        /// <param name="gpuType">
        /// GPU hardware type configured for this revision.
        /// </param>
        /// <param name="gpuCount">
        /// Number of GPUs allocated to each replica.
        /// </param>
        /// <param name="cpu">
        /// CPU cores allocated to each replica.
        /// </param>
        /// <param name="memory">
        /// Memory allocated to each replica in GiB.
        /// </param>
        /// <param name="storage">
        /// Ephemeral storage allocated to each replica.
        /// </param>
        /// <param name="healthCheckPath">
        /// HTTP path used for health checks.
        /// </param>
        /// <param name="createdAt">
        /// Time when this revision was created.
        /// </param>
        /// <param name="autoscaling">
        /// Autoscaling configuration captured for this revision.
        /// </param>
        /// <param name="terminationGracePeriodSeconds">
        /// Seconds to wait for graceful shutdown before forcefully terminating a replica.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `revision`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RevisionDetailResponse(
            string revisionId,
            string image,
            int minReplicas,
            int maxReplicas,
            int port,
            string protocol,
            global::Together.RevisionDetailResponseCapacityType capacityType,
            global::System.Collections.Generic.IList<string> command,
            global::System.Collections.Generic.IList<string> args,
            global::System.Collections.Generic.IList<global::Together.EnvironmentVariable> environmentVariables,
            global::System.Collections.Generic.IList<global::Together.VolumeMount> volumes,
            string gpuType,
            int gpuCount,
            double cpu,
            double memory,
            int storage,
            string healthCheckPath,
            global::System.DateTime createdAt,
            global::Together.OneOf<global::Together.HTTPAutoscalingConfig, global::Together.QueueAutoscalingConfig, global::Together.CustomMetricAutoscalingConfig>? autoscaling,
            int? terminationGracePeriodSeconds,
            string @object = "revision")
        {
            this.Object = @object;
            this.RevisionId = revisionId ?? throw new global::System.ArgumentNullException(nameof(revisionId));
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.MinReplicas = minReplicas;
            this.MaxReplicas = maxReplicas;
            this.Port = port;
            this.Protocol = protocol ?? throw new global::System.ArgumentNullException(nameof(protocol));
            this.CapacityType = capacityType;
            this.Command = command ?? throw new global::System.ArgumentNullException(nameof(command));
            this.Args = args ?? throw new global::System.ArgumentNullException(nameof(args));
            this.EnvironmentVariables = environmentVariables ?? throw new global::System.ArgumentNullException(nameof(environmentVariables));
            this.Volumes = volumes ?? throw new global::System.ArgumentNullException(nameof(volumes));
            this.GpuType = gpuType ?? throw new global::System.ArgumentNullException(nameof(gpuType));
            this.GpuCount = gpuCount;
            this.Cpu = cpu;
            this.Memory = memory;
            this.Storage = storage;
            this.HealthCheckPath = healthCheckPath ?? throw new global::System.ArgumentNullException(nameof(healthCheckPath));
            this.Autoscaling = autoscaling;
            this.TerminationGracePeriodSeconds = terminationGracePeriodSeconds;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RevisionDetailResponse" /> class.
        /// </summary>
        public RevisionDetailResponse()
        {
        }

    }
}