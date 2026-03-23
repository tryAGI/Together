
#nullable enable

namespace Together
{
    /// <summary>
    /// The type of evaluation to perform<br/>
    /// Example: classify
    /// </summary>
    public enum EvaluationTypedRequestType
    {
        /// <summary>
        /// 
        /// </summary>
        Classify,
        /// <summary>
        /// 
        /// </summary>
        Compare,
        /// <summary>
        /// 
        /// </summary>
        Score,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluationTypedRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluationTypedRequestType value)
        {
            return value switch
            {
                EvaluationTypedRequestType.Classify => "classify",
                EvaluationTypedRequestType.Compare => "compare",
                EvaluationTypedRequestType.Score => "score",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluationTypedRequestType? ToEnum(string value)
        {
            return value switch
            {
                "classify" => EvaluationTypedRequestType.Classify,
                "compare" => EvaluationTypedRequestType.Compare,
                "score" => EvaluationTypedRequestType.Score,
                _ => null,
            };
        }
    }
}