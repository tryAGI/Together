
#nullable enable

namespace Together
{
    /// <summary>
    /// Project, API key, or organization allowed to call an endpoint.
    /// </summary>
    public sealed partial class DeAccessEntry
    {
        /// <summary>
        /// Principal type. Supported values are `project`, `api_key`, and `organization`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("principalType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PrincipalType { get; set; }

        /// <summary>
        /// Identifier of the principal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("principalId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PrincipalId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeAccessEntry" /> class.
        /// </summary>
        /// <param name="principalType">
        /// Principal type. Supported values are `project`, `api_key`, and `organization`.
        /// </param>
        /// <param name="principalId">
        /// Identifier of the principal.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeAccessEntry(
            string principalType,
            string principalId)
        {
            this.PrincipalType = principalType ?? throw new global::System.ArgumentNullException(nameof(principalType));
            this.PrincipalId = principalId ?? throw new global::System.ArgumentNullException(nameof(principalId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeAccessEntry" /> class.
        /// </summary>
        public DeAccessEntry()
        {
        }

    }
}