
#nullable enable

namespace Together
{
    /// <summary>
    /// Source of the model inference: - `serverless`: Together's shared serverless inference API. Default concurrency: 25 workers. - `dedicated`: A Together dedicated deployment endpoint. Default concurrency: 5 workers<br/>
    ///   (minimum enforced even if num_workers is set lower). Authentication uses the requesting<br/>
    ///   user's Together API token automatically.<br/>
    /// - `external`: An external inference API (e.g. OpenAI, Anthropic, Google, OpenRouter).<br/>
    ///   Requires `external_api_token` and `external_base_url`. Default concurrency: 2 workers<br/>
    ///   for first-party APIs (OpenAI, Anthropic, Google), 20 for proxy/aggregator endpoints.
    /// </summary>
    public enum EvaluationModelRequestModelSource
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