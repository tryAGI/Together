
#nullable enable

namespace Together
{
    /// <summary>
    /// Principal that should be allowed to send inference requests to the endpoint.
    /// </summary>
    public sealed partial class DeGrantEndpointAccessRequest
    {
        /// <summary>
        /// Type of principal to grant. Supported values are `project`, `api_key`, and `organization`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("principalType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PrincipalType { get; set; }

        /// <summary>
        /// Identifier of the principal to grant access to.
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
        /// Initializes a new instance of the <see cref="DeGrantEndpointAccessRequest" /> class.
        /// </summary>
        /// <param name="principalType">
        /// Type of principal to grant. Supported values are `project`, `api_key`, and `organization`.
        /// </param>
        /// <param name="principalId">
        /// Identifier of the principal to grant access to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeGrantEndpointAccessRequest(
            string principalType,
            string principalId)
        {
            this.PrincipalType = principalType ?? throw new global::System.ArgumentNullException(nameof(principalType));
            this.PrincipalId = principalId ?? throw new global::System.ArgumentNullException(nameof(principalId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeGrantEndpointAccessRequest" /> class.
        /// </summary>
        public DeGrantEndpointAccessRequest()
        {
        }

    }
}