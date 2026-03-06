
#nullable enable

namespace Together
{
    /// <summary>
    /// Specifies checkpoint type to download - `merged` vs `adapter`. This field is required if the checkpoint_step is not set.
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
        /// <summary>
        /// 
        /// </summary>
        ModelOutputPath,
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
                Checkpoint.ModelOutputPath => "model_output_path",
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
                "model_output_path" => Checkpoint.ModelOutputPath,
                _ => null,
            };
        }
    }
}