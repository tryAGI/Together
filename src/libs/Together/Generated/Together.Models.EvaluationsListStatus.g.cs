
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum EvaluationsListStatus
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
    public static class EvaluationsListStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluationsListStatus value)
        {
            return value switch
            {
                EvaluationsListStatus.Pending => "pending",
                EvaluationsListStatus.Queued => "queued",
                EvaluationsListStatus.Running => "running",
                EvaluationsListStatus.Completed => "completed",
                EvaluationsListStatus.Error => "error",
                EvaluationsListStatus.UserError => "user_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluationsListStatus? ToEnum(string value)
        {
            return value switch
            {
                "pending" => EvaluationsListStatus.Pending,
                "queued" => EvaluationsListStatus.Queued,
                "running" => EvaluationsListStatus.Running,
                "completed" => EvaluationsListStatus.Completed,
                "error" => EvaluationsListStatus.Error,
                "user_error" => EvaluationsListStatus.UserError,
                _ => null,
            };
        }
    }
}