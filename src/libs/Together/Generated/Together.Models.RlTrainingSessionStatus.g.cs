
#nullable enable

namespace Together
{
    /// <summary>
    /// Status of the training session<br/>
    /// Default Value: TRAINING_SESSION_STATUS_UNSPECIFIED
    /// </summary>
    public enum RlTrainingSessionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        TrainingSessionStatusUnspecified,
        /// <summary>
        /// 
        /// </summary>
        TrainingSessionStatusCreating,
        /// <summary>
        /// 
        /// </summary>
        TrainingSessionStatusRunning,
        /// <summary>
        /// 
        /// </summary>
        TrainingSessionStatusStopped,
        /// <summary>
        /// 
        /// </summary>
        TrainingSessionStatusStopping,
        /// <summary>
        /// 
        /// </summary>
        TrainingSessionStatusError,
        /// <summary>
        /// 
        /// </summary>
        TrainingSessionStatusExpired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RlTrainingSessionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RlTrainingSessionStatus value)
        {
            return value switch
            {
                RlTrainingSessionStatus.TrainingSessionStatusUnspecified => "TRAINING_SESSION_STATUS_UNSPECIFIED",
                RlTrainingSessionStatus.TrainingSessionStatusCreating => "TRAINING_SESSION_STATUS_CREATING",
                RlTrainingSessionStatus.TrainingSessionStatusRunning => "TRAINING_SESSION_STATUS_RUNNING",
                RlTrainingSessionStatus.TrainingSessionStatusStopped => "TRAINING_SESSION_STATUS_STOPPED",
                RlTrainingSessionStatus.TrainingSessionStatusStopping => "TRAINING_SESSION_STATUS_STOPPING",
                RlTrainingSessionStatus.TrainingSessionStatusError => "TRAINING_SESSION_STATUS_ERROR",
                RlTrainingSessionStatus.TrainingSessionStatusExpired => "TRAINING_SESSION_STATUS_EXPIRED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RlTrainingSessionStatus? ToEnum(string value)
        {
            return value switch
            {
                "TRAINING_SESSION_STATUS_UNSPECIFIED" => RlTrainingSessionStatus.TrainingSessionStatusUnspecified,
                "TRAINING_SESSION_STATUS_CREATING" => RlTrainingSessionStatus.TrainingSessionStatusCreating,
                "TRAINING_SESSION_STATUS_RUNNING" => RlTrainingSessionStatus.TrainingSessionStatusRunning,
                "TRAINING_SESSION_STATUS_STOPPED" => RlTrainingSessionStatus.TrainingSessionStatusStopped,
                "TRAINING_SESSION_STATUS_STOPPING" => RlTrainingSessionStatus.TrainingSessionStatusStopping,
                "TRAINING_SESSION_STATUS_ERROR" => RlTrainingSessionStatus.TrainingSessionStatusError,
                "TRAINING_SESSION_STATUS_EXPIRED" => RlTrainingSessionStatus.TrainingSessionStatusExpired,
                _ => null,
            };
        }
    }
}