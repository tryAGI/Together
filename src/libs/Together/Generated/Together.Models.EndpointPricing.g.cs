
#nullable enable

namespace Together
{
    /// <summary>
    /// Pricing details for using an endpoint
    /// </summary>
    public sealed partial class EndpointPricing
    {
        /// <summary>
        /// Cost per minute of endpoint uptime in cents<br/>
        /// Example: 5.42F
        /// </summary>
        /// <example>5.42F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cents_per_minute")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float CentsPerMinute { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointPricing" /> class.
        /// </summary>
        /// <param name="centsPerMinute">
        /// Cost per minute of endpoint uptime in cents<br/>
        /// Example: 5.42F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EndpointPricing(
            float centsPerMinute)
        {
            this.CentsPerMinute = centsPerMinute;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointPricing" /> class.
        /// </summary>
        public EndpointPricing()
        {
        }
    }
}