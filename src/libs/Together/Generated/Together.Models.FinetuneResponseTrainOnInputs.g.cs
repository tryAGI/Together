
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum FinetuneResponseTrainOnInputs
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FinetuneResponseTrainOnInputsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FinetuneResponseTrainOnInputs value)
        {
            return value switch
            {
                FinetuneResponseTrainOnInputs.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FinetuneResponseTrainOnInputs? ToEnum(string value)
        {
            return value switch
            {
                "auto" => FinetuneResponseTrainOnInputs.Auto,
                _ => null,
            };
        }
    }
}