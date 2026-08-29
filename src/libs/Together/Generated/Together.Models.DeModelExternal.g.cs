
#nullable enable

namespace Together
{
    /// <summary>
    /// External source associated with a model.
    /// </summary>
    public sealed partial class DeModelExternal
    {
        /// <summary>
        /// Canonical external URL for the model, such as its Hugging Face repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeModelExternal" /> class.
        /// </summary>
        /// <param name="url">
        /// Canonical external URL for the model, such as its Hugging Face repository.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeModelExternal(
            string? url)
        {
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeModelExternal" /> class.
        /// </summary>
        public DeModelExternal()
        {
        }

    }
}