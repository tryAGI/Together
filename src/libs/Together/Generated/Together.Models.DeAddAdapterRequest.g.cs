
#nullable enable

namespace Together
{
    /// <summary>
    /// Configuration for attaching a LoRA adapter to a deployment that has adapter loading enabled.
    /// </summary>
    public sealed partial class DeAddAdapterRequest
    {
        /// <summary>
        /// Adapter model identifier to attach.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adapterModelId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AdapterModelId { get; set; }

        /// <summary>
        /// Optional adapter revision to pin. If omitted, the latest revision is resolved at request time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adapterRevisionId")]
        public string? AdapterRevisionId { get; set; }

        /// <summary>
        /// Whether to evict the oldest adapter if the deployment is at adapter capacity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("force")]
        public bool? Force { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeAddAdapterRequest" /> class.
        /// </summary>
        /// <param name="adapterModelId">
        /// Adapter model identifier to attach.
        /// </param>
        /// <param name="adapterRevisionId">
        /// Optional adapter revision to pin. If omitted, the latest revision is resolved at request time.
        /// </param>
        /// <param name="force">
        /// Whether to evict the oldest adapter if the deployment is at adapter capacity.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeAddAdapterRequest(
            string adapterModelId,
            string? adapterRevisionId,
            bool? force)
        {
            this.AdapterModelId = adapterModelId ?? throw new global::System.ArgumentNullException(nameof(adapterModelId));
            this.AdapterRevisionId = adapterRevisionId;
            this.Force = force;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeAddAdapterRequest" /> class.
        /// </summary>
        public DeAddAdapterRequest()
        {
        }

    }
}