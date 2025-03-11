
#nullable enable

namespace Together
{
    /// <summary>
    /// The training method to use. 'sft' for Supervised Fine-Tuning or 'dpo' for Direct Preference Optimization.<br/>
    /// Default Value: sft
    /// </summary>
    public enum RequestTrainingMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Sft,
        /// <summary>
        /// 
        /// </summary>
        Dpo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestTrainingMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestTrainingMethod value)
        {
            return value switch
            {
                RequestTrainingMethod.Sft => "sft",
                RequestTrainingMethod.Dpo => "dpo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestTrainingMethod? ToEnum(string value)
        {
            return value switch
            {
                "sft" => RequestTrainingMethod.Sft,
                "dpo" => RequestTrainingMethod.Dpo,
                _ => null,
            };
        }
    }
}