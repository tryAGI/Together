
#nullable enable

namespace Together
{
    /// <summary>
    /// Filter models by product surface.
    /// </summary>
    public enum SupportedModelsServiceListSupportedModelsProduct
    {
        /// <summary>
        ///
        /// </summary>
        ProductDedicated,
        /// <summary>
        ///
        /// </summary>
        ProductFineTuning,
        /// <summary>
        ///
        /// </summary>
        ProductServerless,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SupportedModelsServiceListSupportedModelsProductExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SupportedModelsServiceListSupportedModelsProduct value)
        {
            return value switch
            {
                SupportedModelsServiceListSupportedModelsProduct.ProductDedicated => "PRODUCT_DEDICATED",
                SupportedModelsServiceListSupportedModelsProduct.ProductFineTuning => "PRODUCT_FINE_TUNING",
                SupportedModelsServiceListSupportedModelsProduct.ProductServerless => "PRODUCT_SERVERLESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SupportedModelsServiceListSupportedModelsProduct? ToEnum(string value)
        {
            return value switch
            {
                "PRODUCT_DEDICATED" => SupportedModelsServiceListSupportedModelsProduct.ProductDedicated,
                "PRODUCT_FINE_TUNING" => SupportedModelsServiceListSupportedModelsProduct.ProductFineTuning,
                "PRODUCT_SERVERLESS" => SupportedModelsServiceListSupportedModelsProduct.ProductServerless,
                _ => null,
            };
        }
    }
}