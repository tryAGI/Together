
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum InterpreterOutputDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InterpreterOutputDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InterpreterOutputDiscriminatorType value)
        {
            return value switch
            {
                InterpreterOutputDiscriminatorType.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InterpreterOutputDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "error" => InterpreterOutputDiscriminatorType.Error,
                _ => null,
            };
        }
    }
}