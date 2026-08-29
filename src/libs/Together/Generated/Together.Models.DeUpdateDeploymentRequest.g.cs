
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
        /// <param name="etag">
        /// Current deployment version. The update is rejected if this value no longer matches.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeUpdateDeploymentRequest(
            string? name,
            global::Together.DeAutoscaling? autoscaling,
            string? etag)
        {
            this.Name = name;
            this.Autoscaling = autoscaling;
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