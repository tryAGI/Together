
#nullable enable

namespace Together
{
    /// <summary>
    /// License metadata associated with a model.
    /// </summary>
    public sealed partial class DeModelLicense
    {
        /// <summary>
        /// License identifier or name reported by the model source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeModelLicense" /> class.
        /// </summary>
        /// <param name="name">
        /// License identifier or name reported by the model source.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeModelLicense(
            string? name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeModelLicense" /> class.
        /// </summary>
        public DeModelLicense()
        {
        }

    }
}