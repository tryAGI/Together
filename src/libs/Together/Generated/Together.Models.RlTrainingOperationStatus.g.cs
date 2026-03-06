
#nullable enable

namespace Together
{
    /// <summary>
    /// Default Value: TRAINING_OPERATION_STATUS_UNSPECIFIED
    /// </summary>
    public enum RlTrainingOperationStatus
    {
        /// <summary>
        /// 
        /// </summary>
        TrainingOperationStatusUnspecified,
        /// <summary>
        /// 
        /// </summary>
        TrainingOperationStatusPending,
        /// <summary>
        /// 
        /// </summary>
        TrainingOperationStatusRunning,
        /// <summary>
        /// 
        /// </summary>
        TrainingOperationStatusCompleted,
        /// <summary>
        /// 
        /// </summary>
        TrainingOperationStatusFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RlTrainingOperationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RlTrainingOperationStatus value)
        {
            return value switch
            {
                RlTrainingOperationStatus.TrainingOperationStatusUnspecified => "TRAINING_OPERATION_STATUS_UNSPECIFIED",
                RlTrainingOperationStatus.TrainingOperationStatusPending => "TRAINING_OPERATION_STATUS_PENDING",
                RlTrainingOperationStatus.TrainingOperationStatusRunning => "TRAINING_OPERATION_STATUS_RUNNING",
                RlTrainingOperationStatus.TrainingOperationStatusCompleted => "TRAINING_OPERATION_STATUS_COMPLETED",
                RlTrainingOperationStatus.TrainingOperationStatusFailed => "TRAINING_OPERATION_STATUS_FAILED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RlTrainingOperationStatus? ToEnum(string value)
        {
            return value switch
            {
                "TRAINING_OPERATION_STATUS_UNSPECIFIED" => RlTrainingOperationStatus.TrainingOperationStatusUnspecified,
                "TRAINING_OPERATION_STATUS_PENDING" => RlTrainingOperationStatus.TrainingOperationStatusPending,
                "TRAINING_OPERATION_STATUS_RUNNING" => RlTrainingOperationStatus.TrainingOperationStatusRunning,
                "TRAINING_OPERATION_STATUS_COMPLETED" => RlTrainingOperationStatus.TrainingOperationStatusCompleted,
                "TRAINING_OPERATION_STATUS_FAILED" => RlTrainingOperationStatus.TrainingOperationStatusFailed,
                _ => null,
            };
        }
    }
}