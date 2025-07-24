
#nullable enable

namespace Together
{
    /// <summary>
    /// Initial status of the job
    /// </summary>
    public enum EvaluationResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluationResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluationResponseStatus value)
        {
            return value switch
            {
                EvaluationResponseStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluationResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "pending" => EvaluationResponseStatus.Pending,
                _ => null,
            };
        }
    }
}