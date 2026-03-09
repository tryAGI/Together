
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentResponseItem
    {
        /// <summary>
        /// Args are the arguments passed to the container's command
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        public global::System.Collections.Generic.IList<string>? Args { get; set; }

        /// <summary>
        /// Autoscaling contains autoscaling configuration parameters for this deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling")]
        public global::System.Collections.Generic.Dictionary<string, string>? Autoscaling { get; set; }

        /// <summary>
        /// Command is the entrypoint command run in the container
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        public global::System.Collections.Generic.IList<string>? Command { get; set; }

        /// <summary>
        /// CPU is the amount of CPU resource allocated to each replica in cores (fractional value is allowed)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpu")]
        public double? Cpu { get; set; }

        /// <summary>
        /// CreatedAt is the ISO8601 timestamp when this deployment was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Description provides a human-readable explanation of the deployment's purpose or content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// DesiredReplicas is the number of replicas that the orchestrator is targeting
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("desired_replicas")]
        public int? DesiredReplicas { get; set; }

        /// <summary>
        /// EnvironmentVariables is a list of environment variables set in the container
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_variables")]
        public global::System.Collections.Generic.IList<global::Together.EnvironmentVariable>? EnvironmentVariables { get; set; }

        /// <summary>
        /// GPUCount is the number of GPUs allocated to each replica in this deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_count")]
        public int? GpuCount { get; set; }

        /// <summary>
        /// GPUType specifies the type of GPU requested (if any) for this deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeploymentResponseItemGpuTypeJsonConverter))]
        public global::Together.DeploymentResponseItemGpuType? GpuType { get; set; }

        /// <summary>
        /// HealthCheckPath is the HTTP path used for health checks of the application
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("health_check_path")]
        public string? HealthCheckPath { get; set; }

        /// <summary>
        /// ID is the unique identifier of the deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Image specifies the container image used for this deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// MaxReplicas is the maximum number of replicas to run for this deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_replicas")]
        public int? MaxReplicas { get; set; }

        /// <summary>
        /// Memory is the amount of memory allocated to each replica in GiB (fractional value is allowed)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        public double? Memory { get; set; }

        /// <summary>
        /// MinReplicas is the minimum number of replicas to run for this deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_replicas")]
        public int? MinReplicas { get; set; }

        /// <summary>
        /// Name is the name of the deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The object type, which is always `deployment`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Port is the container port that the deployment exposes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("port")]
        public int? Port { get; set; }

        /// <summary>
        /// ReadyReplicas is the current number of replicas that are in the Ready state
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ready_replicas")]
        public int? ReadyReplicas { get; set; }

        /// <summary>
        /// ReplicaEvents is a mapping of replica names or IDs to their status events
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replica_events")]
        public global::System.Collections.Generic.Dictionary<string, global::Together.ReplicaEvent>? ReplicaEvents { get; set; }

        /// <summary>
        /// Status represents the overall status of the deployment (e.g., Updating, Scaling, Ready, Failed)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeploymentStatusJsonConverter))]
        public global::Together.DeploymentStatus? Status { get; set; }

        /// <summary>
        /// Storage is the amount of storage (in MB or units as defined by the platform) allocated to each replica
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage")]
        public int? Storage { get; set; }

        /// <summary>
        /// UpdatedAt is the ISO8601 timestamp when this deployment was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Volumes is a list of volume mounts for this deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volumes")]
        public global::System.Collections.Generic.IList<global::Together.VolumeMount>? Volumes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentResponseItem" /> class.
        /// </summary>
        /// <param name="args">
        /// Args are the arguments passed to the container's command
        /// </param>
        /// <param name="autoscaling">
        /// Autoscaling contains autoscaling configuration parameters for this deployment
        /// </param>
        /// <param name="command">
        /// Command is the entrypoint command run in the container
        /// </param>
        /// <param name="cpu">
        /// CPU is the amount of CPU resource allocated to each replica in cores (fractional value is allowed)
        /// </param>
        /// <param name="createdAt">
        /// CreatedAt is the ISO8601 timestamp when this deployment was created
        /// </param>
        /// <param name="description">
        /// Description provides a human-readable explanation of the deployment's purpose or content
        /// </param>
        /// <param name="desiredReplicas">
        /// DesiredReplicas is the number of replicas that the orchestrator is targeting
        /// </param>
        /// <param name="environmentVariables">
        /// EnvironmentVariables is a list of environment variables set in the container
        /// </param>
        /// <param name="gpuCount">
        /// GPUCount is the number of GPUs allocated to each replica in this deployment
        /// </param>
        /// <param name="gpuType">
        /// GPUType specifies the type of GPU requested (if any) for this deployment
        /// </param>
        /// <param name="healthCheckPath">
        /// HealthCheckPath is the HTTP path used for health checks of the application
        /// </param>
        /// <param name="id">
        /// ID is the unique identifier of the deployment
        /// </param>
        /// <param name="image">
        /// Image specifies the container image used for this deployment
        /// </param>
        /// <param name="maxReplicas">
        /// MaxReplicas is the maximum number of replicas to run for this deployment
        /// </param>
        /// <param name="memory">
        /// Memory is the amount of memory allocated to each replica in GiB (fractional value is allowed)
        /// </param>
        /// <param name="minReplicas">
        /// MinReplicas is the minimum number of replicas to run for this deployment
        /// </param>
        /// <param name="name">
        /// Name is the name of the deployment
        /// </param>
        /// <param name="object">
        /// The object type, which is always `deployment`.
        /// </param>
        /// <param name="port">
        /// Port is the container port that the deployment exposes
        /// </param>
        /// <param name="readyReplicas">
        /// ReadyReplicas is the current number of replicas that are in the Ready state
        /// </param>
        /// <param name="replicaEvents">
        /// ReplicaEvents is a mapping of replica names or IDs to their status events
        /// </param>
        /// <param name="status">
        /// Status represents the overall status of the deployment (e.g., Updating, Scaling, Ready, Failed)
        /// </param>
        /// <param name="storage">
        /// Storage is the amount of storage (in MB or units as defined by the platform) allocated to each replica
        /// </param>
        /// <param name="updatedAt">
        /// UpdatedAt is the ISO8601 timestamp when this deployment was last updated
        /// </param>
        /// <param name="volumes">
        /// Volumes is a list of volume mounts for this deployment
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentResponseItem(
            global::System.Collections.Generic.IList<string>? args,
            global::System.Collections.Generic.Dictionary<string, string>? autoscaling,
            global::System.Collections.Generic.IList<string>? command,
            double? cpu,
            string? createdAt,
            string? description,
            int? desiredReplicas,
            global::System.Collections.Generic.IList<global::Together.EnvironmentVariable>? environmentVariables,
            int? gpuCount,
            global::Together.DeploymentResponseItemGpuType? gpuType,
            string? healthCheckPath,
            string? id,
            string? image,
            int? maxReplicas,
            double? memory,
            int? minReplicas,
            string? name,
            string? @object,
            int? port,
            int? readyReplicas,
            global::System.Collections.Generic.Dictionary<string, global::Together.ReplicaEvent>? replicaEvents,
            global::Together.DeploymentStatus? status,
            int? storage,
            string? updatedAt,
            global::System.Collections.Generic.IList<global::Together.VolumeMount>? volumes)
        {
            this.Args = args;
            this.Autoscaling = autoscaling;
            this.Command = command;
            this.Cpu = cpu;
            this.CreatedAt = createdAt;
            this.Description = description;
            this.DesiredReplicas = desiredReplicas;
            this.EnvironmentVariables = environmentVariables;
            this.GpuCount = gpuCount;
            this.GpuType = gpuType;
            this.HealthCheckPath = healthCheckPath;
            this.Id = id;
            this.Image = image;
            this.MaxReplicas = maxReplicas;
            this.Memory = memory;
            this.MinReplicas = minReplicas;
            this.Name = name;
            this.Object = @object;
            this.Port = port;
            this.ReadyReplicas = readyReplicas;
            this.ReplicaEvents = replicaEvents;
            this.Status = status;
            this.Storage = storage;
            this.UpdatedAt = updatedAt;
            this.Volumes = volumes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentResponseItem" /> class.
        /// </summary>
        public DeploymentResponseItem()
        {
        }
    }
}