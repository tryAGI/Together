
#nullable enable

namespace Together
{
    /// <summary>
    /// Hardware or runtime requirement associated with a config revision.
    /// </summary>
    public sealed partial class DeConfigSelector
    {
        /// <summary>
        /// Unique selector identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Selector name, such as GPU type, GPU count, or optimization profile.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Required value for the selector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeConfigSelector" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique selector identifier.
        /// </param>
        /// <param name="key">
        /// Selector name, such as GPU type, GPU count, or optimization profile.
        /// </param>
        /// <param name="value">
        /// Required value for the selector.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeConfigSelector(
            string? id,
            string? key,
            string? value)
        {
            this.Id = id;
            this.Key = key;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeConfigSelector" /> class.
        /// </summary>
        public DeConfigSelector()
        {
        }

    }
}