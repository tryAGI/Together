
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestTrainOnInputs
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestTrainOnInputsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestTrainOnInputs value)
        {
            return value switch
            {
                RequestTrainOnInputs.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestTrainOnInputs? ToEnum(string value)
        {
            return value switch
            {
                "auto" => RequestTrainOnInputs.Auto,
                _ => null,
            };
        }
    }
}