
#nullable enable

namespace Together
{
    /// <summary>
    /// Represents a model with its available voices.
    /// </summary>
    public sealed partial class ModelVoices
    {
        /// <summary>
        /// Model name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// List of available voices for the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.ModelVoicesVoice> Voices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelVoices" /> class.
        /// </summary>
        /// <param name="model">
        /// Model name.
        /// </param>
        /// <param name="voices">
        /// List of available voices for the model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelVoices(
            string model,
            global::System.Collections.Generic.IList<global::Together.ModelVoicesVoice> voices)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Voices = voices ?? throw new global::System.ArgumentNullException(nameof(voices));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelVoices" /> class.
        /// </summary>
        public ModelVoices()
        {
        }
    }
}