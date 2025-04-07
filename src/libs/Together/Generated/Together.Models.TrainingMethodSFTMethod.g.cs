
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum TrainingMethodSFTMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Sft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrainingMethodSFTMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrainingMethodSFTMethod value)
        {
            return value switch
            {
                TrainingMethodSFTMethod.Sft => "sft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrainingMethodSFTMethod? ToEnum(string value)
        {
            return value switch
            {
                "sft" => TrainingMethodSFTMethod.Sft,
                _ => null,
            };
        }
    }
}