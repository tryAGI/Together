
#nullable enable

namespace Together
{
    /// <summary>
    /// Canonical artifact selector for checkpoint download requests.
    /// </summary>
    public enum FineTuneCheckpointCheckpoint
    {
        /// <summary>
        ///
        /// </summary>
        Adapter,
        /// <summary>
        ///
        /// </summary>
        Model,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTuneCheckpointCheckpointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuneCheckpointCheckpoint value)
        {
            return value switch
            {
                FineTuneCheckpointCheckpoint.Adapter => "adapter",
                FineTuneCheckpointCheckpoint.Model => "model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuneCheckpointCheckpoint? ToEnum(string value)
        {
            return value switch
            {
                "adapter" => FineTuneCheckpointCheckpoint.Adapter,
                "model" => FineTuneCheckpointCheckpoint.Model,
                _ => null,
            };
        }
    }
}