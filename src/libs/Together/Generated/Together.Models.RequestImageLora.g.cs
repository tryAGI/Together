
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestImageLora
    {
        /// <summary>
        /// The URL of the LoRA to apply (e.g. https://huggingface.co/strangerzonehf/Flux-Midjourney-Mix2-LoRA).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// The strength of the LoRA's influence. Most LoRA's recommend a value of 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Scale { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestImageLora" /> class.
        /// </summary>
        /// <param name="path">
        /// The URL of the LoRA to apply (e.g. https://huggingface.co/strangerzonehf/Flux-Midjourney-Mix2-LoRA).
        /// </param>
        /// <param name="scale">
        /// The strength of the LoRA's influence. Most LoRA's recommend a value of 1.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RequestImageLora(
            string path,
            double scale)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Scale = scale;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestImageLora" /> class.
        /// </summary>
        public RequestImageLora()
        {
        }
    }
}