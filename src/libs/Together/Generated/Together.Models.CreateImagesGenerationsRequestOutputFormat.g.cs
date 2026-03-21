
#nullable enable

namespace Together
{
    /// <summary>
    /// The format of the image response. Can be either be `jpeg` or `png`. Defaults to `jpeg`.<br/>
    /// Default Value: jpeg
    /// </summary>
    public enum CreateImagesGenerationsRequestOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Jpeg,
        /// <summary>
        /// 
        /// </summary>
        Png,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImagesGenerationsRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImagesGenerationsRequestOutputFormat value)
        {
            return value switch
            {
                CreateImagesGenerationsRequestOutputFormat.Jpeg => "jpeg",
                CreateImagesGenerationsRequestOutputFormat.Png => "png",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImagesGenerationsRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => CreateImagesGenerationsRequestOutputFormat.Jpeg,
                "png" => CreateImagesGenerationsRequestOutputFormat.Png,
                _ => null,
            };
        }
    }
}