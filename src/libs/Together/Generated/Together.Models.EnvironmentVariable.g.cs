
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnvironmentVariable
    {
        /// <summary>
        /// Name is the environment variable name (e.g., "DATABASE_URL"). Must start with a letter or underscore, followed by letters, numbers, or underscores
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Value is the plain text value for the environment variable. Use this for non-sensitive values. Either Value or ValueFromSecret must be set, but not both
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// ValueFromSecret references a secret by name or ID to use as the value. Use this for sensitive values like API keys or passwords. Either Value or ValueFromSecret must be set, but not both
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_from_secret")]
        public string? ValueFromSecret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentVariable" /> class.
        /// </summary>
        /// <param name="name">
        /// Name is the environment variable name (e.g., "DATABASE_URL"). Must start with a letter or underscore, followed by letters, numbers, or underscores
        /// </param>
        /// <param name="value">
        /// Value is the plain text value for the environment variable. Use this for non-sensitive values. Either Value or ValueFromSecret must be set, but not both
        /// </param>
        /// <param name="valueFromSecret">
        /// ValueFromSecret references a secret by name or ID to use as the value. Use this for sensitive values like API keys or passwords. Either Value or ValueFromSecret must be set, but not both
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentVariable(
            string name,
            string? value,
            string? valueFromSecret)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Value = value;
            this.ValueFromSecret = valueFromSecret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentVariable" /> class.
        /// </summary>
        public EnvironmentVariable()
        {
        }
    }
}