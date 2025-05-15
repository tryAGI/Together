
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum TrainingMethodSFTTrainOnInputs
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrainingMethodSFTTrainOnInputsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrainingMethodSFTTrainOnInputs value)
        {
            return value switch
            {
                TrainingMethodSFTTrainOnInputs.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrainingMethodSFTTrainOnInputs? ToEnum(string value)
        {
            return value switch
            {
                "auto" => TrainingMethodSFTTrainOnInputs.Auto,
                _ => null,
            };
        }
    }
}