
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RlModelInput
    {
        /// <summary>
        /// Input chunks for the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::Together.RlInputChunk> Chunks { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlModelInput" /> class.
        /// </summary>
        /// <param name="chunks">
        /// Input chunks for the model
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlModelInput(
            global::System.Collections.Generic.IList<global::Together.RlInputChunk> chunks)
        {
            this.Chunks = chunks ?? throw new global::System.ArgumentNullException(nameof(chunks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlModelInput" /> class.
        /// </summary>
        public RlModelInput()
        {
        }
    }
}