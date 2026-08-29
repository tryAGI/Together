
#nullable enable

namespace Together
{
    /// <summary>
    /// Whether a checkpoint is saved for training resume or inference download.
    /// </summary>
    public enum RlCheckpointType
    {
        /// <summary>
        ///
        /// </summary>
        CheckpointTypeInference,
        /// <summary>
        ///
        /// </summary>
        CheckpointTypeTraining,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RlCheckpointTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RlCheckpointType value)
        {
            return value switch
            {
                RlCheckpointType.CheckpointTypeInference => "CHECKPOINT_TYPE_INFERENCE",
                RlCheckpointType.CheckpointTypeTraining => "CHECKPOINT_TYPE_TRAINING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RlCheckpointType? ToEnum(string value)
        {
            return value switch
            {
                "CHECKPOINT_TYPE_INFERENCE" => RlCheckpointType.CheckpointTypeInference,
                "CHECKPOINT_TYPE_TRAINING" => RlCheckpointType.CheckpointTypeTraining,
                _ => null,
            };
        }
    }
}