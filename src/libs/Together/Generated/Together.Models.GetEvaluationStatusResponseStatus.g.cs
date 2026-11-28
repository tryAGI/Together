
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public enum GetEvaluationStatusResponseStatus
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
        UserError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetEvaluationStatusResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetEvaluationStatusResponseStatus value)
        {
            return value switch
            {
                GetEvaluationStatusResponseStatus.Completed => "completed",
                GetEvaluationStatusResponseStatus.Error => "error",
                GetEvaluationStatusResponseStatus.Pending => "pending",
                GetEvaluationStatusResponseStatus.Queued => "queued",
                GetEvaluationStatusResponseStatus.Running => "running",
                GetEvaluationStatusResponseStatus.UserError => "user_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetEvaluationStatusResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GetEvaluationStatusResponseStatus.Completed,
                "error" => GetEvaluationStatusResponseStatus.Error,
                "pending" => GetEvaluationStatusResponseStatus.Pending,
                "queued" => GetEvaluationStatusResponseStatus.Queued,
                "running" => GetEvaluationStatusResponseStatus.Running,
                "user_error" => GetEvaluationStatusResponseStatus.UserError,
                _ => null,
            };
        }
    }
}