
#nullable enable

namespace Together
{
    /// <summary>
    /// Programming language for the code to execute. Currently only supports Python, but more will be added.<br/>
    /// Default Value: python
    /// </summary>
    public enum ExecuteRequestLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        Python,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExecuteRequestLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecuteRequestLanguage value)
        {
            return value switch
            {
                ExecuteRequestLanguage.Python => "python",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecuteRequestLanguage? ToEnum(string value)
        {
            return value switch
            {
                "python" => ExecuteRequestLanguage.Python,
                _ => null,
            };
        }
    }
}