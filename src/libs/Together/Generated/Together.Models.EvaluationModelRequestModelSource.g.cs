
#nullable enable

namespace Together
{
    /// <summary>
    /// Source of the model.
    /// </summary>
    public enum EvaluationModelRequestModelSource
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
    public static class EvaluationModelRequestModelSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluationModelRequestModelSource value)
        {
            return value switch
            {
                EvaluationModelRequestModelSource.Dedicated => "dedicated",
                EvaluationModelRequestModelSource.External => "external",
                EvaluationModelRequestModelSource.Serverless => "serverless",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluationModelRequestModelSource? ToEnum(string value)
        {
            return value switch
            {
                "dedicated" => EvaluationModelRequestModelSource.Dedicated,
                "external" => EvaluationModelRequestModelSource.External,
                "serverless" => EvaluationModelRequestModelSource.Serverless,
                _ => null,
            };
        }
    }
}