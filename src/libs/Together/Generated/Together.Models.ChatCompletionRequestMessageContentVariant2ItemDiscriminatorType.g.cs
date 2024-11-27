
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionRequestMessageContentVariant2ItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        ImageUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionRequestMessageContentVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionRequestMessageContentVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                ChatCompletionRequestMessageContentVariant2ItemDiscriminatorType.Text => "text",
                ChatCompletionRequestMessageContentVariant2ItemDiscriminatorType.ImageUrl => "image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionRequestMessageContentVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "text" => ChatCompletionRequestMessageContentVariant2ItemDiscriminatorType.Text,
                "image_url" => ChatCompletionRequestMessageContentVariant2ItemDiscriminatorType.ImageUrl,
                _ => null,
            };
        }
    }
}