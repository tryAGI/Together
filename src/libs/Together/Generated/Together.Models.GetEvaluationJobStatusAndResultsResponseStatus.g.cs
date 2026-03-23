
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
                GetEvaluationJobStatusAndResultsResponseStatus.Pending => "pending",
                GetEvaluationJobStatusAndResultsResponseStatus.Queued => "queued",
                GetEvaluationJobStatusAndResultsResponseStatus.Running => "running",
                GetEvaluationJobStatusAndResultsResponseStatus.UserError => "user_error",
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
                "pending" => GetEvaluationJobStatusAndResultsResponseStatus.Pending,
                "queued" => GetEvaluationJobStatusAndResultsResponseStatus.Queued,
                "running" => GetEvaluationJobStatusAndResultsResponseStatus.Running,
                "user_error" => GetEvaluationJobStatusAndResultsResponseStatus.UserError,
                _ => null,
            };
        }
    }
}