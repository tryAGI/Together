
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum CompletionRequestSafetyModel
    {
        /// <summary>
        /// 
        /// </summary>
        MetaLlamaDivideLlamaGuard7b,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompletionRequestSafetyModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionRequestSafetyModel value)
        {
            return value switch
            {
                CompletionRequestSafetyModel.MetaLlamaDivideLlamaGuard7b => "Meta-Llama/Llama-Guard-7b",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionRequestSafetyModel? ToEnum(string value)
        {
            return value switch
            {
                "Meta-Llama/Llama-Guard-7b" => CompletionRequestSafetyModel.MetaLlamaDivideLlamaGuard7b,
                _ => null,
            };
        }
    }
}