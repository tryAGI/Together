
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionRequestCompliance
    {
        /// <summary>
        /// 
        /// </summary>
        Hipaa,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionRequestComplianceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionRequestCompliance value)
        {
            return value switch
            {
                ChatCompletionRequestCompliance.Hipaa => "hipaa",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionRequestCompliance? ToEnum(string value)
        {
            return value switch
            {
                "hipaa" => ChatCompletionRequestCompliance.Hipaa,
                _ => null,
            };
        }
    }
}