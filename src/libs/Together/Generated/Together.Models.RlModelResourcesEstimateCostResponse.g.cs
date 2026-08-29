
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RlModelResourcesEstimateCostResponse
    {
        /// <summary>
        /// Estimated on-demand price per hour in the currency's major unit.<br/>
        /// Example: 56
        /// </summary>
        /// <example>56</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("price_per_hour")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PricePerHour { get; set; }

        /// <summary>
        /// ISO 4217 currency code.<br/>
        /// Example: USD
        /// </summary>
        /// <example>USD</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Currency { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlModelResourcesEstimateCostResponse" /> class.
        /// </summary>
        /// <param name="pricePerHour">
        /// Estimated on-demand price per hour in the currency's major unit.<br/>
        /// Example: 56
        /// </param>
        /// <param name="currency">
        /// ISO 4217 currency code.<br/>
        /// Example: USD
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlModelResourcesEstimateCostResponse(
            double pricePerHour,
            string currency)
        {
            this.PricePerHour = pricePerHour;
            this.Currency = currency ?? throw new global::System.ArgumentNullException(nameof(currency));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlModelResourcesEstimateCostResponse" /> class.
        /// </summary>
        public RlModelResourcesEstimateCostResponse()
        {
        }

    }
}