
#nullable enable

namespace Together
{
    /// <summary>
    /// Finite machine-readable training session lifecycle error code
    /// </summary>
    public enum RlTrainingSessionErrorCode
    {
        /// <summary>
        ///
        /// </summary>
        TrainingSessionErrorCodeResourceAtCapacity,
        /// <summary>
        ///
        /// </summary>
        TrainingSessionErrorCodeResourceUnavailable,
        /// <summary>
        ///
        /// </summary>
        TrainingSessionErrorCodeSessionFailed,
        /// <summary>
        ///
        /// </summary>
        TrainingSessionErrorCodeTimedOut,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RlTrainingSessionErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RlTrainingSessionErrorCode value)
        {
            return value switch
            {
                RlTrainingSessionErrorCode.TrainingSessionErrorCodeResourceAtCapacity => "TRAINING_SESSION_ERROR_CODE_RESOURCE_AT_CAPACITY",
                RlTrainingSessionErrorCode.TrainingSessionErrorCodeResourceUnavailable => "TRAINING_SESSION_ERROR_CODE_RESOURCE_UNAVAILABLE",
                RlTrainingSessionErrorCode.TrainingSessionErrorCodeSessionFailed => "TRAINING_SESSION_ERROR_CODE_SESSION_FAILED",
                RlTrainingSessionErrorCode.TrainingSessionErrorCodeTimedOut => "TRAINING_SESSION_ERROR_CODE_TIMED_OUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RlTrainingSessionErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "TRAINING_SESSION_ERROR_CODE_RESOURCE_AT_CAPACITY" => RlTrainingSessionErrorCode.TrainingSessionErrorCodeResourceAtCapacity,
                "TRAINING_SESSION_ERROR_CODE_RESOURCE_UNAVAILABLE" => RlTrainingSessionErrorCode.TrainingSessionErrorCodeResourceUnavailable,
                "TRAINING_SESSION_ERROR_CODE_SESSION_FAILED" => RlTrainingSessionErrorCode.TrainingSessionErrorCodeSessionFailed,
                "TRAINING_SESSION_ERROR_CODE_TIMED_OUT" => RlTrainingSessionErrorCode.TrainingSessionErrorCodeTimedOut,
                _ => null,
            };
        }
    }
}