
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum DisplayorExecuteOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        DisplayData,
        /// <summary>
        /// 
        /// </summary>
        ExecuteResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DisplayorExecuteOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DisplayorExecuteOutputType value)
        {
            return value switch
            {
                DisplayorExecuteOutputType.DisplayData => "display_data",
                DisplayorExecuteOutputType.ExecuteResult => "execute_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DisplayorExecuteOutputType? ToEnum(string value)
        {
            return value switch
            {
                "display_data" => DisplayorExecuteOutputType.DisplayData,
                "execute_result" => DisplayorExecuteOutputType.ExecuteResult,
                _ => null,
            };
        }
    }
}