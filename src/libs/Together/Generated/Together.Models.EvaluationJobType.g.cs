
#nullable enable

namespace Together
{
    /// <summary>
    /// The type of evaluation<br/>
    /// Example: classify
    /// </summary>
    public enum EvaluationJobType
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
    public static class EvaluationJobTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluationJobType value)
        {
            return value switch
            {
                EvaluationJobType.Classify => "classify",
                EvaluationJobType.Compare => "compare",
                EvaluationJobType.Score => "score",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluationJobType? ToEnum(string value)
        {
            return value switch
            {
                "classify" => EvaluationJobType.Classify,
                "compare" => EvaluationJobType.Compare,
                "score" => EvaluationJobType.Score,
                _ => null,
            };
        }
    }
}