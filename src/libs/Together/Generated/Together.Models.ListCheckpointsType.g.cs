
#nullable enable

namespace Together
{
    /// <summary>
    /// Only return checkpoints of this type. CHECKPOINT_TYPE_TRAINING is the full training state (weights and optimizer state), for resuming a training session with its optimizer state; CHECKPOINT_TYPE_INFERENCE is a model ready for serving or download, also added to your models. When set, it must be CHECKPOINT_TYPE_TRAINING or CHECKPOINT_TYPE_INFERENCE; when omitted, checkpoints of both types are returned.
    /// </summary>
    public enum ListCheckpointsType
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
    public static class ListCheckpointsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListCheckpointsType value)
        {
            return value switch
            {
                ListCheckpointsType.CheckpointTypeInference => "CHECKPOINT_TYPE_INFERENCE",
                ListCheckpointsType.CheckpointTypeTraining => "CHECKPOINT_TYPE_TRAINING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListCheckpointsType? ToEnum(string value)
        {
            return value switch
            {
                "CHECKPOINT_TYPE_INFERENCE" => ListCheckpointsType.CheckpointTypeInference,
                "CHECKPOINT_TYPE_TRAINING" => ListCheckpointsType.CheckpointTypeTraining,
                _ => null,
            };
        }
    }
}