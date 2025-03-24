
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum LRSchedulerLrSchedulerType
    {
        /// <summary>
        /// 
        /// </summary>
        Linear,
        /// <summary>
        /// 
        /// </summary>
        Cosine,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LRSchedulerLrSchedulerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LRSchedulerLrSchedulerType value)
        {
            return value switch
            {
                LRSchedulerLrSchedulerType.Linear => "linear",
                LRSchedulerLrSchedulerType.Cosine => "cosine",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LRSchedulerLrSchedulerType? ToEnum(string value)
        {
            return value switch
            {
                "linear" => LRSchedulerLrSchedulerType.Linear,
                "cosine" => LRSchedulerLrSchedulerType.Cosine,
                _ => null,
            };
        }
    }
}