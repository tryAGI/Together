
#nullable enable

namespace Together
{
    /// <summary>
    /// Current status of the job<br/>
    /// Example: completed
    /// </summary>
    public enum EvaluationJobStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Running,
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
        UserError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluationJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluationJobStatus value)
        {
            return value switch
            {
                EvaluationJobStatus.Pending => "pending",
                EvaluationJobStatus.Queued => "queued",
                EvaluationJobStatus.Running => "running",
                EvaluationJobStatus.Completed => "completed",
                EvaluationJobStatus.Error => "error",
                EvaluationJobStatus.UserError => "user_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluationJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "pending" => EvaluationJobStatus.Pending,
                "queued" => EvaluationJobStatus.Queued,
                "running" => EvaluationJobStatus.Running,
                "completed" => EvaluationJobStatus.Completed,
                "error" => EvaluationJobStatus.Error,
                "user_error" => EvaluationJobStatus.UserError,
                _ => null,
            };
        }
    }
}