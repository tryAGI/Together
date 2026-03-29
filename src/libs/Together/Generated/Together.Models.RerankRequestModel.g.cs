
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum RerankRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        SalesforceLlamaRankV1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RerankRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RerankRequestModel value)
        {
            return value switch
            {
                RerankRequestModel.SalesforceLlamaRankV1 => "Salesforce/Llama-Rank-v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RerankRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "Salesforce/Llama-Rank-v1" => RerankRequestModel.SalesforceLlamaRankV1,
                _ => null,
            };
        }
    }
}