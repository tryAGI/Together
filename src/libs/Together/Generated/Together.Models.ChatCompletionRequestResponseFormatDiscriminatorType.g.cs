
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public enum ChatCompletionRequestResponseFormatDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        JsonObject,
        /// <summary>
        ///
        /// </summary>
        JsonSchema,
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionRequestResponseFormatDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionRequestResponseFormatDiscriminatorType value)
        {
            return value switch
            {
                ChatCompletionRequestResponseFormatDiscriminatorType.JsonObject => "json_object",
                ChatCompletionRequestResponseFormatDiscriminatorType.JsonSchema => "json_schema",
                ChatCompletionRequestResponseFormatDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionRequestResponseFormatDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => ChatCompletionRequestResponseFormatDiscriminatorType.JsonObject,
                "json_schema" => ChatCompletionRequestResponseFormatDiscriminatorType.JsonSchema,
                "text" => ChatCompletionRequestResponseFormatDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}