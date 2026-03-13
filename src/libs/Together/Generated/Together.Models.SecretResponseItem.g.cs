
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SecretResponseItem
    {
        /// <summary>
        /// CreatedAt is the ISO8601 timestamp when this secret was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// CreatedBy is the identifier of the user who created this secret
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Description is a human-readable description of the secret's purpose
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// ID is the unique identifier for this secret
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// LastUpdatedBy is the identifier of the user who last updated this secret
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_by")]
        public string? LastUpdatedBy { get; set; }

        /// <summary>
        /// Name is the name/key of the secret
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The object type, which is always `secret`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// UpdatedAt is the ISO8601 timestamp when this secret was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretResponseItem" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// CreatedAt is the ISO8601 timestamp when this secret was created
        /// </param>
        /// <param name="createdBy">
        /// CreatedBy is the identifier of the user who created this secret
        /// </param>
        /// <param name="description">
        /// Description is a human-readable description of the secret's purpose
        /// </param>
        /// <param name="id">
        /// ID is the unique identifier for this secret
        /// </param>
        /// <param name="lastUpdatedBy">
        /// LastUpdatedBy is the identifier of the user who last updated this secret
        /// </param>
        /// <param name="name">
        /// Name is the name/key of the secret
        /// </param>
        /// <param name="object">
        /// The object type, which is always `secret`.
        /// </param>
        /// <param name="updatedAt">
        /// UpdatedAt is the ISO8601 timestamp when this secret was last updated
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecretResponseItem(
            string? createdAt,
            string? createdBy,
            string? description,
            string? id,
            string? lastUpdatedBy,
            string? name,
            string? @object,
            string? updatedAt)
        {
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.Description = description;
            this.Id = id;
            this.LastUpdatedBy = lastUpdatedBy;
            this.Name = name;
            this.Object = @object;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretResponseItem" /> class.
        /// </summary>
        public SecretResponseItem()
        {
        }
    }
}