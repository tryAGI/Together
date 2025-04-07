
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum TrainingMethodDPOMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Dpo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrainingMethodDPOMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrainingMethodDPOMethod value)
        {
            return value switch
            {
                TrainingMethodDPOMethod.Dpo => "dpo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrainingMethodDPOMethod? ToEnum(string value)
        {
            return value switch
            {
                "dpo" => TrainingMethodDPOMethod.Dpo,
                _ => null,
            };
        }
    }
}