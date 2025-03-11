
#nullable enable

namespace Together
{
    /// <summary>
    /// Default Value: sft
    /// </summary>
    public enum FinetuneResponseTrainingMethod
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
    public static class FinetuneResponseTrainingMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FinetuneResponseTrainingMethod value)
        {
            return value switch
            {
                FinetuneResponseTrainingMethod.Sft => "sft",
                FinetuneResponseTrainingMethod.Dpo => "dpo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FinetuneResponseTrainingMethod? ToEnum(string value)
        {
            return value switch
            {
                "sft" => FinetuneResponseTrainingMethod.Sft,
                "dpo" => FinetuneResponseTrainingMethod.Dpo,
                _ => null,
            };
        }
    }
}