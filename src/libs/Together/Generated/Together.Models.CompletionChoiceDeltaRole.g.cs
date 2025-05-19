
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum CompletionChoiceDeltaRole
    {
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        Function,
        /// <summary>
        /// 
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompletionChoiceDeltaRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionChoiceDeltaRole value)
        {
            return value switch
            {
                CompletionChoiceDeltaRole.System => "system",
                CompletionChoiceDeltaRole.User => "user",
                CompletionChoiceDeltaRole.Assistant => "assistant",
                CompletionChoiceDeltaRole.Function => "function",
                CompletionChoiceDeltaRole.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionChoiceDeltaRole? ToEnum(string value)
        {
            return value switch
            {
                "system" => CompletionChoiceDeltaRole.System,
                "user" => CompletionChoiceDeltaRole.User,
                "assistant" => CompletionChoiceDeltaRole.Assistant,
                "function" => CompletionChoiceDeltaRole.Function,
                "tool" => CompletionChoiceDeltaRole.Tool,
                _ => null,
            };
        }
    }
}