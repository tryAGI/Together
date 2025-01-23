
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
                _ => null,
            };
        }
    }
}