
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
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        Function,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        Tool,
        /// <summary>
        /// 
        /// </summary>
        User,
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
                CompletionChoiceDeltaRole.Assistant => "assistant",
                CompletionChoiceDeltaRole.Function => "function",
                CompletionChoiceDeltaRole.System => "system",
                CompletionChoiceDeltaRole.Tool => "tool",
                CompletionChoiceDeltaRole.User => "user",
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
                "assistant" => CompletionChoiceDeltaRole.Assistant,
                "function" => CompletionChoiceDeltaRole.Function,
                "system" => CompletionChoiceDeltaRole.System,
                "tool" => CompletionChoiceDeltaRole.Tool,
                "user" => CompletionChoiceDeltaRole.User,
                _ => null,
            };
        }
    }
}