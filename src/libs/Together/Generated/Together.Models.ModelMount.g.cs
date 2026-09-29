
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelMount
    {
        /// <summary>
        /// Model registry identifier (`ml_...`) whose weights are mounted.<br/>
        /// Example: ml_CbJNwQC2ZqCU2iFT3mrCh
        /// </summary>
        /// <example>ml_CbJNwQC2ZqCU2iFT3mrCh</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// Container path where model weights are mounted, such as `/models`.<br/>
        /// Example: /models
        /// </summary>
        /// <example>/models</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mount_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MountPath { get; set; }

        /// <summary>
        /// Optional validated revision identifier (`rv_...`) to pin; defaults to the latest validated revision.<br/>
        /// Example: rv_8kQ2mN4pL7xR9tV1wY3zA
        /// </summary>
        /// <example>rv_8kQ2mN4pL7xR9tV1wY3zA</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision_id")]
        public string? RevisionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelMount" /> class.
        /// </summary>
        /// <param name="modelId">
        /// Model registry identifier (`ml_...`) whose weights are mounted.<br/>
        /// Example: ml_CbJNwQC2ZqCU2iFT3mrCh
        /// </param>
        /// <param name="mountPath">
        /// Container path where model weights are mounted, such as `/models`.<br/>
        /// Example: /models
        /// </param>
        /// <param name="revisionId">
        /// Optional validated revision identifier (`rv_...`) to pin; defaults to the latest validated revision.<br/>
        /// Example: rv_8kQ2mN4pL7xR9tV1wY3zA
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelMount(
            string modelId,
            string mountPath,
            string? revisionId)
        {
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.MountPath = mountPath ?? throw new global::System.ArgumentNullException(nameof(mountPath));
            this.RevisionId = revisionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelMount" /> class.
        /// </summary>
        public ModelMount()
        {
        }

    }
}