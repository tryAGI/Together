
#nullable enable

namespace Together
{
    /// <summary>
    /// Controls the level of reasoning effort the model should apply when generating responses. Higher values may result in more thoughtful and detailed responses but may take longer to generate.<br/>
    /// Example: medium
    /// </summary>
    public enum ChatCompletionRequestReasoningEffort
    {
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        High,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionRequestReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionRequestReasoningEffort value)
        {
            return value switch
            {
                ChatCompletionRequestReasoningEffort.Low => "low",
                ChatCompletionRequestReasoningEffort.Medium => "medium",
                ChatCompletionRequestReasoningEffort.High => "high",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionRequestReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "low" => ChatCompletionRequestReasoningEffort.Low,
                "medium" => ChatCompletionRequestReasoningEffort.Medium,
                "high" => ChatCompletionRequestReasoningEffort.High,
                _ => null,
            };
        }
    }
}