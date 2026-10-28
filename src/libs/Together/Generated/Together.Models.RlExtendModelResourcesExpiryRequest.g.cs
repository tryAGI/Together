
#nullable enable

namespace Together
{
    /// <summary>
    /// Request to keep a model resource from stopping for inactivity
    /// </summary>
    public sealed partial class RlExtendModelResourcesExpiryRequest
    {
        /// <summary>
        /// Seconds from now the resource must not stop for inactivity.<br/>
        /// Example: 7200
        /// </summary>
        /// <example>7200</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Seconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlExtendModelResourcesExpiryRequest" /> class.
        /// </summary>
        /// <param name="seconds">
        /// Seconds from now the resource must not stop for inactivity.<br/>
        /// Example: 7200
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlExtendModelResourcesExpiryRequest(
            int seconds)
        {
            this.Seconds = seconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlExtendModelResourcesExpiryRequest" /> class.
        /// </summary>
        public RlExtendModelResourcesExpiryRequest()
        {
        }

    }
}