
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionUserMessageContentMultimodalItemVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        AudioUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionUserMessageContentMultimodalItemVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionUserMessageContentMultimodalItemVariant4Type value)
        {
            return value switch
            {
                ChatCompletionUserMessageContentMultimodalItemVariant4Type.AudioUrl => "audio_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionUserMessageContentMultimodalItemVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "audio_url" => ChatCompletionUserMessageContentMultimodalItemVariant4Type.AudioUrl,
                _ => null,
            };
        }
    }
}