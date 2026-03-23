
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
        Cosine,
        /// <summary>
        /// 
        /// </summary>
        Linear,
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
                LRSchedulerLrSchedulerType.Cosine => "cosine",
                LRSchedulerLrSchedulerType.Linear => "linear",
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
                "cosine" => LRSchedulerLrSchedulerType.Cosine,
                "linear" => LRSchedulerLrSchedulerType.Linear,
                _ => null,
            };
        }
    }
}