
#nullable enable

namespace Together
{
    /// <summary>
    /// The TTS model to use for speech generation. Can also be set via `tts_session.updated` event.<br/>
    /// Default Value: hexgrad/Kokoro-82M
    /// </summary>
    public enum RealtimeTtsModel
    {
        /// <summary>
        /// 
        /// </summary>
        CartesiaSonicEnglish,
        /// <summary>
        /// 
        /// </summary>
        HexgradKokoro82m,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeTtsModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTtsModel value)
        {
            return value switch
            {
                RealtimeTtsModel.CartesiaSonicEnglish => "cartesia/sonic-english",
                RealtimeTtsModel.HexgradKokoro82m => "hexgrad/Kokoro-82M",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTtsModel? ToEnum(string value)
        {
            return value switch
            {
                "cartesia/sonic-english" => RealtimeTtsModel.CartesiaSonicEnglish,
                "hexgrad/Kokoro-82M" => RealtimeTtsModel.HexgradKokoro82m,
                _ => null,
            };
        }
    }
}