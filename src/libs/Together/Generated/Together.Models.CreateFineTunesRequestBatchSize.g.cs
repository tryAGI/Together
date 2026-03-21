
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFineTunesRequestBatchSize
    {
        /// <summary>
        /// 
        /// </summary>
        Max,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateFineTunesRequestBatchSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFineTunesRequestBatchSize value)
        {
            return value switch
            {
                CreateFineTunesRequestBatchSize.Max => "max",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFineTunesRequestBatchSize? ToEnum(string value)
        {
            return value switch
            {
                "max" => CreateFineTunesRequestBatchSize.Max,
                _ => null,
            };
        }
    }
}