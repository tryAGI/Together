
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestBatchSize
    {
        /// <summary>
        /// 
        /// </summary>
        Max,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestBatchSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestBatchSize value)
        {
            return value switch
            {
                RequestBatchSize.Max => "max",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestBatchSize? ToEnum(string value)
        {
            return value switch
            {
                "max" => RequestBatchSize.Max,
                _ => null,
            };
        }
    }
}