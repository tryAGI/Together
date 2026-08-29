
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public enum ListTrainingSessionsStatu
    {
        /// <summary>
        ///
        /// </summary>
        TrainingSessionStatusCreating,
        /// <summary>
        ///
        /// </summary>
        TrainingSessionStatusError,
        /// <summary>
        ///
        /// </summary>
        TrainingSessionStatusExpired,
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListTrainingSessionsStatuExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListTrainingSessionsStatu value)
        {
            return value switch
            {
                ListTrainingSessionsStatu.TrainingSessionStatusCreating => "TRAINING_SESSION_STATUS_CREATING",
                ListTrainingSessionsStatu.TrainingSessionStatusError => "TRAINING_SESSION_STATUS_ERROR",
                ListTrainingSessionsStatu.TrainingSessionStatusExpired => "TRAINING_SESSION_STATUS_EXPIRED",
                ListTrainingSessionsStatu.TrainingSessionStatusRunning => "TRAINING_SESSION_STATUS_RUNNING",
                ListTrainingSessionsStatu.TrainingSessionStatusStopped => "TRAINING_SESSION_STATUS_STOPPED",
                ListTrainingSessionsStatu.TrainingSessionStatusStopping => "TRAINING_SESSION_STATUS_STOPPING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListTrainingSessionsStatu? ToEnum(string value)
        {
            return value switch
            {
                "TRAINING_SESSION_STATUS_CREATING" => ListTrainingSessionsStatu.TrainingSessionStatusCreating,
                "TRAINING_SESSION_STATUS_ERROR" => ListTrainingSessionsStatu.TrainingSessionStatusError,
                "TRAINING_SESSION_STATUS_EXPIRED" => ListTrainingSessionsStatu.TrainingSessionStatusExpired,
                "TRAINING_SESSION_STATUS_RUNNING" => ListTrainingSessionsStatu.TrainingSessionStatusRunning,
                "TRAINING_SESSION_STATUS_STOPPED" => ListTrainingSessionsStatu.TrainingSessionStatusStopped,
                "TRAINING_SESSION_STATUS_STOPPING" => ListTrainingSessionsStatu.TrainingSessionStatusStopping,
                _ => null,
            };
        }
    }
}