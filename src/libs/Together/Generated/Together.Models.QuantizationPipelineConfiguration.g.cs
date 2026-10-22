
#nullable enable

namespace Together
{
    /// <summary>
    /// Server-resolved configuration for a quantization job. The `adapter_*` fields are the deprecated names of the `model_*` ones, with the same values.<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class QuantizationPipelineConfiguration
    {
        /// <summary>
        /// User whose scope is used to fetch the model weights.<br/>
        /// Example: user_CKfewYkQBpaEmN7wuQS3W
        /// </summary>
        /// <example>user_CKfewYkQBpaEmN7wuQS3W</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Project the model belongs to.<br/>
        /// Example: proj_CczF9KYFantA84sNYDTJd
        /// </summary>
        /// <example>proj_CczF9KYFantA84sNYDTJd</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelProjectId { get; set; }

        /// <summary>
        /// Revision of the model selected for preparation.<br/>
        /// Example: rv_CeERyXMBQCJTRC1yqGTpk
        /// </summary>
        /// <example>rv_CeERyXMBQCJTRC1yqGTpk</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_revision_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelRevisionId { get; set; }

        /// <summary>
        /// Qualified name of the model, which the produced model is named after.<br/>
        /// Example: ft-qa-artifacts/glm-5.3-e2e-test-adapter
        /// </summary>
        /// <example>ft-qa-artifacts/glm-5.3-e2e-test-adapter</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// Model object ID of the base model the prepared model was fine-tuned from.<br/>
        /// Example: ml_CbJ9yCnij7A47b1xkpioB
        /// </summary>
        /// <example>ml_CbJ9yCnij7A47b1xkpioB</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_object_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseObjectId { get; set; }

        /// <summary>
        /// Revision ID of that base model.<br/>
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
        /// User whose scope is used to fetch the model weights.<br/>
        /// Example: user_CKfewYkQBpaEmN7wuQS3W
        /// </param>
        /// <param name="modelProjectId">
        /// Project the model belongs to.<br/>
        /// Example: proj_CczF9KYFantA84sNYDTJd
        /// </param>
        /// <param name="modelRevisionId">
        /// Revision of the model selected for preparation.<br/>
        /// Example: rv_CeERyXMBQCJTRC1yqGTpk
        /// </param>
        /// <param name="modelName">
        /// Qualified name of the model, which the produced model is named after.<br/>
        /// Example: ft-qa-artifacts/glm-5.3-e2e-test-adapter
        /// </param>
        /// <param name="baseObjectId">
        /// Model object ID of the base model the prepared model was fine-tuned from.<br/>
        /// Example: ml_CbJ9yCnij7A47b1xkpioB
        /// </param>
        /// <param name="baseRevisionId">
        /// Revision ID of that base model.<br/>
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
            string modelProjectId,
            string modelRevisionId,
            string modelName,
            string baseObjectId,
            string baseRevisionId,
            string baseModelName)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.ModelProjectId = modelProjectId ?? throw new global::System.ArgumentNullException(nameof(modelProjectId));
            this.ModelRevisionId = modelRevisionId ?? throw new global::System.ArgumentNullException(nameof(modelRevisionId));
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
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