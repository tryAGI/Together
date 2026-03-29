
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmbeddingsRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        BaaiBgeBaseEnV15,
        /// <summary>
        /// 
        /// </summary>
        BaaiBgeLargeEnV15,
        /// <summary>
        /// 
        /// </summary>
        WhereIsAIUaeLargeV1,
        /// <summary>
        /// 
        /// </summary>
        TogethercomputerM2Bert80m8kRetrieval,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingsRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingsRequestModel value)
        {
            return value switch
            {
                EmbeddingsRequestModel.BaaiBgeBaseEnV15 => "BAAI/bge-base-en-v1.5",
                EmbeddingsRequestModel.BaaiBgeLargeEnV15 => "BAAI/bge-large-en-v1.5",
                EmbeddingsRequestModel.WhereIsAIUaeLargeV1 => "WhereIsAI/UAE-Large-V1",
                EmbeddingsRequestModel.TogethercomputerM2Bert80m8kRetrieval => "togethercomputer/m2-bert-80M-8k-retrieval",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingsRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "BAAI/bge-base-en-v1.5" => EmbeddingsRequestModel.BaaiBgeBaseEnV15,
                "BAAI/bge-large-en-v1.5" => EmbeddingsRequestModel.BaaiBgeLargeEnV15,
                "WhereIsAI/UAE-Large-V1" => EmbeddingsRequestModel.WhereIsAIUaeLargeV1,
                "togethercomputer/m2-bert-80M-8k-retrieval" => EmbeddingsRequestModel.TogethercomputerM2Bert80m8kRetrieval,
                _ => null,
            };
        }
    }
}