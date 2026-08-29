
#nullable enable

namespace Together
{
    /// <summary>
    /// Application error code for a failed training operation<br/>
    /// Default Value: TRAINING_OPERATION_ERROR_CODE_UNSPECIFIED
    /// </summary>
    public enum RlTrainingOperationErrorCode
    {
        /// <summary>
        ///
        /// </summary>
        TrainingOperationErrorCodeInternalError,
        /// <summary>
        ///
        /// </summary>
        TrainingOperationErrorCodeInvalidInput,
        /// <summary>
        ///
        /// </summary>
        TrainingOperationErrorCodeNonFiniteLoss,
        /// <summary>
        ///
        /// </summary>
        TrainingOperationErrorCodeResourceExhausted,
        /// <summary>
        ///
        /// </summary>
        TrainingOperationErrorCodeSessionNotActive,
        /// <summary>
        ///
        /// </summary>
        TrainingOperationErrorCodeTimeout,
        /// <summary>
        ///
        /// </summary>
        TrainingOperationErrorCodeUnspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RlTrainingOperationErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RlTrainingOperationErrorCode value)
        {
            return value switch
            {
                RlTrainingOperationErrorCode.TrainingOperationErrorCodeInternalError => "TRAINING_OPERATION_ERROR_CODE_INTERNAL_ERROR",
                RlTrainingOperationErrorCode.TrainingOperationErrorCodeInvalidInput => "TRAINING_OPERATION_ERROR_CODE_INVALID_INPUT",
                RlTrainingOperationErrorCode.TrainingOperationErrorCodeNonFiniteLoss => "TRAINING_OPERATION_ERROR_CODE_NON_FINITE_LOSS",
                RlTrainingOperationErrorCode.TrainingOperationErrorCodeResourceExhausted => "TRAINING_OPERATION_ERROR_CODE_RESOURCE_EXHAUSTED",
                RlTrainingOperationErrorCode.TrainingOperationErrorCodeSessionNotActive => "TRAINING_OPERATION_ERROR_CODE_SESSION_NOT_ACTIVE",
                RlTrainingOperationErrorCode.TrainingOperationErrorCodeTimeout => "TRAINING_OPERATION_ERROR_CODE_TIMEOUT",
                RlTrainingOperationErrorCode.TrainingOperationErrorCodeUnspecified => "TRAINING_OPERATION_ERROR_CODE_UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RlTrainingOperationErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "TRAINING_OPERATION_ERROR_CODE_INTERNAL_ERROR" => RlTrainingOperationErrorCode.TrainingOperationErrorCodeInternalError,
                "TRAINING_OPERATION_ERROR_CODE_INVALID_INPUT" => RlTrainingOperationErrorCode.TrainingOperationErrorCodeInvalidInput,
                "TRAINING_OPERATION_ERROR_CODE_NON_FINITE_LOSS" => RlTrainingOperationErrorCode.TrainingOperationErrorCodeNonFiniteLoss,
                "TRAINING_OPERATION_ERROR_CODE_RESOURCE_EXHAUSTED" => RlTrainingOperationErrorCode.TrainingOperationErrorCodeResourceExhausted,
                "TRAINING_OPERATION_ERROR_CODE_SESSION_NOT_ACTIVE" => RlTrainingOperationErrorCode.TrainingOperationErrorCodeSessionNotActive,
                "TRAINING_OPERATION_ERROR_CODE_TIMEOUT" => RlTrainingOperationErrorCode.TrainingOperationErrorCodeTimeout,
                "TRAINING_OPERATION_ERROR_CODE_UNSPECIFIED" => RlTrainingOperationErrorCode.TrainingOperationErrorCodeUnspecified,
                _ => null,
            };
        }
    }
}