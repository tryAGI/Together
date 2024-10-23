
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        QwenQwen2572BInstructTurbo,
        /// <summary>
        /// 
        /// </summary>
        QwenQwen257BInstructTurbo,
        /// <summary>
        /// 
        /// </summary>
        MetaLlamaMetaLlama31405BInstructTurbo,
        /// <summary>
        /// 
        /// </summary>
        MetaLlamaMetaLlama3170BInstructTurbo,
        /// <summary>
        /// 
        /// </summary>
        MetaLlamaMetaLlama318BInstructTurbo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionRequestModel value)
        {
            return value switch
            {
                ChatCompletionRequestModel.QwenQwen2572BInstructTurbo => "Qwen/Qwen2.5-72B-Instruct-Turbo",
                ChatCompletionRequestModel.QwenQwen257BInstructTurbo => "Qwen/Qwen2.5-7B-Instruct-Turbo",
                ChatCompletionRequestModel.MetaLlamaMetaLlama31405BInstructTurbo => "meta-llama/Meta-Llama-3.1-405B-Instruct-Turbo",
                ChatCompletionRequestModel.MetaLlamaMetaLlama3170BInstructTurbo => "meta-llama/Meta-Llama-3.1-70B-Instruct-Turbo",
                ChatCompletionRequestModel.MetaLlamaMetaLlama318BInstructTurbo => "meta-llama/Meta-Llama-3.1-8B-Instruct-Turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "Qwen/Qwen2.5-72B-Instruct-Turbo" => ChatCompletionRequestModel.QwenQwen2572BInstructTurbo,
                "Qwen/Qwen2.5-7B-Instruct-Turbo" => ChatCompletionRequestModel.QwenQwen257BInstructTurbo,
                "meta-llama/Meta-Llama-3.1-405B-Instruct-Turbo" => ChatCompletionRequestModel.MetaLlamaMetaLlama31405BInstructTurbo,
                "meta-llama/Meta-Llama-3.1-70B-Instruct-Turbo" => ChatCompletionRequestModel.MetaLlamaMetaLlama3170BInstructTurbo,
                "meta-llama/Meta-Llama-3.1-8B-Instruct-Turbo" => ChatCompletionRequestModel.MetaLlamaMetaLlama318BInstructTurbo,
                _ => null,
            };
        }
    }
}