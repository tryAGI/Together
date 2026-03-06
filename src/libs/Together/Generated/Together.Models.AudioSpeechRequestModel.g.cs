
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
        CartesiaSonic,
        /// <summary>
        /// 
        /// </summary>
        HexgradKokoro82m,
        /// <summary>
        /// 
        /// </summary>
        CanopylabsOrpheus3b01Ft,
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
                AudioSpeechRequestModel.CartesiaSonic => "cartesia/sonic",
                AudioSpeechRequestModel.HexgradKokoro82m => "hexgrad/Kokoro-82M",
                AudioSpeechRequestModel.CanopylabsOrpheus3b01Ft => "canopylabs/orpheus-3b-0.1-ft",
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
                "cartesia/sonic" => AudioSpeechRequestModel.CartesiaSonic,
                "hexgrad/Kokoro-82M" => AudioSpeechRequestModel.HexgradKokoro82m,
                "canopylabs/orpheus-3b-0.1-ft" => AudioSpeechRequestModel.CanopylabsOrpheus3b01Ft,
                _ => null,
            };
        }
    }
}