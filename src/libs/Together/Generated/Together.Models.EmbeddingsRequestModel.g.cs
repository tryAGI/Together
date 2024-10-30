
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
        WhereIsAIUAELargeV1,
        /// <summary>
        /// 
        /// </summary>
        BAAIBgeLargeEnV15,
        /// <summary>
        /// 
        /// </summary>
        BAAIBgeBaseEnV15,
        /// <summary>
        /// 
        /// </summary>
        TogethercomputerM2Bert80M8kRetrieval,
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
                EmbeddingsRequestModel.WhereIsAIUAELargeV1 => "WhereIsAI/UAE-Large-V1",
                EmbeddingsRequestModel.BAAIBgeLargeEnV15 => "BAAI/bge-large-en-v1.5",
                EmbeddingsRequestModel.BAAIBgeBaseEnV15 => "BAAI/bge-base-en-v1.5",
                EmbeddingsRequestModel.TogethercomputerM2Bert80M8kRetrieval => "togethercomputer/m2-bert-80M-8k-retrieval",
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
                "WhereIsAI/UAE-Large-V1" => EmbeddingsRequestModel.WhereIsAIUAELargeV1,
                "BAAI/bge-large-en-v1.5" => EmbeddingsRequestModel.BAAIBgeLargeEnV15,
                "BAAI/bge-base-en-v1.5" => EmbeddingsRequestModel.BAAIBgeBaseEnV15,
                "togethercomputer/m2-bert-80M-8k-retrieval" => EmbeddingsRequestModel.TogethercomputerM2Bert80M8kRetrieval,
                _ => null,
            };
        }
    }
}