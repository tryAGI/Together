
#nullable enable

namespace Together
{
    /// <summary>
    /// The new status for the job
    /// </summary>
    public enum EvaluationUpdateRequestStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        UserError,
        /// <summary>
        /// 
        /// </summary>
        InferenceError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluationUpdateRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluationUpdateRequestStatus value)
        {
            return value switch
            {
                EvaluationUpdateRequestStatus.Completed => "completed",
                EvaluationUpdateRequestStatus.Error => "error",
                EvaluationUpdateRequestStatus.Running => "running",
                EvaluationUpdateRequestStatus.Queued => "queued",
                EvaluationUpdateRequestStatus.UserError => "user_error",
                EvaluationUpdateRequestStatus.InferenceError => "inference_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluationUpdateRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => EvaluationUpdateRequestStatus.Completed,
                "error" => EvaluationUpdateRequestStatus.Error,
                "running" => EvaluationUpdateRequestStatus.Running,
                "queued" => EvaluationUpdateRequestStatus.Queued,
                "user_error" => EvaluationUpdateRequestStatus.UserError,
                "inference_error" => EvaluationUpdateRequestStatus.InferenceError,
                _ => null,
            };
        }
    }
}