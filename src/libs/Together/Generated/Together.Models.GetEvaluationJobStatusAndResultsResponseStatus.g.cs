
#nullable enable

namespace Together
{
    /// <summary>
    /// The status of the evaluation job
    /// </summary>
    public enum GetEvaluationJobStatusAndResultsResponseStatus
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
        UserError,
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
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetEvaluationJobStatusAndResultsResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetEvaluationJobStatusAndResultsResponseStatus value)
        {
            return value switch
            {
                GetEvaluationJobStatusAndResultsResponseStatus.Completed => "completed",
                GetEvaluationJobStatusAndResultsResponseStatus.Error => "error",
                GetEvaluationJobStatusAndResultsResponseStatus.UserError => "user_error",
                GetEvaluationJobStatusAndResultsResponseStatus.Running => "running",
                GetEvaluationJobStatusAndResultsResponseStatus.Queued => "queued",
                GetEvaluationJobStatusAndResultsResponseStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetEvaluationJobStatusAndResultsResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GetEvaluationJobStatusAndResultsResponseStatus.Completed,
                "error" => GetEvaluationJobStatusAndResultsResponseStatus.Error,
                "user_error" => GetEvaluationJobStatusAndResultsResponseStatus.UserError,
                "running" => GetEvaluationJobStatusAndResultsResponseStatus.Running,
                "queued" => GetEvaluationJobStatusAndResultsResponseStatus.Queued,
                "pending" => GetEvaluationJobStatusAndResultsResponseStatus.Pending,
                _ => null,
            };
        }
    }
}