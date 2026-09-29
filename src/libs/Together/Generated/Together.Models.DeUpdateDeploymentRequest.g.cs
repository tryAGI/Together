
#nullable enable

namespace Together
{
    /// <summary>
    /// Mutable deployment settings. Use the resource-name fields or their deprecated ID alternatives for a model or config change, but not both.
    /// </summary>
    public sealed partial class DeUpdateDeploymentRequest
    {
        /// <summary>
        /// Updated endpoint string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Updated autoscaling configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling")]
        public global::Together.DeAutoscaling? Autoscaling { get; set; }

        /// <summary>
        /// Updated inactive timeout in minutes. Use 0 to disable automatic stopping; otherwise accepted values are 30 through 1440.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inactiveTimeout")]
        public int? InactiveTimeout { get; set; }

        /// <summary>
        /// Updated maximum number of inference requests that may be in flight to a single replica. Values above the deployment config's per-replica concurrency limit minus one are reduced on update; 0 means unlimited when the config limit is 1 or less. Changes take effect without restarting replicas.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxConcurrentRequestsPerReplica")]
        public string? MaxConcurrentRequestsPerReplica { get; set; }

        /// <summary>
        /// Current deployment version. The update is rejected if this value no longer matches.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("etag")]
        public string? Etag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeUpdateDeploymentRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Updated endpoint string.
        /// </param>
        /// <param name="autoscaling">
        /// Updated autoscaling configuration.
        /// </param>
        /// <param name="inactiveTimeout">
        /// Updated inactive timeout in minutes. Use 0 to disable automatic stopping; otherwise accepted values are 30 through 1440.
        /// </param>
        /// <param name="maxConcurrentRequestsPerReplica">
        /// Updated maximum number of inference requests that may be in flight to a single replica. Values above the deployment config's per-replica concurrency limit minus one are reduced on update; 0 means unlimited when the config limit is 1 or less. Changes take effect without restarting replicas.
        /// </param>
        /// <param name="etag">
        /// Current deployment version. The update is rejected if this value no longer matches.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeUpdateDeploymentRequest(
            string? name,
            global::Together.DeAutoscaling? autoscaling,
            int? inactiveTimeout,
            string? maxConcurrentRequestsPerReplica,
            string? etag)
        {
            this.Name = name;
            this.Autoscaling = autoscaling;
            this.InactiveTimeout = inactiveTimeout;
            this.MaxConcurrentRequestsPerReplica = maxConcurrentRequestsPerReplica;
            this.Etag = etag;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeUpdateDeploymentRequest" /> class.
        /// </summary>
        public DeUpdateDeploymentRequest()
        {
        }

    }
}