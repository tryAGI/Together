
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
        Stdout,
        /// <summary>
        /// 
        /// </summary>
        Stderr,
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
                StreamOutputType.Stdout => "stdout",
                StreamOutputType.Stderr => "stderr",
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
                "stdout" => StreamOutputType.Stdout,
                "stderr" => StreamOutputType.Stderr,
                _ => null,
            };
        }
    }
}