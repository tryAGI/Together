
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BillingUsageLineItem
    {
        /// <summary>
        /// Metronome product name (e.g. 'Serverless Inference - Input Tokens').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProductName { get; set; }

        /// <summary>
        /// Total usage for the window in the product's native unit (GPU-hours, tokens, ...) as a decimal string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Quantity { get; set; }

        /// <summary>
        /// Per-unit price in USD as a decimal string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit_price")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UnitPrice { get; set; }

        /// <summary>
        /// Total cost for this line item in USD as a decimal string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cost { get; set; }

        /// <summary>
        /// Rate-determining dimensions (varies by product). Passthrough from Metronome pricing group values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing_dimensions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> PricingDimensions { get; set; }

        /// <summary>
        /// Resource identifiers for attribution, varying by product.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingUsageLineItem" /> class.
        /// </summary>
        /// <param name="productName">
        /// Metronome product name (e.g. 'Serverless Inference - Input Tokens').
        /// </param>
        /// <param name="quantity">
        /// Total usage for the window in the product's native unit (GPU-hours, tokens, ...) as a decimal string.
        /// </param>
        /// <param name="unitPrice">
        /// Per-unit price in USD as a decimal string.
        /// </param>
        /// <param name="cost">
        /// Total cost for this line item in USD as a decimal string.
        /// </param>
        /// <param name="pricingDimensions">
        /// Rate-determining dimensions (varies by product). Passthrough from Metronome pricing group values.
        /// </param>
        /// <param name="attributes">
        /// Resource identifiers for attribution, varying by product.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingUsageLineItem(
            string productName,
            string quantity,
            string unitPrice,
            string cost,
            global::System.Collections.Generic.Dictionary<string, string> pricingDimensions,
            global::System.Collections.Generic.Dictionary<string, string> attributes)
        {
            this.ProductName = productName ?? throw new global::System.ArgumentNullException(nameof(productName));
            this.Quantity = quantity ?? throw new global::System.ArgumentNullException(nameof(quantity));
            this.UnitPrice = unitPrice ?? throw new global::System.ArgumentNullException(nameof(unitPrice));
            this.Cost = cost ?? throw new global::System.ArgumentNullException(nameof(cost));
            this.PricingDimensions = pricingDimensions ?? throw new global::System.ArgumentNullException(nameof(pricingDimensions));
            this.Attributes = attributes ?? throw new global::System.ArgumentNullException(nameof(attributes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingUsageLineItem" /> class.
        /// </summary>
        public BillingUsageLineItem()
        {
        }

    }
}