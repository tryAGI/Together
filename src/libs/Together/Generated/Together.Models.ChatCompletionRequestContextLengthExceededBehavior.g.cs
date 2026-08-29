
#nullable enable

namespace Together
{
    /// <summary>
    /// Defines the behavior of the API when max_tokens exceed the maximum context length of the model. When set to 'error', the API returns 400 with an appropriate error message. When set to 'truncate', overrides max_tokens with the maximum context length of the model.<br/>
    /// Default Value: error
    /// </summary>
    public enum ChatCompletionRequestContextLengthExceededBehavior
    {
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Truncate,
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
                ChatCompletionRequestContextLengthExceededBehavior.Error => "error",
                ChatCompletionRequestContextLengthExceededBehavior.Truncate => "truncate",
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
                "error" => ChatCompletionRequestContextLengthExceededBehavior.Error,
                "truncate" => ChatCompletionRequestContextLengthExceededBehavior.Truncate,
                _ => null,
            };
        }
    }
}