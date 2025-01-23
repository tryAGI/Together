
#nullable enable

namespace Together
{
    /// <summary>
    /// Language of input text<br/>
    /// Default Value: en
    /// </summary>
    public enum AudioSpeechRequestLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        En,
        /// <summary>
        /// 
        /// </summary>
        De,
        /// <summary>
        /// 
        /// </summary>
        Fr,
        /// <summary>
        /// 
        /// </summary>
        Es,
        /// <summary>
        /// 
        /// </summary>
        Hi,
        /// <summary>
        /// 
        /// </summary>
        It,
        /// <summary>
        /// 
        /// </summary>
        Ja,
        /// <summary>
        /// 
        /// </summary>
        Ko,
        /// <summary>
        /// 
        /// </summary>
        Nl,
        /// <summary>
        /// 
        /// </summary>
        Pl,
        /// <summary>
        /// 
        /// </summary>
        Pt,
        /// <summary>
        /// 
        /// </summary>
        Ru,
        /// <summary>
        /// 
        /// </summary>
        Sv,
        /// <summary>
        /// 
        /// </summary>
        Tr,
        /// <summary>
        /// 
        /// </summary>
        Zh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioSpeechRequestLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioSpeechRequestLanguage value)
        {
            return value switch
            {
                AudioSpeechRequestLanguage.En => "en",
                AudioSpeechRequestLanguage.De => "de",
                AudioSpeechRequestLanguage.Fr => "fr",
                AudioSpeechRequestLanguage.Es => "es",
                AudioSpeechRequestLanguage.Hi => "hi",
                AudioSpeechRequestLanguage.It => "it",
                AudioSpeechRequestLanguage.Ja => "ja",
                AudioSpeechRequestLanguage.Ko => "ko",
                AudioSpeechRequestLanguage.Nl => "nl",
                AudioSpeechRequestLanguage.Pl => "pl",
                AudioSpeechRequestLanguage.Pt => "pt",
                AudioSpeechRequestLanguage.Ru => "ru",
                AudioSpeechRequestLanguage.Sv => "sv",
                AudioSpeechRequestLanguage.Tr => "tr",
                AudioSpeechRequestLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioSpeechRequestLanguage? ToEnum(string value)
        {
            return value switch
            {
                "en" => AudioSpeechRequestLanguage.En,
                "de" => AudioSpeechRequestLanguage.De,
                "fr" => AudioSpeechRequestLanguage.Fr,
                "es" => AudioSpeechRequestLanguage.Es,
                "hi" => AudioSpeechRequestLanguage.Hi,
                "it" => AudioSpeechRequestLanguage.It,
                "ja" => AudioSpeechRequestLanguage.Ja,
                "ko" => AudioSpeechRequestLanguage.Ko,
                "nl" => AudioSpeechRequestLanguage.Nl,
                "pl" => AudioSpeechRequestLanguage.Pl,
                "pt" => AudioSpeechRequestLanguage.Pt,
                "ru" => AudioSpeechRequestLanguage.Ru,
                "sv" => AudioSpeechRequestLanguage.Sv,
                "tr" => AudioSpeechRequestLanguage.Tr,
                "zh" => AudioSpeechRequestLanguage.Zh,
                _ => null,
            };
        }
    }
}