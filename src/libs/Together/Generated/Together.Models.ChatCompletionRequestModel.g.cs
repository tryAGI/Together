
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
        QwenQwen2572bInstructTurbo,
        /// <summary>
        /// 
        /// </summary>
        QwenQwen257bInstructTurbo,
        /// <summary>
        /// 
        /// </summary>
        MetaLlamaMetaLlama31405bInstructTurbo,
        /// <summary>
        /// 
        /// </summary>
        MetaLlamaMetaLlama3170bInstructTurbo,
        /// <summary>
        /// 
        /// </summary>
        MetaLlamaMetaLlama318bInstructTurbo,
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
                ChatCompletionRequestModel.QwenQwen2572bInstructTurbo => "Qwen/Qwen2.5-72B-Instruct-Turbo",
                ChatCompletionRequestModel.QwenQwen257bInstructTurbo => "Qwen/Qwen2.5-7B-Instruct-Turbo",
                ChatCompletionRequestModel.MetaLlamaMetaLlama31405bInstructTurbo => "meta-llama/Meta-Llama-3.1-405B-Instruct-Turbo",
                ChatCompletionRequestModel.MetaLlamaMetaLlama3170bInstructTurbo => "meta-llama/Meta-Llama-3.1-70B-Instruct-Turbo",
                ChatCompletionRequestModel.MetaLlamaMetaLlama318bInstructTurbo => "meta-llama/Meta-Llama-3.1-8B-Instruct-Turbo",
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
                "Qwen/Qwen2.5-72B-Instruct-Turbo" => ChatCompletionRequestModel.QwenQwen2572bInstructTurbo,
                "Qwen/Qwen2.5-7B-Instruct-Turbo" => ChatCompletionRequestModel.QwenQwen257bInstructTurbo,
                "meta-llama/Meta-Llama-3.1-405B-Instruct-Turbo" => ChatCompletionRequestModel.MetaLlamaMetaLlama31405bInstructTurbo,
                "meta-llama/Meta-Llama-3.1-70B-Instruct-Turbo" => ChatCompletionRequestModel.MetaLlamaMetaLlama3170bInstructTurbo,
                "meta-llama/Meta-Llama-3.1-8B-Instruct-Turbo" => ChatCompletionRequestModel.MetaLlamaMetaLlama318bInstructTurbo,
                _ => null,
            };
        }
    }
}