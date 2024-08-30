
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionSystemMessageParamRole
    {
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionSystemMessageParamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionSystemMessageParamRole value)
        {
            return value switch
            {
                ChatCompletionSystemMessageParamRole.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionSystemMessageParamRole? ToEnum(string value)
        {
            return value switch
            {
                "system" => ChatCompletionSystemMessageParamRole.System,
                _ => null,
            };
        }
    }
}