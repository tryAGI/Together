
#nullable enable

namespace Together
{
    /// <summary>
    /// Defined the behavior of the API when max_tokens exceed the maximum context length of the model. When set to 'error', API will return 400 with appropriate error message. When set to 'truncate', override the max_tokens with maximum context length of the model.<br/>
    /// Default Value: error
    /// </summary>
    public enum ChatCompletionRequestContextLengthExceededBehavior
    {
        /// <summary>
        /// 
        /// </summary>
        Truncate,
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionRequestContextLengthExceededBehaviorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionRequestContextLengthExceededBehavior value)
        {
            return value switch
            {
                ChatCompletionRequestContextLengthExceededBehavior.Truncate => "truncate",
                ChatCompletionRequestContextLengthExceededBehavior.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionRequestContextLengthExceededBehavior? ToEnum(string value)
        {
            return value switch
            {
                "truncate" => ChatCompletionRequestContextLengthExceededBehavior.Truncate,
                "error" => ChatCompletionRequestContextLengthExceededBehavior.Error,
                _ => null,
            };
        }
    }
}