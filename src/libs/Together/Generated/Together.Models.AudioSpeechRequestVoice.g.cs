
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum AudioSpeechRequestVoice
    {
        /// <summary>
        /// 
        /// </summary>
        LaidbackWoman,
        /// <summary>
        /// 
        /// </summary>
        PoliteMan,
        /// <summary>
        /// 
        /// </summary>
        StorytellerLady,
        /// <summary>
        /// 
        /// </summary>
        FriendlySidekick,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioSpeechRequestVoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioSpeechRequestVoice value)
        {
            return value switch
            {
                AudioSpeechRequestVoice.LaidbackWoman => "laidback woman",
                AudioSpeechRequestVoice.PoliteMan => "polite man",
                AudioSpeechRequestVoice.StorytellerLady => "storyteller lady",
                AudioSpeechRequestVoice.FriendlySidekick => "friendly sidekick",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioSpeechRequestVoice? ToEnum(string value)
        {
            return value switch
            {
                "laidback woman" => AudioSpeechRequestVoice.LaidbackWoman,
                "polite man" => AudioSpeechRequestVoice.PoliteMan,
                "storyteller lady" => AudioSpeechRequestVoice.StorytellerLady,
                "friendly sidekick" => AudioSpeechRequestVoice.FriendlySidekick,
                _ => null,
            };
        }
    }
}