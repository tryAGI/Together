
#nullable enable

namespace Together
{
    /// <summary>
    /// Server-resolved configuration for a quantization job.<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class QuantizationPipelineConfiguration
    {
        /// <summary>
        /// User whose scope is used to fetch the adapter weights.<br/>
        /// Example: user_CKfewYkQBpaEmN7wuQS3W
        /// </summary>
        /// <example>user_CKfewYkQBpaEmN7wuQS3W</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Project that owns the adapter.<br/>
        /// Example: proj_CczF9KYFantA84sNYDTJd
        /// </summary>
        /// <example>proj_CczF9KYFantA84sNYDTJd</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("adapter_project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AdapterProjectId { get; set; }

        /// <summary>
        /// Adapter revision selected for preparation.<br/>
        /// Example: rv_CeERyXMBQCJTRC1yqGTpk
        /// </summary>
        /// <example>rv_CeERyXMBQCJTRC1yqGTpk</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("adapter_revision_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AdapterRevisionId { get; set; }

        /// <summary>
        /// Qualified adapter model name.<br/>
        /// Example: ft-qa-artifacts/glm-5.3-e2e-test-adapter
        /// </summary>
        /// <example>ft-qa-artifacts/glm-5.3-e2e-test-adapter</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("adapter_model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AdapterModelName { get; set; }

        /// <summary>
        /// Model object ID of the adapter's base model.<br/>
        /// Example: ml_CbJ9yCnij7A47b1xkpioB
        /// </summary>
        /// <example>ml_CbJ9yCnij7A47b1xkpioB</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_object_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseObjectId { get; set; }

        /// <summary>
        /// Revision ID of the adapter's base model.<br/>
        /// Example: rv_CbJ9yNrws93VQrZum1fTE
        /// </summary>
        /// <example>rv_CbJ9yNrws93VQrZum1fTE</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_revision_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseRevisionId { get; set; }

        /// <summary>
        /// Qualified name of the base model.<br/>
        /// Example: zai-org/GLM-5.3-NVFP4
        /// </summary>
        /// <example>zai-org/GLM-5.3-NVFP4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseModelName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QuantizationPipelineConfiguration" /> class.
        /// </summary>
        /// <param name="userId">
        /// User whose scope is used to fetch the adapter weights.<br/>
        /// Example: user_CKfewYkQBpaEmN7wuQS3W
        /// </param>
        /// <param name="adapterProjectId">
        /// Project that owns the adapter.<br/>
        /// Example: proj_CczF9KYFantA84sNYDTJd
        /// </param>
        /// <param name="adapterRevisionId">
        /// Adapter revision selected for preparation.<br/>
        /// Example: rv_CeERyXMBQCJTRC1yqGTpk
        /// </param>
        /// <param name="adapterModelName">
        /// Qualified adapter model name.<br/>
        /// Example: ft-qa-artifacts/glm-5.3-e2e-test-adapter
        /// </param>
        /// <param name="baseObjectId">
        /// Model object ID of the adapter's base model.<br/>
        /// Example: ml_CbJ9yCnij7A47b1xkpioB
        /// </param>
        /// <param name="baseRevisionId">
        /// Revision ID of the adapter's base model.<br/>
        /// Example: rv_CbJ9yNrws93VQrZum1fTE
        /// </param>
        /// <param name="baseModelName">
        /// Qualified name of the base model.<br/>
        /// Example: zai-org/GLM-5.3-NVFP4
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QuantizationPipelineConfiguration(
            string userId,
            string adapterProjectId,
            string adapterRevisionId,
            string adapterModelName,
            string baseObjectId,
            string baseRevisionId,
            string baseModelName)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.AdapterProjectId = adapterProjectId ?? throw new global::System.ArgumentNullException(nameof(adapterProjectId));
            this.AdapterRevisionId = adapterRevisionId ?? throw new global::System.ArgumentNullException(nameof(adapterRevisionId));
            this.AdapterModelName = adapterModelName ?? throw new global::System.ArgumentNullException(nameof(adapterModelName));
            this.BaseObjectId = baseObjectId ?? throw new global::System.ArgumentNullException(nameof(baseObjectId));
            this.BaseRevisionId = baseRevisionId ?? throw new global::System.ArgumentNullException(nameof(baseRevisionId));
            this.BaseModelName = baseModelName ?? throw new global::System.ArgumentNullException(nameof(baseModelName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuantizationPipelineConfiguration" /> class.
        /// </summary>
        public QuantizationPipelineConfiguration()
        {
        }

    }
}