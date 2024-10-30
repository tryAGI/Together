
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum CompletionRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        MetaLlamaLlama270bHf,
        /// <summary>
        /// 
        /// </summary>
        MistralaiMistral7BV01,
        /// <summary>
        /// 
        /// </summary>
        MistralaiMixtral8x7BV01,
        /// <summary>
        /// 
        /// </summary>
        MetaLlamaLlamaGuard7b,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompletionRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionRequestModel value)
        {
            return value switch
            {
                CompletionRequestModel.MetaLlamaLlama270bHf => "meta-llama/Llama-2-70b-hf",
                CompletionRequestModel.MistralaiMistral7BV01 => "mistralai/Mistral-7B-v0.1",
                CompletionRequestModel.MistralaiMixtral8x7BV01 => "mistralai/Mixtral-8x7B-v0.1",
                CompletionRequestModel.MetaLlamaLlamaGuard7b => "Meta-Llama/Llama-Guard-7b",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "meta-llama/Llama-2-70b-hf" => CompletionRequestModel.MetaLlamaLlama270bHf,
                "mistralai/Mistral-7B-v0.1" => CompletionRequestModel.MistralaiMistral7BV01,
                "mistralai/Mixtral-8x7B-v0.1" => CompletionRequestModel.MistralaiMixtral8x7BV01,
                "Meta-Llama/Llama-Guard-7b" => CompletionRequestModel.MetaLlamaLlamaGuard7b,
                _ => null,
            };
        }
    }
}