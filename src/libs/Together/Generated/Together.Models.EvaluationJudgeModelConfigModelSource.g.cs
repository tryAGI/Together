
#nullable enable

namespace Together
{
    /// <summary>
    /// Source of the judge model.
    /// </summary>
    public enum EvaluationJudgeModelConfigModelSource
    {
        /// <summary>
        /// 
        /// </summary>
        Dedicated,
        /// <summary>
        /// 
        /// </summary>
        External,
        /// <summary>
        /// 
        /// </summary>
        Serverless,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluationJudgeModelConfigModelSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluationJudgeModelConfigModelSource value)
        {
            return value switch
            {
                EvaluationJudgeModelConfigModelSource.Dedicated => "dedicated",
                EvaluationJudgeModelConfigModelSource.External => "external",
                EvaluationJudgeModelConfigModelSource.Serverless => "serverless",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluationJudgeModelConfigModelSource? ToEnum(string value)
        {
            return value switch
            {
                "dedicated" => EvaluationJudgeModelConfigModelSource.Dedicated,
                "external" => EvaluationJudgeModelConfigModelSource.External,
                "serverless" => EvaluationJudgeModelConfigModelSource.Serverless,
                _ => null,
            };
        }
    }
}