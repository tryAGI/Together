
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateSecretRequest
    {
        /// <summary>
        /// Description is an optional human-readable description of the secret's purpose (max 500 characters)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Name is the new unique identifier for the secret. Can contain alphanumeric characters, underscores, hyphens, forward slashes, and periods (1-100 characters)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// ProjectID is ignored - the project is automatically determined from your authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Value is the new sensitive data to store securely. Updating this will replace the existing secret value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSecretRequest" /> class.
        /// </summary>
        /// <param name="description">
        /// Description is an optional human-readable description of the secret's purpose (max 500 characters)
        /// </param>
        /// <param name="name">
        /// Name is the new unique identifier for the secret. Can contain alphanumeric characters, underscores, hyphens, forward slashes, and periods (1-100 characters)
        /// </param>
        /// <param name="projectId">
        /// ProjectID is ignored - the project is automatically determined from your authentication
        /// </param>
        /// <param name="value">
        /// Value is the new sensitive data to store securely. Updating this will replace the existing secret value
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSecretRequest(
            string? description,
            string? name,
            string? projectId,
            string? value)
        {
            this.Description = description;
            this.Name = name;
            this.ProjectId = projectId;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSecretRequest" /> class.
        /// </summary>
        public UpdateSecretRequest()
        {
        }
    }
}