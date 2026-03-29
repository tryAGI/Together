
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum AudioSpeechRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        CanopylabsDivideorpheus3b01Ft,
        /// <summary>
        /// 
        /// </summary>
        CartesiaDividesonic,
        /// <summary>
        /// 
        /// </summary>
        HexgradDivideKokoro82m,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioSpeechRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioSpeechRequestModel value)
        {
            return value switch
            {
                AudioSpeechRequestModel.CanopylabsDivideorpheus3b01Ft => "canopylabs/orpheus-3b-0.1-ft",
                AudioSpeechRequestModel.CartesiaDividesonic => "cartesia/sonic",
                AudioSpeechRequestModel.HexgradDivideKokoro82m => "hexgrad/Kokoro-82M",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioSpeechRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "canopylabs/orpheus-3b-0.1-ft" => AudioSpeechRequestModel.CanopylabsDivideorpheus3b01Ft,
                "cartesia/sonic" => AudioSpeechRequestModel.CartesiaDividesonic,
                "hexgrad/Kokoro-82M" => AudioSpeechRequestModel.HexgradDivideKokoro82m,
                _ => null,
            };
        }
    }
}