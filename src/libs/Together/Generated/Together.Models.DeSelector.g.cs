
#nullable enable

namespace Together
{
    /// <summary>
    /// Hardware or runtime requirement expressed as a key-value pair.
    /// </summary>
    public sealed partial class DeSelector
    {
        /// <summary>
        /// Selector name, such as GPU type, GPU count, or optimization profile.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Required value for the selector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeSelector" /> class.
        /// </summary>
        /// <param name="key">
        /// Selector name, such as GPU type, GPU count, or optimization profile.
        /// </param>
        /// <param name="value">
        /// Required value for the selector.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeSelector(
            string key,
            string value)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeSelector" /> class.
        /// </summary>
        public DeSelector()
        {
        }

    }
}