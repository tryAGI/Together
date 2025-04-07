
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum FinetuneResponseBatchSize
    {
        /// <summary>
        /// 
        /// </summary>
        Max,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FinetuneResponseBatchSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FinetuneResponseBatchSize value)
        {
            return value switch
            {
                FinetuneResponseBatchSize.Max => "max",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FinetuneResponseBatchSize? ToEnum(string value)
        {
            return value switch
            {
                "max" => FinetuneResponseBatchSize.Max,
                _ => null,
            };
        }
    }
}