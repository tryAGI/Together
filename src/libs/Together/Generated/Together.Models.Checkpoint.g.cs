
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum Checkpoint
    {
        /// <summary>
        /// 
        /// </summary>
        Merged,
        /// <summary>
        /// 
        /// </summary>
        Adapter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CheckpointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Checkpoint value)
        {
            return value switch
            {
                Checkpoint.Merged => "merged",
                Checkpoint.Adapter => "adapter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Checkpoint? ToEnum(string value)
        {
            return value switch
            {
                "merged" => Checkpoint.Merged,
                "adapter" => Checkpoint.Adapter,
                _ => null,
            };
        }
    }
}