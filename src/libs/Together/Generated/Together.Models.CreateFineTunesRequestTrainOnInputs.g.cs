
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFineTunesRequestTrainOnInputs
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateFineTunesRequestTrainOnInputsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFineTunesRequestTrainOnInputs value)
        {
            return value switch
            {
                CreateFineTunesRequestTrainOnInputs.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFineTunesRequestTrainOnInputs? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateFineTunesRequestTrainOnInputs.Auto,
                _ => null,
            };
        }
    }
}