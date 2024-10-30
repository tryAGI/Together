
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        BlackForestLabsFLUX1SchnellFree,
        /// <summary>
        /// 
        /// </summary>
        BlackForestLabsFLUX1Schnell,
        /// <summary>
        /// 
        /// </summary>
        BlackForestLabsFLUX11Pro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestModel value)
        {
            return value switch
            {
                RequestModel.BlackForestLabsFLUX1SchnellFree => "black-forest-labs/FLUX.1-schnell-Free",
                RequestModel.BlackForestLabsFLUX1Schnell => "black-forest-labs/FLUX.1-schnell",
                RequestModel.BlackForestLabsFLUX11Pro => "black-forest-labs/FLUX.1.1-pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestModel? ToEnum(string value)
        {
            return value switch
            {
                "black-forest-labs/FLUX.1-schnell-Free" => RequestModel.BlackForestLabsFLUX1SchnellFree,
                "black-forest-labs/FLUX.1-schnell" => RequestModel.BlackForestLabsFLUX1Schnell,
                "black-forest-labs/FLUX.1.1-pro" => RequestModel.BlackForestLabsFLUX11Pro,
                _ => null,
            };
        }
    }
}