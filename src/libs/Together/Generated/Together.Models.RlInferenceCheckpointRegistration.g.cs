
#nullable enable

namespace Together
{
    /// <summary>
    /// Where an inference checkpoint's weights are stored in the Together model registry. At least one of `model` and `adapter` is set.
    /// </summary>
    public sealed partial class RlInferenceCheckpointRegistration
    {
        /// <summary>
        /// Full model weights. Set for full-weight training, and for LoRA training on custom base weights, where the merged model is deployed instead of the adapter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public global::Together.RlModelRegistryArtifact? Model { get; set; }

        /// <summary>
        /// LoRA adapter weights, deployed on top of the base model. Set for LoRA training on the base model's own weights.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adapter")]
        public global::Together.RlModelRegistryArtifact? Adapter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlInferenceCheckpointRegistration" /> class.
        /// </summary>
        /// <param name="model">
        /// Full model weights. Set for full-weight training, and for LoRA training on custom base weights, where the merged model is deployed instead of the adapter.
        /// </param>
        /// <param name="adapter">
        /// LoRA adapter weights, deployed on top of the base model. Set for LoRA training on the base model's own weights.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlInferenceCheckpointRegistration(
            global::Together.RlModelRegistryArtifact? model,
            global::Together.RlModelRegistryArtifact? adapter)
        {
            this.Model = model;
            this.Adapter = adapter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlInferenceCheckpointRegistration" /> class.
        /// </summary>
        public RlInferenceCheckpointRegistration()
        {
        }

    }
}