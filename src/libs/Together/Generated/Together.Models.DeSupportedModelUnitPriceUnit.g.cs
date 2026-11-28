
#nullable enable

namespace Together
{
    /// <summary>
    /// Billing unit, either one minute of input audio (speech-to-text) or one million input characters (text-to-speech).
    /// </summary>
    public enum DeSupportedModelUnitPriceUnit
    {
        /// <summary>
        ///
        /// </summary>
        PricingUnitAudioMinute,
        /// <summary>
        ///
        /// </summary>
        PricingUnitMillionCharacters,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeSupportedModelUnitPriceUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeSupportedModelUnitPriceUnit value)
        {
            return value switch
            {
                DeSupportedModelUnitPriceUnit.PricingUnitAudioMinute => "PRICING_UNIT_AUDIO_MINUTE",
                DeSupportedModelUnitPriceUnit.PricingUnitMillionCharacters => "PRICING_UNIT_MILLION_CHARACTERS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeSupportedModelUnitPriceUnit? ToEnum(string value)
        {
            return value switch
            {
                "PRICING_UNIT_AUDIO_MINUTE" => DeSupportedModelUnitPriceUnit.PricingUnitAudioMinute,
                "PRICING_UNIT_MILLION_CHARACTERS" => DeSupportedModelUnitPriceUnit.PricingUnitMillionCharacters,
                _ => null,
            };
        }
    }
}