
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public enum DeSupportedModelProduct
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
        ProductReserved,
        /// <summary>
        ///
        /// </summary>
        ProductServerless,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeSupportedModelProductExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeSupportedModelProduct value)
        {
            return value switch
            {
                DeSupportedModelProduct.ProductDedicated => "PRODUCT_DEDICATED",
                DeSupportedModelProduct.ProductFineTuning => "PRODUCT_FINE_TUNING",
                DeSupportedModelProduct.ProductReserved => "PRODUCT_RESERVED",
                DeSupportedModelProduct.ProductServerless => "PRODUCT_SERVERLESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeSupportedModelProduct? ToEnum(string value)
        {
            return value switch
            {
                "PRODUCT_DEDICATED" => DeSupportedModelProduct.ProductDedicated,
                "PRODUCT_FINE_TUNING" => DeSupportedModelProduct.ProductFineTuning,
                "PRODUCT_RESERVED" => DeSupportedModelProduct.ProductReserved,
                "PRODUCT_SERVERLESS" => DeSupportedModelProduct.ProductServerless,
                _ => null,
            };
        }
    }
}