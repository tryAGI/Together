
#nullable enable

namespace Together
{
    /// <summary>
    /// Example: completed
    /// </summary>
    public enum EvaluationStatusResponseStatus
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
    public static class EvaluationStatusResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluationStatusResponseStatus value)
        {
            return value switch
            {
                EvaluationStatusResponseStatus.Pending => "pending",
                EvaluationStatusResponseStatus.Queued => "queued",
                EvaluationStatusResponseStatus.Running => "running",
                EvaluationStatusResponseStatus.Completed => "completed",
                EvaluationStatusResponseStatus.Error => "error",
                EvaluationStatusResponseStatus.UserError => "user_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluationStatusResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "pending" => EvaluationStatusResponseStatus.Pending,
                "queued" => EvaluationStatusResponseStatus.Queued,
                "running" => EvaluationStatusResponseStatus.Running,
                "completed" => EvaluationStatusResponseStatus.Completed,
                "error" => EvaluationStatusResponseStatus.Error,
                "user_error" => EvaluationStatusResponseStatus.UserError,
                _ => null,
            };
        }
    }
}