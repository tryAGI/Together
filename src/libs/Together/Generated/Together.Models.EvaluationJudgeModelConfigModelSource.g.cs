
#nullable enable

namespace Together
{
    /// <summary>
    /// Source of the judge model inference: - `serverless`: Together's shared serverless inference API. Default concurrency: 25 workers. - `dedicated`: A Together dedicated deployment endpoint. Default concurrency: 5 workers<br/>
    ///   (minimum enforced even if num_workers is set lower).<br/>
    /// - `external`: An external inference API (e.g. OpenAI, Anthropic, Google, OpenRouter).<br/>
    ///   Requires `external_api_token` and `external_base_url`. Default concurrency: 2 workers<br/>
    ///   for first-party APIs, 20 for proxy/aggregator endpoints.
    /// </summary>
    public enum EvaluationJudgeModelConfigModelSource
    {
        /// <summary>
        /// - `serverless`: Together's shared serverless inference API. Default concurrency: 25 workers. - `dedicated`: A Together dedicated deployment endpoint. Default concurrency: 5 workers
        /// </summary>
        Dedicated,
        /// <summary>
        /// An external inference API (e.g. OpenAI, Anthropic, Google, OpenRouter).
        /// </summary>
        External,
        /// <summary>
        /// - `serverless`: Together's shared serverless inference API. Default concurrency: 25 workers. - `dedicated`: A Together dedicated deployment endpoint. Default concurrency: 5 workers
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