
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OIDCConfig
    {
        /// <summary>
        /// OIDC issuer URL for authentication. For example, https://accounts.google.com
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuer_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssuerUrl { get; set; }

        /// <summary>
        /// OIDC client ID for authentication.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// JWT claim to use as the username. For example, 'sub' or 'email'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username_claim")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UsernameClaim { get; set; }

        /// <summary>
        /// Prefix to add to the username claim to form the final username. For example, 'oidc:'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username_prefix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UsernamePrefix { get; set; }

        /// <summary>
        /// JWT claim to use for user groups. For example, 'groups'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_claim")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GroupClaim { get; set; }

        /// <summary>
        /// Prefix to add to the group claim to form the final group name. For example, 'oidc:'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_prefix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GroupPrefix { get; set; }

        /// <summary>
        /// CA certificate in PEM format to validate the OIDC issuer's TLS certificate. This field is optional but recommended if the issuer uses a private CA or self-signed certificate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ca_cert")]
        public string? CaCert { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OIDCConfig" /> class.
        /// </summary>
        /// <param name="issuerUrl">
        /// OIDC issuer URL for authentication. For example, https://accounts.google.com
        /// </param>
        /// <param name="clientId">
        /// OIDC client ID for authentication.
        /// </param>
        /// <param name="usernameClaim">
        /// JWT claim to use as the username. For example, 'sub' or 'email'
        /// </param>
        /// <param name="usernamePrefix">
        /// Prefix to add to the username claim to form the final username. For example, 'oidc:'
        /// </param>
        /// <param name="groupClaim">
        /// JWT claim to use for user groups. For example, 'groups'
        /// </param>
        /// <param name="groupPrefix">
        /// Prefix to add to the group claim to form the final group name. For example, 'oidc:'
        /// </param>
        /// <param name="caCert">
        /// CA certificate in PEM format to validate the OIDC issuer's TLS certificate. This field is optional but recommended if the issuer uses a private CA or self-signed certificate.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OIDCConfig(
            string issuerUrl,
            string clientId,
            string usernameClaim,
            string usernamePrefix,
            string groupClaim,
            string groupPrefix,
            string? caCert)
        {
            this.IssuerUrl = issuerUrl ?? throw new global::System.ArgumentNullException(nameof(issuerUrl));
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.UsernameClaim = usernameClaim ?? throw new global::System.ArgumentNullException(nameof(usernameClaim));
            this.UsernamePrefix = usernamePrefix ?? throw new global::System.ArgumentNullException(nameof(usernamePrefix));
            this.GroupClaim = groupClaim ?? throw new global::System.ArgumentNullException(nameof(groupClaim));
            this.GroupPrefix = groupPrefix ?? throw new global::System.ArgumentNullException(nameof(groupPrefix));
            this.CaCert = caCert;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OIDCConfig" /> class.
        /// </summary>
        public OIDCConfig()
        {
        }

    }
}