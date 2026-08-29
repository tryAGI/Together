
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InstanceClusterConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("load_balancer")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.InstanceClusterConfigLoadBalancerJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.InstanceClusterConfigLoadBalancer LoadBalancer { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kubernetes_dashboard_enabled")]
        public bool? KubernetesDashboardEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jumphost_enabled")]
        public bool? JumphostEnabled { get; set; }

        /// <summary>
        /// SlurmStartupScripts carries optional Slurm lifecycle scripts (prolog/epilog, init, extra conf).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slurm_startup_scripts")]
        public global::Together.SlurmStartupScripts? SlurmStartupScripts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ingress")]
        public global::Together.ClusterIngressConfig? Ingress { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("observability")]
        public global::Together.ObservabilityConfig? Observability { get; set; }

        /// <summary>
        /// NVIDIA GPU Operator chart/version for the tenant cluster (e.g. v24.6.2). When omitted, a service default is applied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_operator_version")]
        public string? GpuOperatorVersion { get; set; }

        /// <summary>
        /// NVIDIA Network Operator chart/version for the tenant cluster (e.g. v24.7.0). When omitted, a service default is applied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("network_operator_version")]
        public string? NetworkOperatorVersion { get; set; }

        /// <summary>
        /// Whether this cluster uses a per-cluster SSH certificate authority for OIDC-signed SSH access.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssh_ca_enabled")]
        public bool? SshCaEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceClusterConfig" /> class.
        /// </summary>
        /// <param name="loadBalancer"></param>
        /// <param name="kubernetesDashboardEnabled"></param>
        /// <param name="jumphostEnabled"></param>
        /// <param name="slurmStartupScripts">
        /// SlurmStartupScripts carries optional Slurm lifecycle scripts (prolog/epilog, init, extra conf).
        /// </param>
        /// <param name="ingress"></param>
        /// <param name="observability"></param>
        /// <param name="gpuOperatorVersion">
        /// NVIDIA GPU Operator chart/version for the tenant cluster (e.g. v24.6.2). When omitted, a service default is applied.
        /// </param>
        /// <param name="networkOperatorVersion">
        /// NVIDIA Network Operator chart/version for the tenant cluster (e.g. v24.7.0). When omitted, a service default is applied.
        /// </param>
        /// <param name="sshCaEnabled">
        /// Whether this cluster uses a per-cluster SSH certificate authority for OIDC-signed SSH access.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InstanceClusterConfig(
            global::Together.InstanceClusterConfigLoadBalancer loadBalancer,
            bool? kubernetesDashboardEnabled,
            bool? jumphostEnabled,
            global::Together.SlurmStartupScripts? slurmStartupScripts,
            global::Together.ClusterIngressConfig? ingress,
            global::Together.ObservabilityConfig? observability,
            string? gpuOperatorVersion,
            string? networkOperatorVersion,
            bool? sshCaEnabled)
        {
            this.LoadBalancer = loadBalancer;
            this.KubernetesDashboardEnabled = kubernetesDashboardEnabled;
            this.JumphostEnabled = jumphostEnabled;
            this.SlurmStartupScripts = slurmStartupScripts;
            this.Ingress = ingress;
            this.Observability = observability;
            this.GpuOperatorVersion = gpuOperatorVersion;
            this.NetworkOperatorVersion = networkOperatorVersion;
            this.SshCaEnabled = sshCaEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceClusterConfig" /> class.
        /// </summary>
        public InstanceClusterConfig()
        {
        }

    }
}