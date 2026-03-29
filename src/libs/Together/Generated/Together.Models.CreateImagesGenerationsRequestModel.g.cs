
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
        BlackForestLabsFlux1Schnell,
        /// <summary>
        /// 
        /// </summary>
        BlackForestLabsFlux1SchnellFree,
        /// <summary>
        /// 
        /// </summary>
        BlackForestLabsFlux11Pro,
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
                CreateImagesGenerationsRequestModel.BlackForestLabsFlux1Schnell => "black-forest-labs/FLUX.1-schnell",
                CreateImagesGenerationsRequestModel.BlackForestLabsFlux1SchnellFree => "black-forest-labs/FLUX.1-schnell-Free",
                CreateImagesGenerationsRequestModel.BlackForestLabsFlux11Pro => "black-forest-labs/FLUX.1.1-pro",
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
                "black-forest-labs/FLUX.1-schnell" => CreateImagesGenerationsRequestModel.BlackForestLabsFlux1Schnell,
                "black-forest-labs/FLUX.1-schnell-Free" => CreateImagesGenerationsRequestModel.BlackForestLabsFlux1SchnellFree,
                "black-forest-labs/FLUX.1.1-pro" => CreateImagesGenerationsRequestModel.BlackForestLabsFlux11Pro,
                _ => null,
            };
        }
    }
}