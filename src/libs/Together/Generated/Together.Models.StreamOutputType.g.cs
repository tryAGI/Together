
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum StreamOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        Stderr,
        /// <summary>
        /// 
        /// </summary>
        Stdout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StreamOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamOutputType value)
        {
            return value switch
            {
                StreamOutputType.Stderr => "stderr",
                StreamOutputType.Stdout => "stdout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamOutputType? ToEnum(string value)
        {
            return value switch
            {
                "stderr" => StreamOutputType.Stderr,
                "stdout" => StreamOutputType.Stdout,
                _ => null,
            };
        }
    }
}