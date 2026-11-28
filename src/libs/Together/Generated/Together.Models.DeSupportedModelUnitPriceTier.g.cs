
#nullable enable

namespace Together
{
    /// <summary>
    /// Request tier the price applies to, such as synchronous HTTP, batch, or streaming realtime sessions.
    /// </summary>
    public enum DeSupportedModelUnitPriceTier
    {
        /// <summary>
        ///
        /// </summary>
        PricingTierBatch,
        /// <summary>
        ///
        /// </summary>
        PricingTierRealtime,
        /// <summary>
        ///
        /// </summary>
        PricingTierStandard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeSupportedModelUnitPriceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeSupportedModelUnitPriceTier value)
        {
            return value switch
            {
                DeSupportedModelUnitPriceTier.PricingTierBatch => "PRICING_TIER_BATCH",
                DeSupportedModelUnitPriceTier.PricingTierRealtime => "PRICING_TIER_REALTIME",
                DeSupportedModelUnitPriceTier.PricingTierStandard => "PRICING_TIER_STANDARD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeSupportedModelUnitPriceTier? ToEnum(string value)
        {
            return value switch
            {
                "PRICING_TIER_BATCH" => DeSupportedModelUnitPriceTier.PricingTierBatch,
                "PRICING_TIER_REALTIME" => DeSupportedModelUnitPriceTier.PricingTierRealtime,
                "PRICING_TIER_STANDARD" => DeSupportedModelUnitPriceTier.PricingTierStandard,
                _ => null,
            };
        }
    }
}