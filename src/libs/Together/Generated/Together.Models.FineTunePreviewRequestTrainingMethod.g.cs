
#nullable enable

namespace Together
{
    /// <summary>
    /// Fine-tuning method to preview. Only supervised fine-tuning is currently supported.<br/>
    /// Default Value: sft
    /// </summary>
    public enum FineTunePreviewRequestTrainingMethod
    {
        /// <summary>
        ///
        /// </summary>
        Sft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTunePreviewRequestTrainingMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTunePreviewRequestTrainingMethod value)
        {
            return value switch
            {
                FineTunePreviewRequestTrainingMethod.Sft => "sft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTunePreviewRequestTrainingMethod? ToEnum(string value)
        {
            return value switch
            {
                "sft" => FineTunePreviewRequestTrainingMethod.Sft,
                _ => null,
            };
        }
    }
}