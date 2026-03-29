
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
        MetaLlamaDivideLlamaGuard7b,
        /// <summary>
        /// 
        /// </summary>
        MetaLlamaDivideLlama270bHf,
        /// <summary>
        /// 
        /// </summary>
        MistralaiDivideMistral7bV01,
        /// <summary>
        /// 
        /// </summary>
        MistralaiDivideMixtral8x7BV01,
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
                CompletionRequestModel.MetaLlamaDivideLlamaGuard7b => "Meta-Llama/Llama-Guard-7b",
                CompletionRequestModel.MetaLlamaDivideLlama270bHf => "meta-llama/Llama-2-70b-hf",
                CompletionRequestModel.MistralaiDivideMistral7bV01 => "mistralai/Mistral-7B-v0.1",
                CompletionRequestModel.MistralaiDivideMixtral8x7BV01 => "mistralai/Mixtral-8x7B-v0.1",
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
                "Meta-Llama/Llama-Guard-7b" => CompletionRequestModel.MetaLlamaDivideLlamaGuard7b,
                "meta-llama/Llama-2-70b-hf" => CompletionRequestModel.MetaLlamaDivideLlama270bHf,
                "mistralai/Mistral-7B-v0.1" => CompletionRequestModel.MistralaiDivideMistral7bV01,
                "mistralai/Mixtral-8x7B-v0.1" => CompletionRequestModel.MistralaiDivideMixtral8x7BV01,
                _ => null,
            };
        }
    }
}