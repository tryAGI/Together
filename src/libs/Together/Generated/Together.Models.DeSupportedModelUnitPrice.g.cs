
#nullable enable

namespace Together
{
    /// <summary>
    /// Serverless display price in USD per one non-token unit on one request tier.
    /// </summary>
    public sealed partial class DeSupportedModelUnitPrice
    {
        /// <summary>
        /// Billing unit, either one minute of input audio (speech-to-text) or one million input characters (text-to-speech).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeSupportedModelUnitPriceUnitJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.DeSupportedModelUnitPriceUnit Unit { get; set; }

        /// <summary>
        /// Request tier the price applies to, such as synchronous HTTP, batch, or streaming realtime sessions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeSupportedModelUnitPriceTierJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.DeSupportedModelUnitPriceTier Tier { get; set; }

        /// <summary>
        /// Price in USD per one unit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priceUsd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PriceUsd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeSupportedModelUnitPrice" /> class.
        /// </summary>
        /// <param name="unit">
        /// Billing unit, either one minute of input audio (speech-to-text) or one million input characters (text-to-speech).
        /// </param>
        /// <param name="tier">
        /// Request tier the price applies to, such as synchronous HTTP, batch, or streaming realtime sessions.
        /// </param>
        /// <param name="priceUsd">
        /// Price in USD per one unit.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeSupportedModelUnitPrice(
            global::Together.DeSupportedModelUnitPriceUnit unit,
            global::Together.DeSupportedModelUnitPriceTier tier,
            double priceUsd)
        {
            this.Unit = unit;
            this.Tier = tier;
            this.PriceUsd = priceUsd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeSupportedModelUnitPrice" /> class.
        /// </summary>
        public DeSupportedModelUnitPrice()
        {
        }

    }
}