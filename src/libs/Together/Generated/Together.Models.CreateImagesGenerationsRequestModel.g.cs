
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateImagesGenerationsRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        BlackForestLabsFLUX1Schnell,
        /// <summary>
        /// 
        /// </summary>
        BlackForestLabsFLUX1SchnellFree,
        /// <summary>
        /// 
        /// </summary>
        BlackForestLabsFLUX11Pro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImagesGenerationsRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImagesGenerationsRequestModel value)
        {
            return value switch
            {
                CreateImagesGenerationsRequestModel.BlackForestLabsFLUX1Schnell => "black-forest-labs/FLUX.1-schnell",
                CreateImagesGenerationsRequestModel.BlackForestLabsFLUX1SchnellFree => "black-forest-labs/FLUX.1-schnell-Free",
                CreateImagesGenerationsRequestModel.BlackForestLabsFLUX11Pro => "black-forest-labs/FLUX.1.1-pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImagesGenerationsRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "black-forest-labs/FLUX.1-schnell" => CreateImagesGenerationsRequestModel.BlackForestLabsFLUX1Schnell,
                "black-forest-labs/FLUX.1-schnell-Free" => CreateImagesGenerationsRequestModel.BlackForestLabsFLUX1SchnellFree,
                "black-forest-labs/FLUX.1.1-pro" => CreateImagesGenerationsRequestModel.BlackForestLabsFLUX11Pro,
                _ => null,
            };
        }
    }
}