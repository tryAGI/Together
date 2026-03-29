
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSecretRequest
    {
        /// <summary>
        /// Description is an optional human-readable description of the secret's purpose (max 500 characters)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Name is the unique identifier for the secret. Can contain alphanumeric characters, underscores, hyphens, forward slashes, and periods (1-100 characters)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// ProjectID is ignored - the project is automatically determined from your authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Value is the sensitive data to store securely (e.g., API keys, passwords, tokens). This value will be encrypted at rest
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
        /// Initializes a new instance of the <see cref="CreateSecretRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name is the unique identifier for the secret. Can contain alphanumeric characters, underscores, hyphens, forward slashes, and periods (1-100 characters)
        /// </param>
        /// <param name="value">
        /// Value is the sensitive data to store securely (e.g., API keys, passwords, tokens). This value will be encrypted at rest
        /// </param>
        /// <param name="description">
        /// Description is an optional human-readable description of the secret's purpose (max 500 characters)
        /// </param>
        /// <param name="projectId">
        /// ProjectID is ignored - the project is automatically determined from your authentication
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSecretRequest(
            string name,
            string value,
            string? description,
            string? projectId)
        {
            this.Description = description;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ProjectId = projectId;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSecretRequest" /> class.
        /// </summary>
        public CreateSecretRequest()
        {
        }
    }
}